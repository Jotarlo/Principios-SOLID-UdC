using ContratosControladorApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosControladorApp.Contratos
{
    public interface IPersonaApp
    {
        IEnumerable<PersonaDTO> ObtenerListadoPersonas();

        bool GuardarPersona(PersonaDTO persona);
    }
}
