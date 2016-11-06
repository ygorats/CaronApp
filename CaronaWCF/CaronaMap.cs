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
            Map(x => x.OrigemLatitude);
            Map(x => x.OrigemLongitude);
            Map(x => x.DestinoLatitude);
            Map(x => x.DestinoLongitude);
            Table("CaronaAlfa");

        }
    }
}