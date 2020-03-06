
using ContratosAccesoDatos.DbModel;
using ContratosControladorApp.DTO;
using RegistroPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp.Mapeadores
{
    public class MapeadorUIPersona : MapeadorBaseControlador<PersonaDTO, PersonaModel>
    {
        public override PersonaModel MapearT1T2(PersonaDTO entrada)
        {
            return new PersonaModel()
            {
                Id = entrada.Id,
                TipoDocumento = entrada.TipoDocumento,
                Documento = entrada.Documento,
                Nombre = entrada.Nombre,
                Correo = entrada.Correo,
                Telefono = entrada.Telefono,
                Mensaje = entrada.Mensaje
            };
        }

        public override IEnumerable<PersonaModel> MapearT1T2(IEnumerable<PersonaDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override PersonaDTO MapearT2T1(PersonaModel entrada)
        {
            return new PersonaDTO()
            {
                Id = entrada.Id,
                TipoDocumento = entrada.TipoDocumento,
                Documento = entrada.Documento,
                Nombre = entrada.Nombre,
                Correo = entrada.Correo,
                Telefono = entrada.Telefono,
                Mensaje = entrada.Mensaje
            };
        }

        public override IEnumerable<PersonaDTO> MapearT2T1(IEnumerable<PersonaModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
