using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;

namespace CaronaWCF
{
    class UsuarioService : IUsuario
    {

        public string CadastreUsuario(Usuario usuario)
        {
            string criacaoUsuario = "", definicaoSenha = "";
            
            try
            {
                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        secao.Save(usuario);
                        tran.Commit();
                        tran.Dispose();
                        criacaoUsuario = "Usuário criado com sucesso!";
                    }
                }
            }
            catch (Exception e)
            {
                criacaoUsuario = e.Message;
                //Será a tratativa de CPF já utilizado por outro usuário;
            }

            using (ISession secao = NHibernateHelper.OpenSession())
            {
                using (var tran = secao.BeginTransaction())
                {
                    var query = secao.CreateSQLQuery("UPDATE USUARIO SET SENHA = :SENHA WHERE ID = :ID").SetParameter("SENHA", usuario.Senha, NHibernateUtil.String).SetParameter("ID", usuario.ID, NHibernateUtil.Guid);
                    query.ExecuteUpdate();
                    tran.Commit();
                    tran.Dispose();
                    definicaoSenha = "Senha definida com sucesso!";
                }
            }

            return criacaoUsuario + " " + definicaoSenha;
        }

        /*public string CadastreUsuarioDetailed(string nome, string cpf, DateTime dtNascimento, string emailInstitucional, string emailSecundario, string telefone, string senha)
        {
            string criacaoUsuario = "", definicaoSenha = "";
            var novoUsuario = new Usuario()
            {
                ID = new Guid(),
                Cpf = cpf,
                DtNascimento = dtNascimento,
                EmailInstitucional = emailInstitucional,
                EmailSecundario = emailSecundario,
                Telefone = telefone
            };


            try
            {
                using (ISession secao = NHibernateHelper.OpenSession())
                {
                    using (var tran = secao.BeginTransaction())
                    {
                        secao.Save(novoUsuario);
                        tran.Commit();
                        tran.Dispose();
                        criacaoUsuario = "Usuário criado com sucesso!";
                    }
                }
            }
            catch (Exception)
            {
                //Será a tratativa de CPF já utilizado por outro usuário;
            }

            using (ISession secao = NHibernateHelper.OpenSession())
            {
                using (var tran = secao.BeginTransaction())
                {
                    var query = secao.CreateSQLQuery("UPDATE USUARIO SET SENHA = :SENHA WHERE ID = :ID").SetParameter(0, senha).SetParameter(1, novoUsuario.ID);
                    query.ExecuteUpdate();
                    tran.Commit();
                    tran.Dispose();
                    definicaoSenha = "Senha definida com sucesso!";
                }
            }

            return criacaoUsuario + " " + definicaoSenha;
        }*/

        public string ExcluaUsuario(string codigo)
        {
            var usuario = new Usuario()
            {
                Codigo = codigo,
                Ativo = 0
            };
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                using (var tran = secao.BeginTransaction())
                {
                    secao.Update(usuario);
                    tran.Commit();
                    tran.Dispose();
                    return "Usuário inativado com sucesso!";
                }
            }
        }

        public Usuario GetUsuario(string chave)
        {
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                return secao.Query<Usuario>().Where(x => (x.Codigo == chave) || (x.Nome.Contains(chave))).FirstOrDefault();
            }
        }

        public IList<Usuario> GetUsuarios()
        {
            using (ISession secao = NHibernateHelper.OpenSession())
            {
                return secao.Query<Usuario>().ToList();
            }
        }

        
    }
}
