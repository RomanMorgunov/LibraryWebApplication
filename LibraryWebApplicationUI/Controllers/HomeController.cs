using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using LibraryWebApplicationUI.Data;
using LibraryWebApplicationUI.Models;

namespace LibraryWebApplicationUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            return View(_context.Books.AsNoTracking().ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult CreateBook()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [RequestSizeLimit(104_857_600)] // 100 MB
        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            var coverImageFile = Request.Form.Files["cover-image"];
            if (coverImageFile == null)
            {
                ModelState.AddModelError("CoverImage", "Поле не должно быть пустым.");
            }

            var bookFile = Request.Form.Files["book-file"];
            if (bookFile == null)
            {
                ModelState.AddModelError("File", "Поле не должно быть пустым.");
            }

            if (!ModelState.IsValid)
            {
                return View("CreateBook");
            }

            book.CoverImage = GetBytes(coverImageFile);
            book.File = GetBytes(bookFile);

            _context.Books.Add(book);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ShowBook(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Book book = _context.Books.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult DeleteBook(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Book book = _context.Books.FirstOrDefault(p => p.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "User")]
        public IActionResult DownloadBook(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Book book = _context.Books.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            string fileName = string.Format("{0}.pdf", book.Name.Replace(',', ' '));
            Response.Headers.Add("Content-Disposition",
                string.Format("attachment; filename={0}", fileName));
            return new FileContentResult(book.File, "application/pdf");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EditBook(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Book book = _context.Books.FirstOrDefault(p => p.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [Authorize(Roles = "Admin")]
        [RequestSizeLimit(104_857_600)] // 100 MB
        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            Book oldBook = _context.Books.AsNoTracking().FirstOrDefault(b => b.Id == book.Id);

            var coverImageFile = Request.Form.Files["cover-image"];
            if (coverImageFile == null)
            {
                book.CoverImage = oldBook.CoverImage;
            }
            else
            {
                book.CoverImage = GetBytes(coverImageFile);
            }

            var bookFile = Request.Form.Files["book-file"];
            if (bookFile == null)
            {
                book.File = oldBook.File;
            }
            else
            {
                book.File = GetBytes(bookFile);
            }

            _context.Books.Update(book);
            _context.SaveChanges();

            return View("ShowBook", book);
        }

        private byte[] GetBytes(IFormFile file)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                file.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
