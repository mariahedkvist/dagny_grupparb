using Microsoft.AspNetCore.Mvc;

namespace dagnysbageri.api.Controllers;
[ApiController]
[Route("order")]

// Role: User
public class OrderController : ControllerBase
{
    [HttpGet]
    public ActionResult ListUserOrders() => Ok();

    [HttpGet("{id}")]
    public ActionResult OrderDetails() => Ok();

    [HttpPost]
    public ActionResult CreateOrder() => Ok();

    [HttpPut]
    public ActionResult UpdateOrder() => Ok();

    [HttpDelete]
    public ActionResult DeleteOrder() => Ok();
}