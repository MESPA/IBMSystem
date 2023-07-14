using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CatalogoProductos.Models;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace CatalogoProductos.Controllers
{
   
   

    public class OrdenesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

       

        public OrdenesController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // Acción para listar las órdenes de pedidos
        public IActionResult Index()
        {
            var ordenes = _context.Ordenes.Include(o => o.Cliente).Include(p => p.Productos).ToList();

            return View(ordenes);
        }


        // Acción para mostrar detalles de una orden de pedido
        public IActionResult Detalles(int id)
        {
            var orden = _context.Ordenes.Include(o => o.Cliente).FirstOrDefault(o => o.Id == id);
            if (orden == null)
            {
                return NotFound();
            }
            return View(orden);
        }

   
        public IActionResult Crear()
        {
            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            return View();
        }

      
        [HttpPost]
        public IActionResult Crear(Orden orden, int[] productosSeleccionados,string estado)
        {



            if (ModelState.IsValid)
            {

               
                var productos = _context.Productos.Where(p => productosSeleccionados.Contains(p.Id)).ToList();

                foreach (var producto in productos)
                {
                    if (producto.Stock <= 0)
                    {
                      
                        return RedirectToAction("Error");
                    }

                    producto.Stock--; 
                }

                orden.Productos = productos;
                orden.Estatus = estado;

              
                //orden.Productos = _context.Productos.Where(p => productosSeleccionados.Contains(p.Id)).ToList();

                var ultimaorden = _context.Ordenes.OrderByDescending(x => x.Id).FirstOrDefault();

                


                var traking = new Tracking();
                foreach (var item in productos)
                {
                    traking.Descripcion = item.Descripcion;
                }
                traking.Estatus = estado;

                if (ultimaorden == null)
                {
                    traking.OrdenId =  1;
                }
                else
                {
                    traking.OrdenId = ultimaorden.Id + 1;
                }
            

                _context.Trackings.Add(traking);
                _context.Ordenes.Add(orden);
                _context.SaveChanges();


                var response = new { success = true };

            return Json(response);
            }
            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            return View(orden);
        }

        public void guardarTrackin()
        {
        }

        // Acción para editar una orden de pedido (GET)
        public IActionResult Editar(int id)
        {
            var orden = _context.Ordenes.Include(o => o.Cliente).Include(o => o.Productos).FirstOrDefault(o => o.Id == id);
            if (orden == null)
            {
                return NotFound();
            }
            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            return View(orden);
        }

        // Acción para editar una orden de pedido (POST)
        [HttpPost]
        public IActionResult Editar(int id, Orden orden, int[] productosSeleccionados)
        {
            if (id != orden.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                orden.Productos = _context.Productos.Where(p => productosSeleccionados.Contains(p.Id)).ToList();

                _context.Entry(orden).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            return View(orden);
        }

        public IActionResult ReporteOrdenes()
        {
            // Obtener los datos de las órdenes desde la base de datos
            var ordenes = _context.Ordenes.Include(o => o.Cliente).Include(o => o.Productos).ToList();

            // Crear un documento PDF
            var ms = new MemoryStream();
            var writer = new PdfWriter(ms);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            // Agregar el título del reporte
            var titulo = new Paragraph("Reporte de Órdenes");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            document.Add(titulo);

            // Agregar una imagen
            var imagenPath = Path.Combine(_env.WebRootPath, "imagenes", "IBSystem.png");
            var imagen = new Image(ImageDataFactory.Create(imagenPath));
            document.Add(imagen);

            // Crear una tabla para los datos
            var table = new Table(3); // 3 columnas para Fecha, Cliente y Estatus
            table.AddHeaderCell("Fecha");
            table.AddHeaderCell("Cliente");
            table.AddHeaderCell("Estatus");

            // Agregar los datos a la tabla
            foreach (var orden in ordenes)
            {
                table.AddCell(orden.Fecha.ToString());
                table.AddCell(orden.Cliente.Nombre);
                table.AddCell(orden.Estatus);
            }

            // Agregar la tabla al documento
            document.Add(table);

            // Cerrar el documento
            document.Close();

            // Devolver el PDF como archivo descargable
            return File(ms.ToArray(), "application/pdf", "ReporteOrdenes.pdf");
        }




    }
}


