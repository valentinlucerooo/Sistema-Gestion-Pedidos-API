using BackBLL;
using BackEntity;
using Microsoft.AspNetCore.Mvc;

namespace BackSIstema.Controladores
{

    [Route("api/enviocontrol")]
    [ApiController]
        public class EnvioController : ControllerBase
        {
        private readonly EnvioBLL bll;

        public EnvioController(EnvioBLL _bll)
        {
            bll = _bll;
        }

        [HttpGet]
            public IActionResult ObtenerTodos()
            {
                try
                {
                    return Ok(bll.GetAllEnvios());
                }
                catch (Exception ex)
                {
                    return BadRequest(new { mensaje = ex.Message });
                }
            }

            [HttpPost]
            public IActionResult Crear([FromBody] EnvioEntity envio)
            {
                try
                {
                    bll.ValidarEnvio(envio);
                    return Ok(new { mensaje = "Zona de envío creada con éxito." });
                }
                catch (Exception ex)
                {
                    return BadRequest(new { mensaje = ex.Message });
                }
            }

            [HttpPut("{id}")]
            public IActionResult Actualizar(int id, [FromBody] EnvioEntity envio)
            {
                try
                {
                    envio.IDEnvio = id;
                    bll.validarModificacionEnvio(envio);
                    return Ok(new { mensaje = "Zona de envío actualizada con éxito." });
                }
                catch (Exception ex)
                {
                    return BadRequest(new { mensaje = ex.Message });
                }
            }

            [HttpDelete("{id}")]
            public IActionResult Eliminar(int id)
            {
                try
                {
                    bll.BorrarEnvio(id);
                    return Ok(new { mensaje = "Zona de envío eliminada con éxito." });
                }
                catch (Exception ex)
                {
                    return BadRequest(new { mensaje = ex.Message });
                }
            }
        }
   
}

