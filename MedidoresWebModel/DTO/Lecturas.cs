using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DTO
{
    public class Lecturas
    {
        private string numeroMedidor;
        private string tipo;
        private DateTime fecha;
        private int consumo;

        public string NumeroMedidor { get => numeroMedidor; set => numeroMedidor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Consumo { get => consumo; set => consumo = value; }
    }
}
