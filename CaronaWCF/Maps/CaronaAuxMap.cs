using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF
{
    class CaronaAuxMap : ClassMap<CaronaAux>
    {
        public CaronaAuxMap()
        {
            Id(x => x.IDCARONA).GeneratedBy.Assigned();
            Map(x => x.ORIGEMLATITUDE);
            Map(x => x.ORIGEMLONGITUDE);
            Map(x => x.DESTINOLATITUDE);
            Map(x => x.DESTINOLONGITUDE);

            Table("CARONAAUX");
        }
    }
}
