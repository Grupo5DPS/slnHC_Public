using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_CSharp
{
    public partial class Escuela : System.Web.UI.Page
    {
        private srEscuelaCSharp.WebService1SoapClient servicio;
        private void Listar()
        {
            servicio = new srEscuelaCSharp.WebService1SoapClient();
            gvEscuela.DataSource = servicio.Listar();
            gvEscuela.DataBind();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar();
            }

        }

        protected void gvEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio = new srEscuelaCSharp.WebService1SoapClient();
            //string[] aea;
            //aea = servicio.Agregar(txt1.Text, txt2.Text);
            //lbl1.Text = aea[1];
            //lbl2.Text = aea[0];
            Listar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Tamano = FileUpload1.PostedFile.ContentLength;
            byte[] ImagenOriginal = new byte[Tamano];
            FileUpload1.PostedFile.InputStream.Read(ImagenOriginal, 0, Tamano);
            Bitmap ImagenOriginalBinaria = new Bitmap(FileUpload1.PostedFile.InputStream);
            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImagenOriginal);
            imgPreview.ImageUrl = ImagenDataURL64;
            //byte[] data = System.IO.File.ReadAllBytes(FileUpload1.PostedFile);
            string result = System.Text.Encoding.ASCII.GetString(ImagenOriginal);
            lbl1.Text = Convert.ToString(ImagenDataURL64);
            //servicio.AgregarFoto(Convert.ToString(txtTexto), result);

        }
    }
}