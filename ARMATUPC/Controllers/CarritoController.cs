using Microsoft.AspNetCore.Mvc;

namespace ARMATUPC.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Carrito()
        {
            return View();
        }
    }
}
