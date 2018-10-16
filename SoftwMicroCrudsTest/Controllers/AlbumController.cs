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
        List<Album> albuns = new List<Album>();
        
        public ActionResult Index()
        {

            albuns.Add(new Album(1,"Moda",DateTime.Now));
            albuns.Add(new Album(2,"Eventos", DateTime.Now));
            albuns.Add(new Album(3,"Espetáculos", DateTime.Now));
            albuns.Add(new Album(4,"Gestantes", DateTime.Now));
            albuns.Add(new Album(5,"Parto", DateTime.Now));
            albuns.Add(new Album(6,"Newborn", DateTime.Now));
            albuns.Add(new Album(7,"Eventos", DateTime.Now));
            albuns.Add(new Album(8,"Produtos", DateTime.Now));
            albuns.Add(new Album(9,"Casal", DateTime.Now));

            return View(albuns);
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
                    albuns.Add(newAlbum);
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
