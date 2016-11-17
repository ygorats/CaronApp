using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace CaronaWCF
{
    class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Id(x => x.Codigo);
            Map(x => x.ID);
            Map(x => x.Cpf);
            Map(x => x.Nome);
            Map(x => x.DtNascimento);
            Map(x => x.EmailInstitucional);
            Map(x => x.EmailSecundario);
            Map(x => x.Telefone);
            Map(x => x.PossuiVeiculo);
            Map(x => x.Ativo);

            Table("USUARIO");
        }
    }
}
