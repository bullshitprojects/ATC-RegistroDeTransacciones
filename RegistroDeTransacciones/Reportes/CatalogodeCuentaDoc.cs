using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using SistemaDePagoEmpleados;
using System;
using System.Collections.Generic;
using System.IO;

namespace RegistroDeTransacciones.Reportes
{
    class CatalogodeCuentaDoc
    {
        public string path;
        int aux = 1;
        public void PrintDocument(List<CatalogoDeCuentas> lista)
        {
            //FUENTES Y COLORES
            Color navy = new DeviceRgb(44, 59, 84);
            Color gray = new DeviceRgb(217, 217, 217);
            PdfFont normal = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA);
            //ESTILOS
            Dictionary<int, Style> mainStyles = new Dictionary<int, Style>
             {
            //TITULO CENTRADO
            {100, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.CENTER) },
            //TEXTO NORMAL ALINEADO IZQUIERA FONDO GRIS
            {101, new Style().SetBackgroundColor(gray).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.LEFT) },
            //TEXTO NORMAL ALINEAMIENTO IZQUIERDA
            {102, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.LEFT) },
            //TEXTO DE ENCABEZADO DE COLUMNAS
           {105, new Style().SetBackgroundColor(navy).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.WHITE).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.LEFT) }
             };

            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = System.IO.Path.Combine(exportFolder, "Catálogo de Cuentas.pdf");
            while (File.Exists(path))
            {
                path = System.IO.Path.Combine(exportFolder, "Catálogo de Cuentas(" + aux + ").pdf");
                aux++;
            }
            using (var writer = new PdfWriter(path))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4);
                    doc.SetMargins(35, 35, 35, 35);
                    Table tabla = new Table(new float[3]).UseAllAvailableWidth();
                    Cell content = new Cell(1, 3).Add(new Paragraph("Catálogo de Cuentas")).AddStyle(mainStyles[100]);
                    tabla.AddCell(content);
                    content = new Cell(1, 3).Add(new Paragraph("\n ")).AddStyle(mainStyles[100]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Código")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Cuenta")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    content = new Cell(1, 1).Add(new Paragraph("Naturaleza")).AddStyle(mainStyles[105]);
                    tabla.AddCell(content);
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Codigo)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Cuenta)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Naturaleza)).AddStyle(mainStyles[102]);
                            tabla.AddCell(content);
                        }
                        else
                        {
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Codigo)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Cuenta)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                            content = new Cell(1, 1).Add(new Paragraph(lista[i].Naturaleza)).AddStyle(mainStyles[101]);
                            tabla.AddCell(content);
                        }
                    }
                    doc.Add(tabla);
                    doc.Close();
                }
            }
        }
    }
}
