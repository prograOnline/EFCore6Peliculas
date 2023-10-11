using EFCorePeliculas.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        public GenerosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Genero>> Get()
        {
            // con AsNoTracking las consultas se ejecutan mas rápidas, pero solo las que son de consulta, eso no aplica para la modificación de datos
            //Se configuró en program para que quedara de manera global
            //return await context.Generos.AsNoTracking().ToListAsync();
            
            return await context.Generos.OrderBy(g => g.Nombre).ToListAsync();
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<Genero>> Get(int id)
        {
            var genero = await context.Generos.FirstOrDefaultAsync(g => g.Identificador == id);

            if (genero is null)
            {
                return NotFound();
            }
            return genero;
        }

        [HttpGet("primer")]
        public async Task<ActionResult<Genero>> Primer()
        {
            var genero =  await context.Generos.FirstOrDefaultAsync(g => g.Nombre.StartsWith("C"));

            if ( genero is null )
            {
                return NotFound();
            }
            return genero;
        }

        [HttpGet("filtrar")]
        public async Task<IEnumerable<Genero>> Filtrar(string nombre)
        {
            return await context.Generos
                .Where(g => g.Nombre.Contains(nombre))
                .ToListAsync();
        }


        [HttpGet("paginacion")]
        public async Task<ActionResult<IEnumerable<Genero>>> GetPaginacion(int pagina = 1)
        {
            var cantidadregistrosPorPagina = 2;

            var generos = await context.Generos
                .Skip( (pagina - 1) * cantidadregistrosPorPagina )
                .Take(cantidadregistrosPorPagina)
                .ToListAsync();
            return generos;
        }


    }
}
