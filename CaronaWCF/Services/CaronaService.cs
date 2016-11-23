using NHibernate;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;
using System;
using Newtonsoft.Json;

namespace CaronaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CaronaService : ICarona
    {
        public string CadastreCarona(Guid idUsuario, string descricao, string origem, string destino, string[] intermedios, DateTime horarioPartida, DateTime horarioChegada)
        {
            var origemCoordenadas = origem.Split(',');
            var destinoCoordenadas = destino.Split(',');
            var novoID = Guid.NewGuid();
            var resultado = string.Empty;

            var caronaAux = new CaronaAux()
            {
                IDCARONA = novoID,
                ORIGEMLATITUDE = origemCoordenadas[0].Trim(),
                ORIGEMLONGITUDE = origemCoordenadas[1].Trim(),
                DESTINOLATITUDE = destinoCoordenadas[0].Trim(),
                DESTINOLONGITUDE = destinoCoordenadas[1].Trim()
            };

            var carona = new Carona(){
                               ID = novoID,
                               IDUsuario = idUsuario,
                               Descricao = descricao,
                               HorarioPartida = horarioPartida,
                               HorarioChegada = horarioChegada
            };

            //Criação do SQL de geração do campo geography que armazena os multipontos intermediarios
            var sqlPontosIntermediario = "EXEC GERA_PONTOS_INTERMEDIARIOS @pontos = :PONTOSINTERMEDIARIOS, @IDUSUARIO = :ID";
            string pontosIntermediarios = string.Empty;
            foreach(var ponto in intermedios)
            {
                var coordenadas = ponto.Split(',');
                pontosIntermediarios += coordenadas[1].Trim() + " " + coordenadas[0].Trim() + ",";
            }
            pontosIntermediarios = pontosIntermediarios.Remove(pontosIntermediarios.Length - 1);
            /*sqlPontosIntermediario += pontosIntermediarios;
            sqlPontosIntermediario += ")', 4618)";
            sqlPontosIntermediario += " WHERE ID = " + novoID;*/
            //----------------------------------------------

            try
            {
                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        secao.Save(carona);
                        tran.Commit();
                        tran.Dispose();
                        resultado += " Carona gravada com sucesso! ";
                    }
                }

                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        secao.Save(caronaAux);
                        tran.Commit();
                        tran.Dispose();
                        resultado += " Pontos da carona gravados com sucesso! ";
                    }
                }

                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        var query = secao.CreateSQLQuery("EXEC GERA_PONTOS_INTERMEDIARIOS @pontos = :PONTOSINTERMEDIARIOS, @IDUSUARIO = :ID")
                                            .SetParameter("PONTOSINTERMEDIARIOS", pontosIntermediarios, NHibernateUtil.String)
                                            .SetParameter("ID", novoID, NHibernateUtil.Guid);
                        query.ExecuteUpdate();
                        tran.Commit();
                        tran.Dispose();
                        resultado += " Pontos intermediarios da carona gravados com sucesso! ";
                    }
                }
            }
            catch (Exception e)
            {
                resultado += e.Message;
            }

            return resultado;
        }

        public string CadastreCaronaJson(string json)
        {
            try
            {
                dynamic carona = JsonConvert.DeserializeObject<CaronaTemp>(json);
                if (carona == null) throw new Exception("Não foi possível obter o Veiculo");
                return CadastreCarona(carona);
            }
            catch (Exception e)
            {
                return "Erro: " + e.Message;
            }
        }

        public string CadastreCarona(CaronaTemp caronaTemp)
        {
            var origemCoordenadas = caronaTemp.origem.Split(',');
            var destinoCoordenadas = caronaTemp.destino.Split(',');
            var novoID = Guid.NewGuid();
            var resultado = string.Empty;

            var caronaAux = new CaronaAux()
            {
                IDCARONA = novoID,
                ORIGEMLATITUDE = origemCoordenadas[0].Trim(),
                ORIGEMLONGITUDE = origemCoordenadas[1].Trim(),
                DESTINOLATITUDE = destinoCoordenadas[0].Trim(),
                DESTINOLONGITUDE = destinoCoordenadas[1].Trim()
            };

            var carona = new Carona()
            {
                ID = novoID,
                IDUsuario = caronaTemp.idUsuario,
                Descricao = caronaTemp.descricao,
                HorarioPartida = caronaTemp.horarioPartida,
                HorarioChegada = caronaTemp.horarioChegada
            };

            //Criação do SQL de geração do campo geography que armazena os multipontos intermediarios
            //var sqlPontosIntermediario = "EXEC GERA_PONTOS_INTERMEDIARIOS @pontos = :PONTOSINTERMEDIARIOS, @IDUSUARIO = :ID";
            string pontosIntermediarios = string.Empty;
            foreach (var ponto in caronaTemp.intermedios)
            {
                var coordenadas = ponto.Split(',');
                pontosIntermediarios += coordenadas[1].Trim() + " " + coordenadas[0].Trim() + ",";
            }
            pontosIntermediarios = pontosIntermediarios.Remove(pontosIntermediarios.Length - 1);
            //----------------------------------------------

            try
            {
                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        secao.Save(carona);
                        tran.Commit();
                        tran.Dispose();
                        resultado += " Carona gravada com sucesso! ";
                    }
                }

                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        secao.Save(caronaAux);
                        tran.Commit();
                        tran.Dispose();
                        resultado += " Pontos da carona gravados com sucesso! ";
                    }
                }

                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        var query = secao.CreateSQLQuery("EXEC GERA_PONTOS_INTERMEDIARIOS" +
                                                         "@pontos = :PONTOSINTERMEDIARIOS, @IDCARONA = :ID")
                                            .SetParameter("PONTOSINTERMEDIARIOS", pontosIntermediarios, NHibernateUtil.String)
                                            .SetParameter("ID", novoID, NHibernateUtil.Guid);
                        query.ExecuteUpdate();
                        tran.Commit();
                        tran.Dispose();
                        resultado += " Pontos intermediarios da carona gravados com sucesso! ";
                    }
                }
            }
            catch (Exception e)
            {
                resultado += e.Message;
            }

            return resultado;
        }

        public string ExcluaCarona(Carona carona)
        {
            using (var secao = NHibernateHelper.OpenSession())
            {
                using (var tran = secao.BeginTransaction())
                {
                    secao.Delete(carona);
                    tran.Commit();
                    return carona.ID.ToString();
                }
            }
        }

        public Carona GetCarona(Guid ID)
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

        public IList<Carona> BuscaCaronasJson(string json)
        {
            dynamic caroneiro = JsonConvert.DeserializeObject<CaronaTemp>(json);
            JsonConvert.s

            var origemCoordenadas = ((CaronaTemp)caroneiro).origem.Split(',');
            var destinoCoordenadas = ((CaronaTemp)caroneiro).destino.Split(',');

            var origemSql = origemCoordenadas[1] + " " + origemCoordenadas[0];
            var destinoSql = destinoCoordenadas[1] + " " + destinoCoordenadas[0];

            using (ISession secao = NHibernateHelper.OpenSession())
            {
                var query = secao.CreateSQLQuery("SELECT * FROM CARONA C, USUARIO U, VEICULO V" +
                                                 "WHERE PONTODESTINO.STDistance(geography::STPointFromText('POINT(" + destinoSql + ")', 4618)) <= 2000" +
                                                 "AND PONTOSINTERMEDIARIOS.STDistance(geography::STPointFromText('POINT(" + origemSql + ")', 4618)) <= 2000" +
                                                 "AND C.IDUSUARIO = U.ID" +
                                                 "AND V.IDUSUARIO = U.ID");
                var caronas = query.List<Carona>();
                return caronas;
            }
        }
    }
}
