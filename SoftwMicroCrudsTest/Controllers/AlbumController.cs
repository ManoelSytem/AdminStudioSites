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
        public ActionResult Index()
        {
           List<Album> albuns = new List<Album>
        {
            new Album(){ Codigo = 1, Nome = "Moda", DataCriacao = DateTime.Now,  },
            new Album(){ Codigo = 2, Nome = "Eventos" , DataCriacao = DateTime.Now},
            new Album(){ Codigo = 2, Nome = "Espetáculos", DataCriacao = DateTime.Now},
            new Album(){ Codigo = 3, Nome = "Gestantes", DataCriacao = DateTime.Now },
            new Album(){ Codigo = 4, Nome = "Parto", DataCriacao = DateTime.Now},
            new Album(){ Codigo = 5, Nome = "Newborn", DataCriacao = DateTime.Now },
            new Album(){ Codigo = 7, Nome = "Eventos", DataCriacao = DateTime.Now },
            new Album(){ Codigo = 7, Nome = "Produtos", DataCriacao = DateTime.Now },
            new Album(){ Codigo = 7, Nome = "Casal", DataCriacao = DateTime.Now },
            };

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
            var ModelAlbum = new Album
            {  
               DataCriacao = DateTime.Now
            };

            return View(ModelAlbum);
        }

        // POST: Album/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
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
