using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF
{
    class VeiculoMap : ClassMap<Veiculo>
    {
        public VeiculoMap()
        {
            Map(x => x.ID);
            Map(x => x.IDUsuario);
            Map(x => x.Placa);
            Map(x => x.Marca);
            Map(x => x.Modelo);

            Table("VEICULO");
        }
    }
}
