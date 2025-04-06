using DevExpert.Marketplace.Business.Interfaces.Notifications;
using DevExpert.Marketplace.Business.Interfaces.Repositories;
using DevExpert.Marketplace.Business.Models;

namespace DevExpert.Marketplace.Business.Services;

public class SellerService(ISellerRepository repository, INotifier notifier)
    : Service<Seller>(repository, notifier)
{
    public override Task DeleteAsync(Guid id)
    {
        notifier.AddNotification(new("O vendedor não pode ser deletado."));
        return Task.CompletedTask;
    }
}