using MediatR;
using MediatrSample.Models;

namespace MediatrSample.Mediatr.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product>;


/*Amaç: ID'ye göre bir ürünü getirmek için bir sorgu tanımlamak. İşleyici: GetProductByIdHandler.*/
