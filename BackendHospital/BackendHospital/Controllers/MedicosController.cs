using BackendHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendHospital.Controllers
{
    public class MedicosController : Controller
    {
        // GET: Medicos
        public ActionResult Index()
        {
            List<Medico> medicos;
            
            using (HospitalesRHEntities ctx = new HospitalesRHEntities())
            {
                medicos = ctx.Medico.ToList();
            }

            return View(medicos);
        }

        // GET: Medicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Medicos/Create
        [HttpPost]
        public ActionResult Create(Medico oMedico)
        {
            try
            {
                using (HospitalesRHEntities ctx = new HospitalesRHEntities())
                {
                    ctx.Medico.Add(oMedico);
                    ctx.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(oMedico);
            }
        }

        // GET: Medicos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Medicos/Edit/5
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

        // GET: Medicos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Medicos/Delete/5
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
