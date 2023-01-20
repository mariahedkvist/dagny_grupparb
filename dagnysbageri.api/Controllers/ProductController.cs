using Microsoft.AspNetCore.Mvc;

namespace dagnysbageri.api.Controllers;

[ApiController]
[Route("product")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public ActionResult ListProducts() => Ok();

    [HttpGet("{id}")]
    public ActionResult ProductDetails(int id) => Ok();

    // Role: Admin
    [HttpPost]
    public ActionResult AddProduct() => Ok();

    // Role: Admin
    [HttpPut]
    public ActionResult EditProduct() => Ok();

    // Role: Admin
    [HttpDelete]
    public ActionResult DeleteProduct() => Ok();
}