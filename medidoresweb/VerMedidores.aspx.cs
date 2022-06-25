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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new medidoresDALObjetos();
        private ILecturasDAL lecturasDAL = new lecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();

            }
        }


        private void cargaGrilla()
        {
            List<Medidores> medidores = medidoresDAL.ObtenerMedidor();
            List<Medidores> nuevosmedidores = medidoresDAL.Obtener(); ;

            if (nuevosmedidores.Count == 0)
            {

                nuevosmedidores.AddRange(medidores);
            }
            this.grilla.DataSource = nuevosmedidores;
            this.grilla.DataBind();
        }
        private void cargaGrilla(List<Medidores> filtro)
        {
            List<Medidores> medidores = medidoresDAL.ObtenerMedidor();
            List<Medidores> nuevosmedidores = medidoresDAL.Obtener(); 
            if (nuevosmedidores.Count == 0)
            {

                nuevosmedidores.AddRange(medidores);
            }
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

                string medidor = this.tipoDdl.SelectedItem.Value;
                List<Medidores> filtro = medidoresDAL.Filtrar(medidor);
                cargaGrilla(filtro);



            }

        }
        protected void recargar_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerMedidores.aspx");
        }
    }
}