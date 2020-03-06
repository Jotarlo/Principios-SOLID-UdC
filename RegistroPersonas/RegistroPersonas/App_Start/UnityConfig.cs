using AccesoDatos.Implementacion;
using ContratosAccesoDatos.Contratos;
using ContratosControladorApp.Contratos;
using ControladorApp.Implementacion;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace RegistroPersonas
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPersona, PersonaRepositorio>();
            container.RegisterType<IPersonaApp, ControladorPersona>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}