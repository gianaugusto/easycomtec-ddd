using Domain.BancoDeTalentos.Models;

namespace Domain.BancoDeTalentos.Interfaces
{
    public interface ITalentoRepository
    {
        Talento GetByEmail(string name);
        Talento Save(Talento model);
    }
}
