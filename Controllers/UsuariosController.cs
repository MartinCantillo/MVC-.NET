using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;
using Models;

namespace HolaMundo.Controllers;


public class UsuariosController : Controller
{

    public IActionResult Index()
    {
        //ViewData para enviar los datos a las vistas
        ViewData["Usuarios"] = new List<Usuario>(){
        new Usuario( 123, "Martin","Cantillo","Ingeniero de Software"),
         new Usuario( 124, "Daniel","Torres","Ingeniero de Soporte"),
  new Usuario( 125, "Juan","Orozco","Frontend developer")

   };
        return View();
    }

    private Usuario Usuario()
    {
        throw new NotImplementedException();
    }
}