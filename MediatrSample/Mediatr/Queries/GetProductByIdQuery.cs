using MediatR;
using MediatrSample.Models;

namespace MediatrSample.Mediatr.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product>;
