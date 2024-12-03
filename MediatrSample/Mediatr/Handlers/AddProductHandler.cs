using MediatR;
using MediatrSample.Mediatr.Commands;
using MediatrSample.Models;

namespace MediatrSample.Mediatr.Handlers;

public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
{
    private readonly FakeDataStore _fakeDataStore;

    public AddProductHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        await _fakeDataStore.AddProduct(request.Product);

        return request.Product;
    }
}

/*IRequestHandler<AddProductCommand> interface’inden türeyenHandler class’ı oluşturuyoruz. 
 * Daha önce GetValuesQuery için yaptığımız düzenlemeye benzer.
 * Kısaca şunu diyoruz; bu class AddProductCommand request’i ni işler ve geriye void döner.
Daha sonra FakeDataStore 'a veri ekleyen Handle(AddProductCommand request,
CancellationToken cancellationToken) methodunu implemente ettik.*/

/*Amaç: AddProductCommand isteğini işlemek ve bir ürün eklemek.
Handle metodu:
Ürün FakeDataStore veri kaynağına eklenir.
Eklenen ürün geri döndürülür.*/