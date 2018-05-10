﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext ctx) => context = ctx;
        public IActionResult Index() => View();
        public IActionResult Respond() => View();
        [HttpPost] public IActionResult Respond(GuestResponse response) { context.Responses.Add(response); context.SaveChanges(); return RedirectToAction(nameof(Thanks), new { Name = response.Name, WillAttend = response.WillAttend }); }
        public IActionResult Thanks(GuestResponse response) => View(response);
        public IActionResult ListResponses() => View(context.Responses.Where(r => r.WillAttend == true).OrderBy(r=>r.Email));
    }
}