using SoftwMicroCrudsTest.AcessRepositorio;
using SoftwMicroCrudsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwMicroCrudsTest.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        private AlbumRepositorio albumRepositorio;

        public AlbumController()
        {
            albumRepositorio = new AlbumRepositorio();
        }
        public ActionResult Index()
        {

            var lista = albumRepositorio.ListarTodos();
            return View(lista);
        }

        // GET: Album/Details/5
        public ActionResult Details(int id)
        {
           
            return View();
        }

        // GET: Album/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: Album/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Album newAlbum)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //albuns.Add(newAlbum);
                    TempData["CreateSucesso"] = true;
                    return RedirectToAction("Index");
                }
                else{ 

                    return View(newAlbum);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Album/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Album/Edit/5
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

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
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
