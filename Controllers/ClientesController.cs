using System.Linq;
using CatalogoProductos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



public class ClientesController : Controller
{
    private readonly AppDbContext _context;

    public ClientesController(AppDbContext context)
    {
        _context = context;
    }

    // Acción para listar los clientes
    public IActionResult Index()
    {
        var clientes = _context.Clientes.ToList();
        return View(clientes);
    }

    // Acción para mostrar detalles de un cliente
    public IActionResult Detalles(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null)
        {
            return NotFound();
        }
        return View(cliente);
    }

    // Acción para crear un nuevo cliente (GET)
    public IActionResult Crear()
    {
        return View();
    }

    // Acción para crear un nuevo cliente (POST)
    [HttpPost]
    public IActionResult Crear(Cliente cliente)
    {
        if (ModelState.IsValid)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(cliente);
    }

    // Acción para editar un cliente (GET)
    public IActionResult Editar(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null)
        {
            return NotFound();
        }
        return View(cliente);
    }

    // Acción para editar un cliente (POST)
    [HttpPost]
    public IActionResult Editar(int id, Cliente cliente)
    {
        if (id != cliente.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(cliente);
    }

    // Acción para eliminar un cliente (GET)
    public IActionResult Eliminar(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null)
        {
            return NotFound();
        }
        return View(cliente);
    }

    // Acción para eliminar un cliente (POST)
    [HttpPost]
    public IActionResult EliminarConfirmado(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null)
        {
            return NotFound();
        }
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
