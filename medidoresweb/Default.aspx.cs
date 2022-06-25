using MedidoresWebModel.DAL;
using MedidoresWebModel.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace medidoresweb
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new medidoresDALObjetos();
        private ILecturasDAL lecturaDAL = new lecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Medidores> medidores = medidoresDAL.ObtenerMedidor();
                List<Medidores> nuevosmedidores = medidoresDAL.Obtener(); ;

                if (nuevosmedidores.Count == 0)
                {

                    nuevosmedidores.AddRange(medidores);
                }

                this.medidores.DataSource = nuevosmedidores;
                this.medidores.DataTextField = "numeroMedidor";
                this.medidores.DataValueField = "numeroMedidor";
                this.medidores.DataBind();
            }





        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string medidores = this.medidores.SelectedItem.Text;
                DateTime fecha = Calendar.SelectedDate;
                string hora = this.horaTxt.Text.Trim();
                string minutos = this.minutoTxt.Text.Trim();
                int consumo = Convert.ToInt32(this.consumoTxt.Text);
                if ((consumo >= 0 && consumo <= 600))
                {
                    string tipo = this.medidores.SelectedValue;
                    List<Medidores> medidor = medidoresDAL.Obtener();
                    Medidores filtrarmedidor = medidor.Find(b => b.NumeroMedidor == this.medidores.SelectedItem.Value);
                    CultureInfo Culture = new CultureInfo("es-ES");
                    try
                    {
                        DateTime fechaActual = Convert.ToDateTime(fecha.Day + "/" + fecha.Month + "/" + fecha.Year + " " + hora + ":" + minutos);
                        Lecturas lectura = new Lecturas()
                        {
                            NumeroMedidor = medidores,
                            Tipo = filtrarmedidor.Tipo,
                            Fecha = fechaActual,
                            Consumo = consumo
                        };
                        lecturaDAL.Agregar(lectura);
                        this.mensaje.Text = ("Se ha agregado correctamente");
                        Response.Redirect("VerConsumo.aspx");

                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script language=javascript>alert('Error, Fecha Incorrecta');</script>");
                    }


                }


            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('Error, Cantidad Incorrecta');</script>");
            }
        }
    }
}