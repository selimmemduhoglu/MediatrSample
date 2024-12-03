using MediatR;

namespace MediatrSample.Models;

public record ProductAddedNotification(Product Product) : INotification;
