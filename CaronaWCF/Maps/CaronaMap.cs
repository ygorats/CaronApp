using FluentNHibernate.Mapping;
using System;

namespace CaronaWCF
{
    public class CaronaMap : ClassMap<Carona>
    {
        public CaronaMap()
        {
            Id(x => x.ID, "ID").GeneratedBy.Assigned();
            Map(x => x.Descricao, "descricao");
            Map(x => x.IDUsuario).Default(string.Empty);
            
            Table("CARONA");

        }
    }
}