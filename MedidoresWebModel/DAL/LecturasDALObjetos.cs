using MedidoresWebModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public class lecturasDALObjetos : ILecturasDAL
    {
        private static List<Lecturas> lecturas = new List<Lecturas>();
        public void Agregar(Lecturas lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lecturas> Obtener()
        {
            return lecturas;
        }

        public void Eliminar(string numeroMedidor)
        {
            Lecturas eliminar = lecturas.Find(c => c.NumeroMedidor == numeroMedidor);
            lecturas.Remove(eliminar);
        }

        public List<Lecturas> Filtrar(string numeroMedidor)
        {
            return lecturas.FindAll(c => c.NumeroMedidor == numeroMedidor);
        }
    }
}
