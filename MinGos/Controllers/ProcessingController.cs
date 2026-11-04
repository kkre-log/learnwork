using Microsoft.AspNetCore.Mvc;
using MinGos.BusinessLayer;
using MinGos.Handlers;
using MinGos.Services;

namespace MinGos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessingController : ControllerBase
    {
        [HttpPost("main")]
        public ActionResult Main([FromBody] RequestBody request)
        {
            var type = HandlerRegistry.Find(request.WindowCode, request.ActionType, request.ActionCode);
            if (type == null) return NotFound("Не найден обработчик");
            var handler = (ApiHandlerBase)Activator.CreateInstance(type)!;
            return Ok(handler.Handle());
        }
    }
}