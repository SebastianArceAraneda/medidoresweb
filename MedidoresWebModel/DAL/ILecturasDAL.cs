using MedidoresWebModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public interface ILecturasDAL
    {
        List<Lecturas> Obtener();
        void Agregar(Lecturas lecturas);
        void Eliminar(string numeroMedidor);

        List<Lecturas> Filtrar(string numeroMedidor);
    }
}
