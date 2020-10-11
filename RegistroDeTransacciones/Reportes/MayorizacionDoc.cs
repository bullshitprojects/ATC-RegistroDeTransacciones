using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeTransacciones.Reportes
{
    class MayorizacionDoc
    {
        public string path;
        public void PrintDocument(List<Mayorizacion> lista)
        {
            //FUENTES Y COLORES
            iText.Kernel.Colors.Color navy = new DeviceRgb(44, 59, 84);
            iText.Kernel.Colors.Color gray = new DeviceRgb(217, 217, 217);
            PdfFont normal = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA);
            PdfFont bold = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);

            //ESTILOS
            Dictionary<int, Style> mainStyles = new Dictionary<int, Style>
             {
                 //TITULO CENTRADO
                 {100, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.CENTER) },
                 //TEXTO NORMAL ALINEADO IZQUIERA FONDO GRIS
                {101, new Style().SetBackgroundColor(gray).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.LEFT) },
                 //TEXTO NORMAL ALINEAMIENTO IZQUIERDA
                 {102, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.LEFT) },
                //Fecha de impresion
                {103, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(9).SetFont(normal).SetTextAlignment(TextAlignment.LEFT) },
                 //TEXTO DE ENCABEZADO DE COLUMNAS
                {105, new Style().SetBackgroundColor(navy).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.WHITE).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.LEFT) }
             };

            string fecha = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = System.IO.Path.Combine(exportFolder, "Mayorización(" + fecha + ").pdf");

            using (var writer = new PdfWriter(path))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4.Rotate());
                    doc.SetMargins(35, 35, 35, 35);
                    Table tabla = new Table(new float[8]).UseAllAvailableWidth();
                    Cell content = new Cell(1, 8).Add(new Paragraph("Mayorización")).AddStyle(mainStyles[100]);
                    tabla.AddCell(content);
                    content = new Cell(1, 8).Add(new Paragraph("\n ")).AddStyle(mainStyles[100]);
                    tabla.AddCell(content);

                    content = new Cell(1, 1).Add(new Paragraph("Fecha")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Código")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Cuenta")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Concepto")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Parcial")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Debe")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Haber")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Saldo")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);

                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Fecha)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Codigo)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Cuenta)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Concepto)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Parcial)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph("$ " + lista[i].Debe)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph("$ " + lista[i].Haber)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph("$ " + lista[i].Saldo)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                        }
                        else
                        {
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Fecha)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Codigo)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Cuenta)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Concepto)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Parcial)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph("$ " + lista[i].Debe)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph("$ " + lista[i].Haber)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph("$ " + lista[i].Saldo)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                        }
                    }

                    //espacios
                    content = new Cell(1, 8).Add(new Paragraph("\n ")).AddStyle(mainStyles[100]);
                    tabla.AddCell(content);
                    content = new Cell(1, 8).Add(new Paragraph("\n ")).AddStyle(mainStyles[100]);
                    tabla.AddCell(content);
                    //pie de página
                    content = new Cell(1, 8).Add(new Paragraph("Fecha de impresión: " + DateTime.Now.ToString())).AddStyle(mainStyles[103]);
                    tabla.AddCell(content);
                    doc.Add(tabla);
                    doc.Close();
                }
            }
        }
    }
}
