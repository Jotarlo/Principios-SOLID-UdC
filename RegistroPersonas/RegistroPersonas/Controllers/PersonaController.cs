using ContratosControladorApp.Contratos;
using ContratosControladorApp.DTO;
using ControladorApp.Mapeadores;
using RegistroPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroPersonas.Controllers
{
    public class PersonaController : Controller
    {
        IPersonaApp _controlador;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public PersonaController(IPersonaApp app)
        {
            this._controlador = app;
        }


        // GET: Persona
        public ActionResult Index()
        {
            IEnumerable<PersonaDTO> listaDTO = _controlador.ObtenerListadoPersonas();
            MapeadorUIPersona mapeador = new MapeadorUIPersona();
            IEnumerable<PersonaModel> model = mapeador.MapearT1T2(listaDTO);
            return View(model);
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        public ActionResult Create(PersonaModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MapeadorUIPersona mapeador = new MapeadorUIPersona();
                    PersonaDTO dto = mapeador.MapearT2T1(model);
                    bool guardado = _controlador.GuardarPersona(dto);
                    if (guardado)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(model);
                    }
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
