using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkCore1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCore1.Controllers
{
    public class EmpleadosController : Controller
    {
        RepositoryEmpleados repo;
        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetEmpleados());
        }
    }
}