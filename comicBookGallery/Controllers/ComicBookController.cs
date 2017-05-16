using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using comicBookGallery.Data;
using comicBookGallery.Models;

namespace comicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            
           return View(comicBook);       
        }
    }
}