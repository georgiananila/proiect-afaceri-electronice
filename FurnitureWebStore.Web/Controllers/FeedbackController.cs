using FurnitureWebStore.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureWebStore.Web.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackServices service;

        public FeedbackController(IFeedbackServices service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("Feedback/{id}")]
        public IActionResult Index(int id)
        {
            var feedback = service.GetFeedback(id);
            return View(feedback);
        }
    }
}
