using DesktopPim.Model;
using DesktopPim.Views.ViewHome.Mensal;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using System.Diagnostics;
using Rectangle = iTextSharp.text.Rectangle;
using Paragraph = iTextSharp.text.Paragraph;
using Microsoft.IdentityModel.Tokens;
using Azure;

namespace DesktopPim.Views
{
    public partial class PayrollView : Form
    {
        private List<FuncionarioDetalhes> funcionarioDetalhes;
        private List<FuncionariosCalculo> funcionariosCalculos;
        CalculaFolhaController calculaFolha = new CalculaFolhaController();
        public PayrollView()
        {
            InitializeComponent();
            dataGridViewDescontos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            calculaFolha.IniciarComboBoxes(this);

        }
        async void PayrollView_Load(object sender, EventArgs e)
        {
            funcionariosCalculos = await calculaFolha.ObterTodosFuncionarios();
            comboBoxFuncionarios.DataSource = funcionariosCalculos;
            comboBoxFuncionarios.DisplayMember = "nome_funcionario";

        }



        async void comboBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFuncionarios.SelectedItem != null)
            {
                int selectedFuncionariId = (comboBoxFuncionarios.SelectedItem as FuncionariosCalculo).id_funcionario;

                var funcionarioDetalhes = await calculaFolha.ObterDetalhesFuncionarioPorId(selectedFuncionariId);

                if (funcionarioDetalhes != null)
                {
                    if (dataGridViewDescontos.Columns.Count == 0)
                    {

                        dataGridViewDescontos.Columns.Add("ID", "ID");
                        dataGridViewDescontos.Columns.Add("Tipo", "Tipo");
                        dataGridViewDescontos.Columns.Add("Nome", "Nome");
                        dataGridViewDescontos.Columns.Add("Valor", "Valor");
                    }
                    dataGridViewDescontos.Rows.Clear();

                    //int id = dataGridViewDescontos.Rows.Count + 1;


                    dataGridViewDescontos.Rows.Add(1, "Provento", "Salário", funcionarioDetalhes.salario);


                    dataGridViewDescontos.Rows.Add(dataGridViewDescontos.Rows.Count + 1, "Desconto", "INSS", funcionarioDetalhes.descontoINSS);
                    dataGridViewDescontos.Rows.Add(dataGridViewDescontos.Rows.Count + 1, "Desconto", "IRRF", funcionarioDetalhes.descontoIRRF);
                    dataGridViewDescontos.Rows.Add(dataGridViewDescontos.Rows.Count + 1, "Desconto", "FGTS", funcionarioDetalhes.descontoFGTS);

                    await PreencherDetalhesFuncionario(funcionarioDetalhes);

                    CalcularValorLiquido();
                }
                else
                {
                    LimparCamposDetalhesFuncionario();
                }
            }
        }

        public async Task PreencherDetalhesFuncionario(FuncionarioDetalhes funcionario)
        {
            if (funcionario != null)
            {
                textBoxDepto.Text = funcionario.departamento;
                textBoxSalario.Text = "R$ " + funcionario.salario.ToString();
                textBoxCargo.Text = funcionario.cargo;

                textBoxDepto.Enabled = false;
                textBoxSalario.Enabled = false;
                textBoxCargo.Enabled = false;
            }
        }
        void LimparCamposDetalhesFuncionario()
        {

            textBoxDepto.Text = string.Empty;
            textBoxSalario.Text = string.Empty;
            textBoxCargo.Text = string.Empty;


            textBoxDepto.Enabled = true;
            textBoxSalario.Enabled = true;
            textBoxCargo.Enabled = true;
        }


        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(this);
        }

        private PayrollAdicionaValor formularioModal;

        private void AbrirFormularioModal(PayrollView payrollView)
        {
            if (formularioModal == null || formularioModal.IsDisposed)
            {
                formularioModal = new PayrollAdicionaValor(payrollView);
                formularioModal.FormClosed += (sender, e) => formularioModal = null;
                formularioModal.Show();
            }
            else
            {
                formularioModal.BringToFront();
            }
        }

        private void dataGridViewDescontos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDescontos.Columns["Valor"].Index && e.Value != null)
            {

                if (e.Value is decimal || e.Value is double || e.Value is float)
                {

                    e.Value = string.Format("R$ {0:N2}", e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        public void CalcularValorLiquido()
        {
            decimal totalProventos = 0;
            decimal totalDescontos = 0;
            string desconto = "DESCONTO";
            string provento = "PROVENTO";

            foreach (DataGridViewRow row in dataGridViewDescontos.Rows)
            {
                if (row.Cells["Tipo"].Value.ToString().ToUpper() == desconto)
                {
                    if (decimal.TryParse(row.Cells["Valor"].Value.ToString(), out decimal valorDesconto))
                    {
                        totalDescontos += valorDesconto;
                    }
                }
                else if (row.Cells["Tipo"].Value.ToString().ToUpper() == provento)
                {
                    if (decimal.TryParse(row.Cells["Valor"].Value.ToString(), out decimal valorProvento))
                    {
                        totalProventos += valorProvento;
                    }
                }
            }
            decimal valorLiquido = totalProventos - totalDescontos;

            labelValorLiquido.Text = $"Valor líquido: R$ {valorLiquido}";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Provento> proventos = new List<Provento>();
                foreach (DataGridViewRow r in dataGridViewDescontos.Rows)
                {
                    string tipoValor = r.Cells["Tipo"].Value.ToString();
                    string nomeValor = r.Cells["Nome"].Value.ToString();
                    decimal valor = Convert.ToDecimal(r.Cells["Valor"].Value);

                    proventos.Add(new Provento
                    {
                        NomeValor = nomeValor,
                        TipoValor = tipoValor,
                        Valor = valor
                    });

                }

                if (comboBoxMes.SelectedIndex <= 0 || string.IsNullOrEmpty(comboBoxAno.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Preencha as informações corretamente antes de realizar o envio", "Erro ao lançar folha.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string mes = (comboBoxMes.SelectedIndex).ToString("D2");
                    string ano = comboBoxAno.SelectedItem.ToString();
                    int? funcionarioId = (comboBoxFuncionarios.SelectedItem as FuncionariosCalculo)?.id_funcionario;

                    ProventosViewModel model = new ProventosViewModel
                    {
                        FuncionarioId = funcionarioId,
                        Ano = ano,
                        Mes = mes,
                        Proventos = proventos
                    };

                    await calculaFolha.AdicionarValores(model);

                    DialogResult dialogResult = MessageBox.Show("Deseja gerar um arquivo PDF desse lançamento?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        GerarPDF();
                    }
                    else
                    {

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível realizar o lançamento. Status: {ex.Message}", "Erro ao lançar folha.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxMes.SelectedIndex <= 0 || string.IsNullOrEmpty(comboBoxAno.SelectedItem?.ToString()))
            {
                MessageBox.Show("Preencha as informações corretamente antes de gerar o PDF", "Erro ao gerar PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GerarPDF();
            }
        }

        public class PdfHeader : PdfPageEventHelper
        {
            public override void OnStartPage(PdfWriter writer, Document document)
            {
                base.OnStartPage(writer, document);
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("C:\\Users\\diego\\OneDrive\\Documentos\\PIM\\HolFree.png");
                img.Alignment = Element.ALIGN_CENTER;
                document.Add(img);
            }
        }


        private void GerarPDF()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();

            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string filePath = $"C:\\HoleritesPIM\\holerite_{timestamp}.pdf";

            try
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Create);
                PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);
                writer.PageEvent = new PdfHeader();
                doc.Open();



                BaseColor customColor = new BaseColor(4, 120, 87);
                BaseColor customColor2 = new BaseColor(220, 220, 220);
                BaseColor customColor3 = new BaseColor(97, 135, 91);
                BaseColor customColor4 = new BaseColor(183, 8, 29);



                Font titleFonte = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, customColor);
                Paragraph title = new Paragraph($"Holerite de {comboBoxMes.SelectedItem} de {comboBoxAno.SelectedItem}", titleFonte);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 30;
                doc.Add(title);

                Font infoFont = FontFactory.GetFont(FontFactory.HELVETICA, 16, BaseColor.BLACK);
                Paragraph infos = new Paragraph();
                infos.Add(new Chunk($"Funcionário: {comboBoxFuncionarios.Text}\n", infoFont));
                infos.Add(new Chunk($"Departamento: {textBoxDepto.Text}\n", infoFont));
                infos.Add(new Chunk($"Cargo: {textBoxCargo.Text}\n", infoFont));
                infos.Add(new Chunk($"Salário bruto: {textBoxSalario.Text}\n", infoFont));
                infos.SpacingAfter = 25;
                infos.SpacingBefore = 30;
                infos.Alignment = Element.ALIGN_LEFT;
                doc.Add(infos);

                //Font mesesAnoFont = FontFactory.GetFont(FontFactory.HELVETICA, 16, BaseColor.BLACK);
                //Paragraph mesEAno = new Paragraph();
                //mesEAno.Add(new Chunk($"Mês de pagamento: {comboBoxMes.SelectedItem}\n", mesesAnoFont));
                //mesEAno.Add(new Chunk($"Ano de pagamento: {comboBoxAno.SelectedItem}\n", mesesAnoFont));
                //mesEAno.SpacingAfter = 25;
                //mesEAno.SpacingBefore = 40;
                //mesEAno.Alignment = Element.ALIGN_BOTTOM;
                //doc.Add(mesEAno);

                PdfPTable table = new PdfPTable(dataGridViewDescontos.Columns.Count);
                table.WidthPercentage = 100;

                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.WHITE);
                for (int i = 0; i < dataGridViewDescontos.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridViewDescontos.Columns[i].HeaderText, headerFont));
                    cell.BackgroundColor = customColor;
                    table.AddCell(cell);
                }

                Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);
                Font valorFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                for (int i = 0; i < dataGridViewDescontos.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewDescontos.Columns.Count; j++)
                    {
                        if (dataGridViewDescontos[j, i].Value != null)
                        {
                            string cellValue = dataGridViewDescontos[j, i].Value.ToString();
                            string tipo = dataGridViewDescontos[j, i].Value.ToString();

                            if (dataGridViewDescontos.Columns[j].Name == "Tipo")
                            {
                                if (tipo.ToUpper() == "DESCONTO")
                                {
                                    valorFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, customColor4);
                                }
                                else if (tipo.ToUpper() == "PROVENTO")
                                {
                                    valorFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, customColor3);
                                }
                            }

                            if (dataGridViewDescontos.Columns[j].Name == "Valor")
                            {
                                cellValue = $"R$ {double.Parse(cellValue).ToString("N2")}";
                                PdfPCell cell = new PdfPCell(new Phrase(cellValue, valorFont));
                                cell.FixedHeight = 20;
                                cell.BackgroundColor = customColor2;
                                table.AddCell(cell);
                            }
                            else
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(cellValue, cellFont));
                                cell.FixedHeight = 10;
                                cell.BackgroundColor = customColor2;
                                table.AddCell(cell);
                            }
                        }
                    }
                }
                doc.Add(table);


                Font salarioFont = FontFactory.GetFont(FontFactory.HELVETICA, 16, BaseColor.BLACK);
                Paragraph salarioLiquido = new Paragraph($"{labelValorLiquido.Text}", salarioFont);
                salarioLiquido.SpacingBefore = 15;
                salarioLiquido.Alignment = Element.ALIGN_RIGHT;
                doc.Add(salarioLiquido);


                doc.Close();

                MessageBox.Show("PDF gerado com sucesso!", "PDF gerado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (System.IO.File.Exists(filePath))
                {
                    ProcessStartInfo psi = new ProcessStartInfo(filePath);
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                }
                else
                {
                    MessageBox.Show("Arquivo PDF não encontrado.", "Erro ao encontrar PDF.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível gerar o PDF. Status: {ex.Message}");
            }
        }
    }
}
