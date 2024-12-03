using MediatR;
using MediatrSample.Models;

namespace MediatrSample.Mediatr.Commands;

public record AddProductCommand(Product Product) : IRequest<Product>;

//Bu record tek bir Product property’sine sahip ve IRequest interface’inden türemektedir.
//Bu sefer IRequest imzasının bir type parametresi olmadığına dikkat edelim. Çünkü herhangi bir değer döndürmüyoruz.

/*Amaç: Yeni bir ürün eklemek için bir komut tanımlamak.
İşleyici: AddProductHandler.*/