using MediatR;
using Domain.Models;
using Domain.BancoDeTalentos.Interfaces;
using Domain.BancoDeTalentos.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.BancoDeTalentos.Handlers
{
    public class TalentoHandler : IRequestHandler<Talento, Response>
    {
        private readonly IMediator _mediatr;
        private readonly ITalentoRepository _talentoRepository;

        public TalentoHandler(IMediator mediatr, ITalentoRepository talentoRepository)
        {
            _mediatr = mediatr;
            _talentoRepository = talentoRepository;
        }
        
        public Task<Response> Handle(Talento talento, CancellationToken cancellationToken)
        {
            // salva o Talento no repositório.
            _talentoRepository.Save(talento);
            
            return Task.FromResult(new Response(new { message = "Talento inserido com sucessio." }));
        }
    }
}
