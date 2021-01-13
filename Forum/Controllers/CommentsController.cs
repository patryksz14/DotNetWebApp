using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Forum.Models;
using Microsoft.AspNetCore.Http;

namespace Forum.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ForumDatabaseContext _context;

        public CommentsController(ForumDatabaseContext context)
        {
            _context = context;
        }

        // GET: Comments
        public async Task<IActionResult> Index()
        {
            var forumDatabaseContext = _context.Comment.Include(c => c.Creator).Include(c => c.Post);
            return View(await forumDatabaseContext.ToListAsync());
        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment
                .Include(c => c.Creator)
                .Include(c => c.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Comments/Create
        public IActionResult Create()
        {
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick");
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Title");
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection data,[Bind("Id,Content,PostId,CreatorId,CreationDate,LastEditionDate")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                var id = new byte[20];
                HttpContext.Session.TryGetValue("id", out id);
                string str = System.Text.Encoding.UTF8.GetString(id);
                int userId = int.Parse(str);
                comment.CreationDate=DateTime.Now; ;
                comment.LastEditionDate=DateTime.Now;
                comment.CreatorId = userId;
                comment.PostId = comment.Id;
                comment.Content = data["Content"];
                comment.Id = 0;
                _context.Add(comment);
                System.Diagnostics.Debug.WriteLine(comment.Id+" id");
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            comment.CreationDate = DateTime.Now;
            comment.LastEditionDate = DateTime.Now;
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick", comment.CreatorId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Title", comment.PostId);
            return View(comment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("Id,Content,PostId,CreatorId,CreationDate,LastEditionDate")] Comment comment,string content)
        {
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("content "+content);
                var id = new byte[20];
                HttpContext.Session.TryGetValue("id", out id);
                string str = System.Text.Encoding.UTF8.GetString(id);
                int userId = int.Parse(str);
                comment.CreationDate = DateTime.Now; ;
                comment.LastEditionDate = DateTime.Now;
                comment.CreatorId = userId;
                comment.PostId = comment.Id;
                comment.Content = content;
                comment.Id = 0;
                _context.Add(comment);                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            comment.CreationDate = DateTime.Now;
            comment.LastEditionDate = DateTime.Now;
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick", comment.CreatorId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Title", comment.PostId);
            return View(comment);
        }

        // GET: Comments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           
            var comment = await _context.Comment.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick", comment.CreatorId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Title", comment.PostId);
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,PostId,CreatorId,CreationDate,LastEditionDate")] Comment comment)
        {
            if (id != comment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    comment.LastEditionDate = DateTime.Now;
                    Comment c = new Comment();
                    c = comment;
                    comment = await _context.Comment
                .Include(c => c.Creator)
                .Include(c => c.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
                    comment.LastEditionDate = c.LastEditionDate;
                    comment.Content = c.Content;
                    System.Diagnostics.Debug.WriteLine(comment.LastEditionDate.ToString() + " " + comment.CreationDate.ToString() + " " + c.LastEditionDate.ToString() + " " + c.CreationDate.ToString());
                    _context.Update(comment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Posts/Details/"+comment.PostId);
            }
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick", comment.CreatorId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Title", comment.PostId);
            return View(comment);
        }

        // GET: Comments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment
                .Include(c => c.Creator)
                .Include(c => c.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _context.Comment.FindAsync(id);
            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(int id)
        {
            return _context.Comment.Any(e => e.Id == id);
        }
    }
}
