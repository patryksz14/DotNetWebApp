using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Forum.Models;

namespace Forum.Controllers
{
    public class PostsController : Controller
    {
        private readonly ForumDatabaseContext _context;

        public PostsController(ForumDatabaseContext context)
        {
            _context = context;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("Id,Content,PostId,CreatorId,CreationDate,LastEditionDate")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                var id = new byte[20];
                HttpContext.Session.TryGetValue("id", out id);
                string str = System.Text.Encoding.UTF8.GetString(id);
                int userId = int.Parse(str);
                comment.CreatorId = userId;
                comment.CreationDate = DateTime.Now; ;
                comment.LastEditionDate = DateTime.Now;
                comment.PostId = comment.Id;
                comment.Id = 0;
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            comment.CreationDate = DateTime.Now;
            comment.LastEditionDate = DateTime.Now;
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick", comment.CreatorId);
            ViewData["PostId"] = new SelectList(_context.Post, "Id", "Title", comment.PostId);
            return RedirectToAction("Details",comment.PostId);
        }
        // GET: Posts
        public async Task<IActionResult> Index()
        {
            var forumDatabaseContext = _context.Post.Include(p => p.Category).Include(p => p.Creator).OrderBy(p=>p.Category);
            return View(await forumDatabaseContext.ToListAsync());
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .Include(p => p.Category)
                .Include(p => p.Creator)
                .Include("Comment.Creator")
                .Include("Comment.Point")
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name");
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,CreatorId,CategoryId,CreationDate,LastEditionDate")] Post post)
        {
            
            if (ModelState.IsValid)
            {
                var id = new byte[20];
                HttpContext.Session.TryGetValue("id", out id);
                string str = System.Text.Encoding.UTF8.GetString(id);
                int userId = int.Parse(str);
                post.CreatorId = userId;
                post.LastEditionDate = DateTime.Now;
                post.CreationDate = DateTime.Now;
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            

            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", post.CategoryId);
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick", post.CreatorId);
            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", post.CategoryId);
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick", post.CreatorId);
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,CreatorId,CategoryId,LastEditionDate")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    post.LastEditionDate = DateTime.Now;
                    Post p = new Post();
                    p = post;
                    post = await _context.Post
                .Include(p => p.Category)
                .Include(p => p.Creator)
                .FirstOrDefaultAsync(m => m.Id == id);
                    post.Content = p.Content;
                    post.Title = p.Title;
                    post.LastEditionDate = p.LastEditionDate;
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", post.CategoryId);
            ViewData["CreatorId"] = new SelectList(_context.User, "Id", "Nick", post.CreatorId);
            return View(post);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .Include(p => p.Category)
                .Include(p => p.Creator)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Post.FindAsync(id);
            _context.Post.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return _context.Post.Any(e => e.Id == id);
        }
    }
}
