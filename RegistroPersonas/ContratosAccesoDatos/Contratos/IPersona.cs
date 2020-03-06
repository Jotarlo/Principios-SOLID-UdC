using ContratosAccesoDatos.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosAccesoDatos.Contratos
{
    public interface IPersona
    {
        IEnumerable<PersonDbModel> ObtenerListadoPersonas();

        bool GuardarPersona(PersonDbModel persona);
    }
}
