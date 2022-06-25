
using MedidoresWebModel.DAL;
using MedidoresWebModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace medidoresweb
{
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new medidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string medidores = this.numeromedidor.Text.Trim();
                string tipo = this.TipoTxt.Text.Trim();
                Medidores medidor = new Medidores()
                {
                    NumeroMedidor = medidores,
                    Tipo = tipo
                };
                medidoresDAL.Agregar(medidor);
                this.mensaje.Text = ("Agregado exitosamente");
                Response.Redirect("Default.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('Error, Al Agregar');</script>");
            }
        }
    }
}
