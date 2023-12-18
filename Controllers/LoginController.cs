using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTrack.Data;
using BTrack.Models;

namespace BTrack.Controllers
{
    public class LoginController : Controller
    {
        private readonly BTrackContext _context;

        public LoginController(BTrackContext context)
        {
            _context = context;
        }

        // GET: Login
        public async Task<IActionResult> Index()
        {
            return _context.Login != null ?
                        View(await _context.Login.ToListAsync()) :
                        Problem("Entity set 'BTrackContext.Login'  is null.");
        }

    }

}
