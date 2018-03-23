using Domain.BancoDeTalentos.Interfaces;
using Domain.BancoDeTalentos.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace Infra.Data.BancoDeTalentos
{
    public class TalentoRepository : Repository<Talento,Guid>, ITalentoRepository
    {

        public TalentoRepository(DbContext context): base(context) { 

        }

        public Talento GetByEmail(string name)
        {
            throw new NotImplementedException();
        }

        public Talento Save(Talento model)
        {
            throw new NotImplementedException();
        }
    }
    
}
