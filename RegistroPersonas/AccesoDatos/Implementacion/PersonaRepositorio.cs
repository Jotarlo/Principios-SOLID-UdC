using AccesoDatos.Mapeadores;
using AccesoDatos.Modelo;
using ContratosAccesoDatos.Contratos;
using ContratosAccesoDatos.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class PersonaRepositorio : IPersona
    {
        public bool GuardarPersona(PersonDbModel persona)
        {
            try
            {
                Person personaDB = new MapeadorRepositorioPersona().MapearT2T1(persona);
                using(Charla_DBEntities db = new Charla_DBEntities())
                {
                    db.Person.Add(personaDB);
                    db.SaveChanges();
                    return true;
                }
            }
            catch {
                return false;
            }
        }

        public IEnumerable<PersonDbModel> ObtenerListadoPersonas()
        {
            using (Charla_DBEntities db = new Charla_DBEntities())
            {
                IList<Person> listadoPeronasBD = db.Person.ToList();
                var lista = new MapeadorRepositorioPersona().MapearT1T2(listadoPeronasBD).ToList();
                return lista;
            }
        }
    }
}
