using MediatR;
using MediatrSample.Models;

namespace MediatrSample.Mediatr.Queries;

public record GetProductsQuery() : IRequest<IEnumerable<Product>>;


/*Amaç: Ürün listesini getirmek için bir sorgu tanımlamak.
İşleyici: GetProductsHandler.*/