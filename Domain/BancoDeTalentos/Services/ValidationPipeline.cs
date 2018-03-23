using MediatR;
using Domain.BancoDeTalentos.Models;
using System.Threading.Tasks;
using Domain.Models;
using System.Threading;

namespace Domain.BancoDeTalentos.Services
{
    public class ValidationPipeline<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : EntityBase where TResponse : Response
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if (!((EntityBase)request).Valid)
            {
                var response = (TResponse)new Response(request.Notifications, true);
                return response;
            }

            var result = await next();
            return result;
        }
    }
}
