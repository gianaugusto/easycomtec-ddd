using Domain.Models;
using Flunt.Validations;
using MediatR;
using System;

namespace Domain.BancoDeTalentos.Models
{
    public class Talento : EntityBase, IRequest<Response>, INotification, IValidatable
    {
        public Talento(Guid id, string nome, string email, string skype, string telefone, string linkedIn, string cidade, string estado, string portfolio, decimal pretensao, string informacaoBancaria, string linkCrud, string outroConhecimento)
        {
            ID = id;
            Nome = nome;
            Email = email;
            Skype = skype;
            Telefone = telefone;
            LinkedIn = linkedIn;
            Cidade = cidade;
            Estado = estado;
            Portfolio = portfolio;
            Pretensao = pretensao;
            InformacaoBancaria = informacaoBancaria;
            LinkCrud = linkCrud;
            OutroConhecimento = outroConhecimento;

            AddNotifications(new Contract()
                   .IsNotNullOrEmpty(nome, "Nome", "Nome não pode ficar em branco")
                   .IsNotNullOrEmpty(email, "Email", "E-mail não pode ficar em branco")
                   .IsGreaterOrEqualsThan(pretensao, 0, "Pretensao", "Valor deve ser maior que zero.")
               );
        }

        public Guid ID { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Skype { get; private set; }

        public string Telefone { get; private set; }

        public string LinkedIn { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }

        public string Portfolio { get; private set; }

        public decimal Pretensao { get; private set; }

        public string InformacaoBancaria { get; private set; }

        public string LinkCrud { get; private set; }

        public string OutroConhecimento { get; private set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }

        //public List<TalentoConhecimento> lstConhecimento { get; private set; }

        //public List<TalentoHorario> lstHorario { get; private set; }

        //[ForeignKey("TalentoID")]
        //public List<TalentoDisponibilidade> lstDisponibilidade { get; private set; }

        //[NotMapped]
        //public TalentoInformacaoBancaria InformacoesBancarias { get; private set; }
    }
}
