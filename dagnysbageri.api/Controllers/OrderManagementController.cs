using Microsoft.AspNetCore.Mvc;

namespace dagnysbageri.api.Controllers;

[ApiController]
[Route("ordermanagement")]

// Role: Admin
public class OrderManagementController : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult OrderDetails() => Ok();
    // hämtar orderdetaljer för en order, exvis ingredienser, mängder

    [HttpGet("all")]
    public ActionResult ListAllOrders() => Ok();
    // lista alla ordrar

    [HttpGet("planned")]
    public ActionResult ListPlannedOrders() => Ok();
    // lista alla ordrar med status "planned"

    [HttpGet("ongoing")]
    public ActionResult ListOngoingOrders() => Ok();
    // lista alla ordrar med status "ongoing"

    [HttpGet("past")]
    public ActionResult ListPastOrders() => Ok();
    // lista alla ordrar med status "past"

    [HttpPut("{id}")]
    public ActionResult UpdateOrder() => Ok();
    // uppdaterar order, exvis status
}