﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tarefa_ASPNET_MVC.Models;
using Tarefa_ASPNET_MVC.Repository;
using Tarefa_ASPNET_MVC.Repository.Context;

namespace Tarefa_ASPNET_MVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalRepository animalRepository;

        public AnimalController()
        {
            animalRepository= new AnimalRepository();

        }

        // GET: Animal
        public async Task<IActionResult> Index()
        {
            var listarAnimais = animalRepository.Listar();
              return View(listarAnimais);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new Animal());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Models.Animal animal)
        {
            if (ModelState.IsValid)
            {
                animalRepository.Inserir(animal);
                @TempData["message"] = "Animal cadastrado com sucesso";
                return RedirectToAction("Index", "Animal");
            }
            else
            {
                return View(animal);
            }
        }


    }
}
