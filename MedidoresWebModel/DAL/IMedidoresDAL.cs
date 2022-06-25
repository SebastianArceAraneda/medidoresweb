using MedidoresWebModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidores> ObtenerMedidor();
        void Agregar(Medidores medidor);
        List<Medidores> Obtener();
        List<Medidores> Filtrar(string numeroMedidor);
    }
}
