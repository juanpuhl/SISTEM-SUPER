using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Wmf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Newtonsoft.Json.Linq;
using SISTEM_SUPER.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// PARA GENERAR LOS REPORTES UTILICE LA LIBERERIA ITEXT 7, VERSION 7.1.10

namespace SISTEM_SUPER
{
    public partial class FrmInformeStockProductos : Form
    {

        Productos objetoPro= new Productos();
        public FrmInformeStockProductos()
        {
            InitializeComponent();
          
            
            //pdfViewer1.Load("C:/Users/juanp/source/repos/EJERCICIOS/tp metodo constructor/SISTEM SUPER/SISTEM SUPER/bin/Debug/ReporteStock.pdf");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //string filtro = txtFiltro.Text; // para el lector de pdf
            crearPDF(); //en el metodo ponemos la variable creada
            axAcroPDF.src = "C:/Users/juanp/source/repos/EJERCICIOS/tp metodo constructor/SISTEM SUPER/SISTEM SUPER/bin/Debug/ReporteStock.pdf";


        }

        //CREAMOS EL PDF CON LOGO, VISUAL ETC....

        //private void crearPDF( string filtro)
        private void crearPDF()
        {

            //crear el documento y se guarda en la raiz del programa, se puede poner la direccion de carpeta
            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            //1 pulgada =72 pt 
            //personalizar el tamaño de una hoja
            PageSize  tamanioH = new PageSize(792 , 612);
            Document documento = new Document(pdf,tamanioH ); //PageSize.LETTER //docuemnto carta

            //agregamos margenes

            documento.SetMargins(75,20,55,20);

            ////////////
            ///de prueba para ver si me generaba el pdf....
            /*var parrafo = new Paragraph("Hola Mundo .............. ");
            documento.Add(parrafo);
            documento.Close();*/
            ////////////////////////

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            //TITULOS COLUMNAS
            string[] columnas = { "CODIGO", "NOMBRE", "DESCRIPCION", "MARCA", "PRECIO COMPRA", "PRECIO VENTA", "STOCK"};

            //para mostrar los datos
            float[] tamanios = {1,4,4,4,4,4,4 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            //impresion de los datos
           
            List<Productos> listaProductos = objetoPro.ObtenerProductos();
            listaProductos = listaProductos.OrderBy(producto => producto.Nombre).ToList();

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }
            // Agregar filas de datos a la tabla
            foreach (var producto in listaProductos)
            {
                tabla.AddCell(producto.Codigo);
                tabla.AddCell(producto.Nombre);
                tabla.AddCell(producto.Descripcion);
                tabla.AddCell(producto.Marca);
                tabla.AddCell(producto.PrecioCompra);
                tabla.AddCell(producto.PrecioVenta);
                tabla.AddCell(producto.Stock.ToString());
            }


            documento.Add(tabla);
            documento.Close();


            // agregar encabezado y pie de paginas logos

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/juanp/Pictures/logo super los dos chinos.png")).SetWidth(50);
            var parrafologo =new Paragraph("").Add(logo);
            var titulo = new Paragraph("REPORTE DE STOCK PRODUCTOS");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);
            var dfecha = DateTime.Now.ToString("dd-mm-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\n Hora: " + dhora );
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter("ReporteStock.pdf"));

            //para saber cuantas paginas tiene el documento
            Document doc = new Document(pdfDoc);
            int numeros = pdfDoc.GetNumberOfPages();

            for (int i=1; i <= numeros; i++)
            {
                PdfPage Pagina = pdfDoc.GetPage(i);
                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(parrafologo , 40, y , i , TextAlignment.CENTER, VerticalAlignment.TOP,0);
                doc.ShowTextAligned(titulo, 190, y -10 , i , TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 600, y , i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                //pie de pagina
                doc.ShowTextAligned(new Paragraph(string.Format("Pagina {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth()/2, pdfDoc.GetPage(i).GetPageSize().GetBottom() +30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            }
            doc.Close();
           
        }

       
    }
}
