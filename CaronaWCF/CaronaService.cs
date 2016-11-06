using NHibernate;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CaronaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CaronaService : ICarona
    {
        private readonly ISession _secao;
        
        public CaronaService(ISession secao)
        {
            _secao = secao;
        }

        public CaronaService()
        {
            _secao = null;
        }

        public string CadastreCarona(string descricao, string origem, string destino)
        {
            var origemCoordenadas = origem.Split(',');
            var destinoCoordenadas = origem.Split(',');


            var carona = new Carona(){
                               ID = Guid.NewGuid(),
                               Descricao = descricao,
                               OrigemLatitude = origemCoordenadas[0].Trim(),
                               OrigemLongitude = origemCoordenadas[1].Trim(),
                               DestinoLatitude = destinoCoordenadas[0].Trim(),
                               DestinoLongitude = destinoCoordenadas[1].Trim()
            };

            using (ISession secao = NHibernateHelper.OpenSession())
            {
                using (var tran = secao.BeginTransaction())
                { 
                    secao.Save(carona);
                    tran.Commit();
                    tran.Dispose();
                    return "Success!";
                }
            }
        }

        public string ExcluaCarona(Carona carona)
        {
            using (var tran = _secao.BeginTransaction())
            {
                _secao.Delete(carona);
                tran.Commit();
                return carona.ID.ToString();
            }
        }

        public Carona GetCarona(string ID)
        {
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                using (var tran = secao.BeginTransaction())
                {
                    return secao.Get<Carona>(ID);
                }
            }
        }

        public IList<Carona> GetCaronas()
        {
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                
                var consulta = secao.QueryOver<Carona>().List<Carona>();
                var consulta2 = secao.Query<Carona>().ToList();
                var consultaPorPonto = secao.Query<Carona>();
                return consulta2;                
            }
        }
    }
}
