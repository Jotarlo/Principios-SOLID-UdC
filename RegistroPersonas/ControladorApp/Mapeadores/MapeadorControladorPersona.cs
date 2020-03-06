
using ContratosAccesoDatos.DbModel;
using ContratosControladorApp.DTO;
using System.Collections.Generic;

namespace ControladorApp.Mapeadores
{
    public class MapeadorControladorPersona : MapeadorBaseControlador<PersonDbModel, PersonaDTO>
    {
        public override PersonaDTO MapearT1T2(PersonDbModel entrada)
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

        public override IEnumerable<PersonaDTO> MapearT1T2(IEnumerable<PersonDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override PersonDbModel MapearT2T1(PersonaDTO entrada)
        {
            return new PersonDbModel()
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

        public override IEnumerable<PersonDbModel> MapearT2T1(IEnumerable<PersonaDTO> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
