using BackBLL;
using BackEntity;
using BackDAL;
using Microsoft.AspNetCore.Mvc;

namespace BackSIstema.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoBLL BLL;

        // Inyectamos la BLL por constructor igual que en PedidoControl
        public ProductoController(ProductoBLL bll)
        {
            BLL = bll;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            try
            {
                return Ok(BLL.GetAllProductos());
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Crear([FromBody] ProductoEntity producto)
        {
            try
            {
                // Asumimos que tu BLL tiene un método para insertar, ej: CrearProducto o Insertar
                BLL.ValidarProducto(producto); // O el nombre que uses en tu BLL para dar de alta
                return Ok(new { mensaje = "Producto creado con éxito." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] ProductoEntity producto)
        {
            try
            {
                producto.IDProducto = id;
                BLL.ModificarProducto(producto);
                return Ok(new { mensaje = "Producto actualizado con éxito." });
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
                BLL.BorrarProducto(id);
                return Ok(new { mensaje = "Producto eliminado con éxito." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }
    }
}