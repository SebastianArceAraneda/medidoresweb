using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DTO
{
    public class Medidores
    {
        private string numeroMedidor;
        private string tipo;

        public string NumeroMedidor { get => numeroMedidor; set => numeroMedidor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
