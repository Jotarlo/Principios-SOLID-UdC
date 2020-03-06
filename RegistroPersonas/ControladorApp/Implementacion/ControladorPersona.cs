using ContratosAccesoDatos.Contratos;
using ContratosAccesoDatos.DbModel;
using ContratosControladorApp.Contratos;
using ContratosControladorApp.DTO;
using ControladorApp.Mapeadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp.Implementacion
{
    public class ControladorPersona : IPersonaApp
    {
        IPersona _repositorio;
        public ControladorPersona(IPersona _personaRep)
        {
            this._repositorio = _personaRep;
        }

        public bool GuardarPersona(PersonaDTO persona)
        {
            MapeadorControladorPersona mapeador = new MapeadorControladorPersona();
            PersonDbModel pDb = mapeador.MapearT2T1(persona);
            bool reg =  this._repositorio.GuardarPersona(pDb);
            if (reg)
            {
                String ran = new Random().Next(1000).ToString();
                new HelperEmail().EnviarCorreo("Registro" + ran, "Registro exitoso", persona.Correo);
            }
            return reg;
        }

        public IEnumerable<PersonaDTO> ObtenerListadoPersonas()
        {
            MapeadorControladorPersona mapeador = new MapeadorControladorPersona();
            var listaDbModel = _repositorio.ObtenerListadoPersonas();
            IEnumerable<PersonaDTO> lista = mapeador.MapearT1T2(listaDbModel);
            return lista;
        }
    }
}
