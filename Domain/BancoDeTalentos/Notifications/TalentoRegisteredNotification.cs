using MediatR;
using Domain.Talento.Models;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Talento.Notifications
{
    public class TalentoRegisteredNotification : INotificationHandler<Talento>
    {
        public void Handle(TalentoRegisteredNotification notification)
        {
            
        }

        public Task Handle(Talento notification, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
