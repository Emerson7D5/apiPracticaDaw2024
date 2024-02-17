using apiPractica.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly equiposContext _equiposContext;

        public EquiposController(equiposContext equiposContext)
        {
            _equiposContext = equiposContext;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<equipos> listadoEquipos = (from e in _equiposContext.equipos
                                            select e).ToList();
            
            if (listadoEquipos.Count == 0) return NotFound("No se encontraron Equipos");

            return Ok(listadoEquipos);


             
        }




    }
}
