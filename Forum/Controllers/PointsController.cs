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
    public class PointsController : Controller
    {
        private readonly ForumDatabaseContext _context;

        public PointsController(ForumDatabaseContext context)
        {
            _context = context;
        }

        // GET: Points
        public async Task<IActionResult> Index()
        {
            var forumDatabaseContext = _context.Point.Include(p => p.Comment).Include(p => p.User);
            return View(await forumDatabaseContext.ToListAsync());
        }

        // GET: Points/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var point = await _context.Point
                .Include(p => p.Comment)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (point == null)
            {
                return NotFound();
            }

            return View(point);
        }

        // GET: Points/Create
        public IActionResult Create()
        {
            ViewData["CommentId"] = new SelectList(_context.Comment, "Id", "Title");
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Nick");
            return View();
        }

        // POST: Points/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,CommentId,DateOfAddition")] Point point)
        {
            if (ModelState.IsValid)
            {
                point.DateOfAddition = DateTime.Now;
                _context.Add(point);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           
            ViewData["CommentId"] = new SelectList(_context.Comment, "Id", "Title", point.CommentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Nick", point.UserId);
            return View(point);
        }

        // GET: Points/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var point = await _context.Point.FindAsync(id);
            if (point == null)
            {
                return NotFound();
            }
            ViewData["CommentId"] = new SelectList(_context.Comment, "Id", "Title", point.CommentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Nick", point.UserId);
            return View(point);
        }

        // POST: Points/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,CommentId,DateOfAddition")] Point point)
        {
            if (id != point.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(point);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PointExists(point.Id))
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

            ViewData["CommentId"] = new SelectList(_context.Comment, "Id", "Title", point.CommentId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Nick", point.UserId);
            return View(point);
        }

        // GET: Points/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var point = await _context.Point
                .Include(p => p.Comment)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (point == null)
            {
                return NotFound();
            }

            return View(point);
        }

        // POST: Points/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var point = await _context.Point.FindAsync(id);
            _context.Point.Remove(point);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PointExists(int id)
        {
            return _context.Point.Any(e => e.Id == id);
        }
        [HttpPost,ActionName("AddPoint")]
        public async Task<string> AddPoint(string commentid)
        {
            var uid = new byte[20];
            HttpContext.Session.TryGetValue("id", out uid);
            string str = System.Text.Encoding.UTF8.GetString(uid);
            int userId = int.Parse(str);
            int id = int.Parse(commentid);
            Comment comment = _context.Comment.Single(p=>p.Id==id);
            Point point = new Point();
            point.CommentId = comment.Id;
            point.UserId = userId;
            point.DateOfAddition = DateTime.Now;
            _context.Point.Add(point);
            await _context.SaveChangesAsync();
            return "fs";
        }
        [HttpPost, ActionName("DeletePoint")]
        public async Task<string> DeletePointPoint(string commentid)
        {
            var uid = new byte[20];
            HttpContext.Session.TryGetValue("id", out uid);
            string str = System.Text.Encoding.UTF8.GetString(uid);
            int userId = int.Parse(str);
            int id = int.Parse(commentid);
            Comment comment = _context.Comment.Single(p => p.Id == id);
            Point point = _context.Point.SingleOrDefault(p => p.CommentId == id && p.UserId == userId);
            if(point!=null)
            {
                _context.Point.Remove(point);
            }
            await _context.SaveChangesAsync();
            return "fs";
        }
    }
}
