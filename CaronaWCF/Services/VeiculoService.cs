using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;

namespace CaronaWCF
{
    class VeiculoService : IVeiculo
    {
        public string CadastreVeiculo(Guid idUsuario, string placa, string marca, string modelo)
        {
            var veiculo = new Veiculo()
            {
                ID = Guid.NewGuid(),
                IDUsuario = idUsuario,
                Placa = placa,
                Marca = marca,
                Modelo = modelo
            };
            try
            {
                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        secao.Save(veiculo);
                        tran.Commit();
                        tran.Dispose();
                        return "Veículo cadastrado com sucesso!";
                    }
                }
            }
            catch (Exception)
            {
                //Será a tratativa de veículo com aquela placa já utilizado por outro usuário;
                return "Erro no cadastro.";
            }
        }

        public string ExcluaVeiculo(string placa)
        {
            var veiculoExcluido = new Veiculo()
            {
                Placa = placa
            };

            using (ISession secao = NHibernateHelper.OpenSession())
            {
                using (var tran = secao.BeginTransaction())
                {
                    secao.Delete(veiculoExcluido);
                    tran.Commit();
                    tran.Dispose();
                    return "Veículo excluído com sucesso!";
                }
            }
        }

        public Veiculo GetVeiculo(Guid idUsuario)
        {
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                return secao.Query<Veiculo>().Where(x => x.IDUsuario == idUsuario).FirstOrDefault();
            }
        }

        public Veiculo GetVeiculo(string placa)
        {
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                return secao.Query<Veiculo>().Where(x => x.Placa == placa).FirstOrDefault();
            }
        }
    }
}
