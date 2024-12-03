using MediatR;
using MediatrSample.Models;

namespace MediatrSample.Mediatr.Queries;

public record GetProductsQuery() : IRequest<IEnumerable<Product>>;

//Buradaki GetProductsQuery isimli record IRequest<IEnumerable<Product>> interface’ini implement ediyor. Bunun anlamı, bu request product listesi geriye dönecek demektir.