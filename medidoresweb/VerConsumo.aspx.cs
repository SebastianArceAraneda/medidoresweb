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
    public partial class VerConsumo : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new medidoresDALObjetos();
        private ILecturasDAL lecturasDAL = new lecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                List<Medidores> medidores = medidoresDAL.ObtenerMedidor();
                List<Medidores> medidor = medidoresDAL.Obtener(); ;
                cargaGrilla();
                if (medidor.Count == 0)
                {

                    medidor.AddRange(medidores);
                }

                this.tipoDdl.DataSource = medidor;
                this.tipoDdl.DataTextField = "numeroMedidor";
                this.tipoDdl.DataValueField = "numeroMedidor";
                this.tipoDdl.DataBind();
            }
        }


        private void cargaGrilla()
        {
            List<Lecturas> lectura = lecturasDAL.Obtener();
            this.grilla.DataSource = lectura;
            this.grilla.DataBind();
        }
        private void cargaGrilla(List<Lecturas> filtro)
        {
            List<Lecturas> clientes = lecturasDAL.Obtener();
            this.grilla.DataSource = filtro;
            this.grilla.DataBind();
        }
        protected void grilla_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string delete = Convert.ToString(e.CommandArgument);
                lecturasDAL.Eliminar(delete);
                cargaGrilla();
            }
        }

        protected void nivelDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipoDdl.SelectedItem != null)
            {
                string nivel = this.tipoDdl.SelectedItem.Value;
                List<Lecturas> filtro = lecturasDAL.Filtrar(nivel);
                cargaGrilla(filtro);
            }

        }
        protected void recargar_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerConsumo.aspx");
        }
    }
}