using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechStore.Models;

namespace TechStore.Controllers
{
    [Route("productos")]
    public class ProductoController : Controller
    {
        // Otras acciones y código aquí...

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Producto> listaProductos = ObtenerProductos();
            return View(listaProductos);
        }

        [HttpPost("agregar")]
        public IActionResult AgregarProducto(Producto producto)
        {
            // Calcula el IGV (18%)
            producto.IGV = producto.Precio * 0.18m;

            // Lógica para guardar el producto en el repositorio (base de datos, servicio, etc.)
            // Aquí puedes implementar la lógica de persistencia en tu repositorio de datos

            return RedirectToAction("Index");
        }

        // Otras acciones y código aquí...

        private List<Producto> ObtenerProductos()
        {
        List<Producto> listaProductos = new List<Producto>
        {
        new Producto { Id = 1, Nombre = "Producto 1", Descripcion = "Descripción del Producto 1", Precio = 100 },
        new Producto { Id = 2, Nombre = "Producto 2", Descripcion = "Descripción del Producto 2", Precio = 200 },
        new Producto { Id = 3, Nombre = "Producto 3", Descripcion = "Descripción del Producto 3", Precio = 150 }
        };

        // Calcular el IGV para cada producto en la lista
        foreach (var producto in listaProductos)
        {
        producto.IGV = producto.Precio * 0.18m;
        }

        return listaProductos;
        }
    }
}
