﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shire_project.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shire_project.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ILogger<RecipesController> _logger;
        private readonly BrewingContext _context;

        public RecipesController(ILogger<RecipesController> logger, BrewingContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Recipes recipe = new Recipes();
            recipe.Name = "Belgian Tripel";
            recipe.ID = 1;

            return View(recipe);
        }

        [HttpPost]
        public ActionResult ServeRecipe(Recipes recipe)
        {
            using (_context)
            {
                _context.Recipe.Add(recipe);
                _context.SaveChanges();
            }

            _logger.LogInformation($"Posting to ServeRecipe, recipe is {recipe}");
            return View("Index", recipe);
        }
    }
}
