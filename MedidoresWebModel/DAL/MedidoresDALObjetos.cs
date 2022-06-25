using MedidoresWebModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public class medidoresDALObjetos : IMedidoresDAL
    {
        private static List<Medidores> medidor = new List<Medidores>();

        public List<Medidores> ObtenerMedidor()
        {
            return
              new List<Medidores>
            {
                new Medidores()
                {
                    NumeroMedidor = "1",
                    Tipo = "Medidor de casa"
                },
                new Medidores()
                {
                    NumeroMedidor = "2",
                    Tipo = "Medidor de calle"
                },
                new Medidores()
                {
                   NumeroMedidor = "3",
                    Tipo = "Medidor de casa"
                },
                new Medidores()
                {
                    NumeroMedidor = "4",
                    Tipo = "Medidor de casa"
                },


        };
        }
        public void Agregar(Medidores medidores)
        {
            medidor.Add(medidores);
        }
        public List<Medidores> Obtener()
        {
            return medidor;
        }
        public List<Medidores> Filtrar(string numeroMedidor)
        {

            return medidor.FindAll(c => c.Tipo == numeroMedidor);
        }
    }
}
