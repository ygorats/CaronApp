using FluentNHibernate.Mapping;
using System;

namespace CaronaWCF
{
    public class CaronaMap : ClassMap<Carona>
    {
        public CaronaMap()
        {
            Id(x => x.ID, "ID");
            Map(x => x.Descricao, "descricao");
            
            Table("CARONA");

        }
    }
}