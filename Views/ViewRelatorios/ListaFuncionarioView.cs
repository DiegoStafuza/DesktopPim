using DesktopPim.Controllers;
using DesktopPim.Model;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace DesktopPim.Views.ViewDuvidas
{
    public partial class ListaFuncionarioView : Form
    {
        FuncionariosController func = new();
        RelatorioController relatorios = new RelatorioController();
        public ListaFuncionarioView()
        {
            InitializeComponent();


        }

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(comboBoxAno.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Preencha as informações corretamente antes de realizar a busca", "Erro ao buscar lançamentos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //string mesSelecionado = comboBoxMes.SelectedIndex.ToString("D2");
                    string anoSelecionado = comboBoxAno.SelectedItem.ToString();
                    int funcionarioId = (int)comboBoxFuncionarios.SelectedValue;

                    relatorios.LoadDataPgto(this, anoSelecionado, funcionarioId);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao tentar buscar as informações de pagamentos do funcionário. \n Status: {ex.Message}", "Tente novamente masis tarde.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void ListaFuncionarioView_Load(object sender, EventArgs e)
        {
            await func.LoadFuncionarios(this);
            IniciarComboBoxes();
        }

        public void IniciarComboBoxes()
        {

            comboBoxAno.Items.Insert(0, string.Empty);
            comboBoxAno.Items.Insert(1, "2023");
            comboBoxAno.Items.Insert(2, "2024");
            comboBoxAno.Items.Insert(3, "2025");
            comboBoxAno.Items.Insert(4, "2026");
            comboBoxAno.Items.Insert(5, "2027");
            comboBoxAno.Items.Insert(6, "2028");
            comboBoxAno.Items.Insert(7, "2029");
            comboBoxAno.Items.Insert(8, "2030");


        }
        private void buttonGeraPDF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxAno.SelectedItem?.ToString()) || string.IsNullOrEmpty(comboBoxFuncionarios.SelectedItem?.ToString()))
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
        public class RodapeEvento : PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                base.OnEndPage(writer, document);


                Font font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                DateTime dataHoraAtual = DateTime.Now;
                string texto = $"{dataHoraAtual} ";

                ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_RIGHT, new Phrase(texto, font),
                    document.Right, document.Bottom - 10, 0);
            }
        }


        private void GerarPDF()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();

            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string filePath = @$"C:\PIM\Relatorios\";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            try
            {

                string arquivo = filePath + $"pagamento{timestamp}.pdf";

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(arquivo, FileMode.Create));
                writer.PageEvent = new PdfHeader();
                writer.PageEvent = new RodapeEvento();
                doc.Open();



                BaseColor customColor = new BaseColor(4, 120, 87);
                BaseColor customColor2 = new BaseColor(220, 220, 220);
                BaseColor customColor3 = new BaseColor(97, 135, 91);
                BaseColor customColor4 = new BaseColor(183, 8, 29);



                Font titleFonte = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, customColor);
                Paragraph title = new Paragraph($"Pagamentos de {comboBoxFuncionarios.Text} em {comboBoxAno.Text}", titleFonte);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 30;
                doc.Add(title);

                Font infoFont = FontFactory.GetFont(FontFactory.HELVETICA, 16, BaseColor.BLACK);
                Paragraph infos = new Paragraph();
                infos.Add(new Chunk($"Funcionário: {comboBoxFuncionarios.Text}\n", infoFont));
                infos.SpacingAfter = 25;
                infos.SpacingBefore = 30;
                infos.Alignment = Element.ALIGN_LEFT;
                doc.Add(infos);

                PdfPTable table = new PdfPTable(dataGridViewDados.Columns.Count);
                table.WidthPercentage = 100;

                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.WHITE);
                for (int i = 0; i < dataGridViewDados.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridViewDados.Columns[i].HeaderText, headerFont));
                    cell.BackgroundColor = customColor;
                    table.AddCell(cell);
                }

                Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);
                Font valorFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                for (int i = 0; i < dataGridViewDados.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewDados.Columns.Count; j++)
                    {
                        if (dataGridViewDados[j, i].Value != null)
                        {
                            string cellValue = dataGridViewDados[j, i].Value.ToString();
                            PdfPCell cell = new PdfPCell(new Phrase(cellValue, cellFont));
                            cell.BackgroundColor = customColor2;
                            table.AddCell(cell);
                        }
                    }
                }
                doc.Add(table);

                doc.Close();

                MessageBox.Show("PDF gerado com sucesso!", "PDF gerado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (System.IO.File.Exists(arquivo))
                {
                    ProcessStartInfo psi = new ProcessStartInfo(arquivo);
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                }
                else
                {
                    MessageBox.Show("Arquivo PDF não encontrado.", "Erro ao encontrar PDF.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível gerar o PDF. Tente novamente mais tarde! \n Status: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
