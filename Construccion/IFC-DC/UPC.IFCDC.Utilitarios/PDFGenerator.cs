using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data;

using UPC.IFCDC.BE;
using System.Diagnostics;

namespace UPC.IFCDC.Utilitarios
{
    public class PDFGenerator
    {
        String titulo = "ESCUELA DE INGENIERÍA DE SISTEMAS Y COMPUTACIÓN\nINFORME DE FIN DE CICLO \n\n";
        String titulo1 = "1.	Análisis de Resultado del Logro del Curso";
        String titulo11 = "1.1	Resultados alcanzados en el curso";
        String titulo12 = "1.2	 Hallazgos y Acciones de Mejora";
        String titulo121 = "1.2.1	Acciones de mejora previas:";
        String titulo122 = "1.2.2	Hallazgos Importantes:";
        String titulo123 = "1.2.3	Acciones de Mejora:";
        String titulo2 = "2.	Desarrollo de las Unidades de Aprendizaje";
        String titulo21 = "2.1	Infraestructura";
        String titulo22 = "2.2	Alumnos";
        String titulo3 = "3.	Apreciación del Delegado del Curso.";
        String titulo4 = "4.	Comentarios de la Encuesta Académica.";

        Font romanBold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12);
        Font romanNormal = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
        Font romanCursive = FontFactory.GetFont(FontFactory.TIMES_ITALIC, 12); 
        Font tableRomanBold = FontFactory.GetFont(FontFactory.TIMES_BOLD, 11);
        Font tableRomanNormal = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11);

        Paragraph par = null;
        Phrase ph = null;
        PdfPTable tb= null;

        public void generarPdf(String ciclo, String curso, String profesor, DataTable dtOutcomes, String resultAlcanzados, DataTable dtAcciones, DataTable dtHallazgos, DataTable dtMejora,
                String unidades, String infraestructura, String alumnos, String delegado, String encuesta,
            String rutaArchivo)
        {
            //String fileName = Server.MapPath("~/Plantillas/CrystalReports/crActa.rpt");
            //String fileName = System.IO.Path.GetTempPath() + nombreArchivo + ".pdf";

            String cic = "Ciclo : ";
            String cur = "Curso : ";
            String prof = "Profesor : ";
            String mes = DateTime.Now.ToString("MMMM");
            String piePagina = "Surco, " + mes.Substring(0,1).ToUpper() + mes.Substring(1,mes.Length - 1) + " del " + DateTime.Now.Year.ToString();

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 50, 50, 42, 42);
            PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.OpenOrCreate));
            doc.Open();


            //Image logo = Image.GetInstance("logoUPC.png");
            //logo.Alignment = Element.ALIGN_CENTER;
            //doc.Add(logo);

            par = new Paragraph(titulo,romanBold);
            par.Alignment = Element.ALIGN_CENTER;
            doc.Add(par);

            par = new Paragraph(addPhrase(cic, ciclo));
            par.Alignment = Element.ALIGN_LEFT;
            doc.Add(par);

            par = new Paragraph(addPhrase(cur, curso));
            par.Alignment = Element.ALIGN_LEFT;
            doc.Add(par);

            par = new Paragraph(addPhrase(prof,profesor));
            par.Alignment = Element.ALIGN_LEFT;
            doc.Add(par);

            par = new Paragraph("\n");
            doc.Add(par);   

            par = new Paragraph(titulo1 + "\n",romanBold);
            doc.Add(par);

            par = new Paragraph("\n");
            doc.Add(par); 
            
            //par = new Paragraph(analisisResultado + "\n\n", romanNormal);
            //doc.Add(par);
            doc.Add(addTable(dtOutcomes));

            par = new Paragraph("\n");
            doc.Add(par);  

            par = new Paragraph(titulo11 + "\n", romanBold);
            doc.Add(par);
            par = new Paragraph(resultAlcanzados + "\n\n", romanNormal);
            doc.Add(par);

            par = new Paragraph(titulo12 + "\n\n", romanBold);
            doc.Add(par);

            par = new Paragraph(titulo121 + "\n\n", romanBold);
            doc.Add(par);

            doc.Add(addTable(dtAcciones));

            par = new Paragraph("\n");
            doc.Add(par);   

            par = new Paragraph(titulo122 + "\n\n", romanBold);
            doc.Add(par);

            doc.Add(addTable(dtHallazgos));

            par = new Paragraph("\n");
            doc.Add(par);   

            par = new Paragraph(titulo123 + "\n\n", romanBold);
            doc.Add(par);

            doc.Add(addTable(dtMejora));

            par = new Paragraph("\n");
            doc.Add(par);   

            par = new Paragraph(titulo2 + "\n", romanBold);
            doc.Add(par);
            par = new Paragraph(unidades + "\n\n", romanNormal);
            doc.Add(par);

            par = new Paragraph(titulo21 + "\n", romanBold);
            doc.Add(par);
            par = new Paragraph(infraestructura + "\n\n", romanNormal);
            doc.Add(par);

            par = new Paragraph(titulo22 + "\n", romanBold);
            doc.Add(par);
            par = new Paragraph(alumnos + "\n\n", romanNormal);
            doc.Add(par);

            par = new Paragraph(titulo3 + "\n", romanBold);
            doc.Add(par);
            par = new Paragraph(delegado + "\n\n", romanNormal);
            doc.Add(par);

            par = new Paragraph(titulo4 + "\n", romanBold);
            doc.Add(par);
            par = new Paragraph(encuesta + "\n\n", romanNormal);
            doc.Add(par);

            par = new Paragraph(piePagina, romanCursive);
            par.Alignment = Element.ALIGN_RIGHT;
            doc.Add(par);

            doc.Close();

            Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = rutaArchivo;
            prc.Start();
        }

        public void generearReporteHallazgos(String curso, String periodo, DataTable dtHallazgos, String ruta)
        {
            String tituloCurso = "Curso : ";
            String tituloPeriodo = "Periodo : ";
            String mes = DateTime.Now.ToString("MMMM");
            String piePagina = "Surco, " + mes.Substring(0, 1).ToUpper() + mes.Substring(1, mes.Length - 1) + " del " + DateTime.Now.Year.ToString();

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 50, 50, 42, 42);
            PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open();

            par = new Paragraph("REPORTE DE HALLAZGOS", romanBold);
            par.Alignment = Element.ALIGN_CENTER;
            doc.Add(par);

            par = new Paragraph(addPhrase(tituloCurso, curso));
            par.Alignment = Element.ALIGN_LEFT;
            doc.Add(par);

            par = new Paragraph(addPhrase(tituloPeriodo, periodo));
            par.Alignment = Element.ALIGN_LEFT;
            doc.Add(par);

            par = new Paragraph("\n");
            doc.Add(par);

            doc.Add(addTable(dtHallazgos));

            par = new Paragraph("\n");
            doc.Add(par);

            par = new Paragraph(piePagina, romanCursive);
            par.Alignment = Element.ALIGN_RIGHT;
            doc.Add(par);

            doc.Close();

            Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = ruta;
            prc.Start();
        }

        public void generearReporteAcciones(String curso, String periodo, String estado, DataTable dtAcciones, String ruta)
        {
            String tituloCurso = "Ciclo : ";
            String tituloPeriodo = "Curso : ";
            String tituloEstado = "Profesor : ";
            String mes = DateTime.Now.ToString("MMMM");
            String piePagina = "Surco, " + mes.Substring(0, 1).ToUpper() + mes.Substring(1, mes.Length - 1) + " del " + DateTime.Now.Year.ToString();

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 50, 50, 42, 42);
            PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
            doc.Open();

            par = new Paragraph("REPORTE DE ACCIONES DE MEJORA", romanBold);
            par.Alignment = Element.ALIGN_CENTER;
            doc.Add(par);

            par = new Paragraph(addPhrase(tituloCurso, curso));
            par.Alignment = Element.ALIGN_LEFT;
            doc.Add(par);

            par = new Paragraph(addPhrase(tituloPeriodo, periodo));
            par.Alignment = Element.ALIGN_LEFT;
            doc.Add(par);

            par = new Paragraph(addPhrase(tituloEstado, estado));
            par.Alignment = Element.ALIGN_LEFT;
            doc.Add(par);

            par = new Paragraph("\n");
            doc.Add(par);

            doc.Add(addTable(dtAcciones));

            par = new Paragraph("\n");
            doc.Add(par);

            par = new Paragraph(piePagina, romanCursive);
            par.Alignment = Element.ALIGN_RIGHT;
            doc.Add(par);

            doc.Close();

            Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = ruta;
            prc.Start();
        }

        private Phrase addPhrase(String titulo, String descripcion)
        {
            ph = new Phrase();
            ph.Add(new Chunk(titulo, romanBold));
            ph.Add(new Chunk(descripcion, romanNormal));

            return ph;
        }

        private PdfPTable addTable(DataTable dt)
        {
            float[] colunmWidth = null;
            
            switch(dt.Columns.Count)
            {
                case 2:
                    colunmWidth = new float[] { 22f, 80f};
                    break;
                case 3:
                    colunmWidth = new float[] { 22f, 58f, 20f};
                    break;
                case 5:
                    colunmWidth = new float[] { 15f, 15f, 35f, 15f, 15f };
                    break;
            }
            
            tb = new PdfPTable(dt.Columns.Count);
            tb.SetWidths(colunmWidth);

            for (int j = 0; j < dt.Columns.Count; j++)
                tb.AddCell(new Phrase(dt.Columns[j].ColumnName.ToString(),tableRomanBold));


            for (int i = 0; i < dt.Rows.Count; i++)
                for (int j = 0; j < dt.Columns.Count; j++)
                    tb.AddCell(new Phrase(dt.Rows[i][j].ToString(), tableRomanNormal));

            return tb;
        }
    }
}
