using MediatR;
using MediatrSample.Mediatr.Commands;
using MediatrSample.Mediatr.Queries;
using MediatrSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediatrSample.Controller;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IMediator _mediator) : ControllerBase
{

    [HttpGet]
    public async Task<ActionResult> GetProducts()
    {
        IEnumerable<Product> products = await _mediator.Send(new GetProductsQuery());
        return Ok(products);
    }

    [HttpPost]
    public async Task<ActionResult> AddProduct([FromBody] Product product)
    {
        Product productToReturn = await _mediator.Send(new AddProductCommand(product));
        return CreatedAtRoute("GetProductById", new { id = productToReturn.Id }, productToReturn);
    }


    [HttpGet("{id:int}", Name = "GetProductById")]
    public async Task<ActionResult> GetProductById(int id)
    {
        Product product = await _mediator.Send(new GetProductByIdQuery(id));
        return Ok(product);
    }

    //[HttpPost]
    //public async Task<ActionResult> AddProduct([FromBody] Product product)
    //{
    //    Product productToReturn = await _mediator.Send(new AddProductCommand(product));
    //    await _mediator.Publish(new ProductAddedNotification(productToReturn));
    //    return CreatedAtRoute("GetProductById", new { id = productToReturn.Id }, productToReturn);
    //}



}


/*Şimdiye kadar tek request’in tek bir handler tarafından işlendiğini gördük. Ya bir de tek request’in birden fazla handler tarafından işlenmesini isteseydik?
Bu noktada notifications devreye giriyor. Bu gibi durumlarda, belirli event’ler oluştuktan sonra birbirinden bağımsız işlemleri tetiklememiz gerekir.*/