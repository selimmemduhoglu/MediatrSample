using MediatR;
using MediatrSample.Mediatr.Queries;
using MediatrSample.Models;

namespace MediatrSample.Mediatr.Handlers;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly FakeDataStore _fakeDataStore;

    public GetProductByIdHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return await _fakeDataStore.GetProductById(request.Id);
    }

}

/*Amaç: GetProductByIdQuery sorgusunu işlemek. Handle metodu:Ürün, FakeDataStore üzerinden ID'ye göre alınır.*/

