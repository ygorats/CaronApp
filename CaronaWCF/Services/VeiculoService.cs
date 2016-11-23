using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using Newtonsoft.Json;

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
            catch (Exception e)
            {
                //Será a tratativa de veículo com aquela placa já utilizado por outro usuário;
                return "Erro no cadastro. " + e.Message;
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

        public Veiculo GetVeiculoPeloUsuario(Guid idUsuario)
        {
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                return secao.Query<Veiculo>().Where(x => x.IDUsuario == idUsuario).FirstOrDefault();
            }
        }

        public Veiculo GetVeiculoPelaPlaca(string placa)
        {
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                return secao.Query<Veiculo>().Where(x => x.Placa == placa).FirstOrDefault();
            }
        }

        public string CadastreVeiculo(Veiculo veiculo)
        {
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
            catch (Exception e)
            {
                //Será a tratativa de veículo com aquela placa já utilizado por outro usuário;
                return "Erro no cadastro. " + e.Message;
            }
        }

        public string CadastreVeiculoJson(string json)
        {
            try
            {
                dynamic veiculo = JsonConvert.DeserializeObject<Veiculo>(json);
                if (veiculo == null) throw new Exception("Não foi possível obter o Veiculo");
                return CadastreVeiculo(veiculo);
            }
            catch (Exception e)
            {
                return "Erro: " + e.Message;
            }
        }
    }
}
