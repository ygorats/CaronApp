using CaronaWCF.Interfaces;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF.Services
{
    class CaronaAuxService : ICaronaAux
    {
        public string CadastrePontos(Guid idCarona, string origLatitude, string origLongitude, string destLatitude, string destLongitude)
        {
            try
            {
                var pontosCarona = new CaronaAux()
                {
                    IDCARONA = idCarona,
                    ORIGEMLATITUDE = origLatitude,
                    ORIGEMLONGITUDE = origLongitude,
                    DESTINOLATITUDE = destLatitude,
                    DESTINOLONGITUDE = destLongitude
                };
                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        secao.Save(pontosCarona);
                        tran.Commit();
                        tran.Dispose();
                        return "Pontos da carona gravados com sucesso";
                    }
                }
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}
