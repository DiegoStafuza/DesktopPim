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
using DesktopPim.Controllers;
using DesktopPim.Views.ViewHome;
using iText.Layout.Element;
using PdfSharp.Pdf.Advanced;
using static jdk.nashorn.@internal.codegen.CompilerConstants;
using Chilkat;
using iText.IO.Util;
using DesktopPim.Views.ViewDuvidas;

namespace DesktopPim.Views
{
    public partial class RelatoriosView : Form
    {
        DataGridView dView;
        public RelatoriosView(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dView = dataGrid;
        }
        public RelatoriosView()
        {
            InitializeComponent();
        }

        private async void buttonFuncionariosPDF_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja gerar um arquivo PDF de todos os funcionários?", "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                GerarPDF(dView);
            }
            else
            {

            }

        }

        public void ABrirFormFilho(Form formularioFilho)
        {
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }

            formularioFilho.TopLevel = false;
            formularioFilho.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formularioFilho);
            panelPrincipal.Tag = formularioFilho;
            formularioFilho.Show();
        }
        private void buttonPagamento_Click(object sender, EventArgs e)
        {
            ListaFuncionarioView listView = new();
            ABrirFormFilho(listView);
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

        public void GerarPDF(DataGridView dataGridView)
        {

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();

            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string filePath = @$"C:\PIM\Funcionarios\";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);

            }

            try
            {


                string arquivo = filePath + $"funcionarios{timestamp}.pdf";

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(arquivo, FileMode.Create));
                writer.PageEvent = new PdfHeader();
                writer.PageEvent = new RodapeEvento();

                doc.Open();



                BaseColor customColor = new BaseColor(4, 120, 87);
                BaseColor customColor2 = new BaseColor(220, 220, 220);
                BaseColor customColor3 = new BaseColor(97, 135, 91);
                BaseColor customColor4 = new BaseColor(183, 8, 29);



                Font titleFonte = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, customColor);
                Paragraph title = new Paragraph($"Relatório de funcionários", titleFonte);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingBefore = 20;
                title.SpacingAfter = 50;
                doc.Add(title);


                PdfPTable table = new PdfPTable(dataGridView.Columns.Count);
                table.WidthPercentage = 100;

                Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.WHITE);
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridView.Columns[i].HeaderText, headerFont));
                    cell.BackgroundColor = customColor;
                    table.AddCell(cell);
                }

                Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 11, BaseColor.BLACK);
                Font valorFont = FontFactory.GetFont(FontFactory.HELVETICA, 11, BaseColor.BLACK);

                foreach (DataGridViewRow r in dataGridView.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        string cellValue = (c.Value).ToString();
                        PdfPCell pdfCell = new PdfPCell(new Phrase(cellValue, valorFont));
                        pdfCell.FixedHeight = 25;
                        pdfCell.BackgroundColor = customColor2;
                        table.AddCell(pdfCell);
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
