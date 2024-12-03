using MediatR;
using MediatrSample.Mediatr.Queries;
using MediatrSample.Models;

namespace MediatrSample.Mediatr.Handlers;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly FakeDataStore _fakeDataStore;

    public GetProductsHandler(FakeDataStore fakeDataStore)
    {
        _fakeDataStore = fakeDataStore;
    }

    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
        CancellationToken cancellationToken) => await _fakeDataStore.GetAllProducts();
}


//query’yi işlemesi için Handlers klasörü içerisinde GetProductsHandler sınıfımızı tanımlayalım
/*IRequestHandler<GetProductsQuery, IEnumerable<Product>> ‘den türettiğimiz GetProductsHandler isimli bir sınıf oluşturduk.
 *Yani bu sınıf GetProductsQuery isteğini işleyecek ve geriye product listesi dönecek demektir.
GetProductsHandler sınıfı içerisinde yalnızca FakeDataStore içerisindeki product'ları getirenHandle methodunu implement ediyoruz.*/