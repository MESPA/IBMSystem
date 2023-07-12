using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CatalogoProductos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoProductos.Controllers
{
    public class ProductosController : Controller
    {
        private readonly AppDbContext _context;

        public ProductosController(AppDbContext context)
        {
            _context = context;
        }

        // Acción para listar productos
        public IActionResult Index()
        {
            var productos = _context.Productos.Include(p => p.Imagenes).ToList();
            return View(productos);
        }

        // Acción para mostrar detalles de un producto
        public IActionResult Detalles(int id)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // Acción para crear un nuevo producto (GET)
        public IActionResult Crear()
        {
            return View();
        }

        // Acción para crear un nuevo producto (POST)
        [HttpPost]
        public IActionResult Crear(Producto producto, List<IFormFile> imagenes)
        {
            var productos = _context.Productos.OrderByDescending(x => x.Id).FirstOrDefault();

            var insertarproductos = new Producto();
            


            if (ModelState.IsValid)
            {
                if (imagenes != null && imagenes.Count > 0)
                {
                    foreach (var imagen in imagenes)
                    {
                        if (imagen.Length > 0)
                        {
                            var imagenProducto = new ImagenProducto
                            {
                                RutaImagen = Guid.NewGuid().ToString() + "_" + imagen.FileName,
                            };
                            producto.Imagenes.Add(imagenProducto);

                            // Guardar la imagen en el sistema de archivos
                            var rutaArchivo = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagenes", imagenProducto.RutaImagen);
                            using (var fileStream = new FileStream(rutaArchivo, FileMode.Create))
                            {
                                imagen.CopyTo(fileStream);
                            }
                        }
                    }
                }

                insertarproductos.Nombre = producto.Nombre;
                insertarproductos.Descripcion = producto.Descripcion;
                insertarproductos.Precio = producto.Precio;
                insertarproductos.Stock = producto.Stock;
                insertarproductos.Imagenes = producto.Imagenes;
                _context.Productos.Add(insertarproductos);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // Acción para editar un producto (GET)
        public IActionResult Editar(int id)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // Acción para editar un producto (POST)
        [HttpPost]
        public IActionResult Editar(int id, Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Entry(producto).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // Acción para eliminar un producto (GET)
        public IActionResult Eliminar(int id)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // Acción para eliminar un producto (POST)
        [HttpPost]
        public IActionResult EliminarConfirmado(int id)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            _context.Productos.Remove(producto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}