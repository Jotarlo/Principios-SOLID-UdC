using AccesoDatos.Modelo;
using ContratosAccesoDatos.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Mapeadores
{
    public class MapeadorRepositorioPersona : MapeadorBaseRepositorio<Person, PersonDbModel>
    {
        public override PersonDbModel MapearT1T2(Person entrada)
        {
            return new PersonDbModel()
            {
                Id = entrada.Id,
                TipoDocumento = entrada.DocumentTypeId,
                Documento = entrada.Document,
                Nombre = entrada.Name,
                Correo = entrada.EmailAddress,
                Telefono = entrada.PhoneNumber,
                Mensaje = entrada.MessageText
            };
        }

        public override IEnumerable<PersonDbModel> MapearT1T2(IEnumerable<Person> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT1T2(item);
            }
        }

        public override Person MapearT2T1(PersonDbModel entrada)
        {
            return new Person()
            {
                Id = entrada.Id,
                DocumentTypeId = entrada.TipoDocumento,
                Document = entrada.Documento,
                Name = entrada.Nombre,
                EmailAddress = entrada.Correo,
                PhoneNumber = entrada.Telefono,
                MessageText = entrada.Mensaje
            };
        }

        public override IEnumerable<Person> MapearT2T1(IEnumerable<PersonDbModel> entrada)
        {
            foreach (var item in entrada)
            {
                yield return MapearT2T1(item);
            }
        }
    }
}
