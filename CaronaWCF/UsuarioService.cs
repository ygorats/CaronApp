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
        public string CadastreUsuario()
        {
            return "Not implemented";
        }

        public string CadastreUsuario(string nome, string cpf, DateTime dtNascimento, string emailInstitucional, string emailSecundario, string telefone, string senha)
        {
            string criacaoUsuario, definicaoSenha;
            var novoUsuario = new Usuario()
            {
                ID = new Guid(),
                Cpf = cpf,
                DtNascimento = dtNascimento,
                EmailInstitucional = emailInstitucional,
                EmailSecundario = emailSecundario,
                Telefone = telefone
            };

            using (ISession secao = NHibernateHelper.OpenSession())
            {
                using (var tran = secao.BeginTransaction())
                {
                    secao.Save(novoUsuario);
                    secao.CreateSQLQuery("UPDATE USUARIO SET SENHA = :SENHA WHERE ID = :ID").SetParameter(0, senha).SetParameter(1, novoUsuario.ID);
                    tran.Commit();
                    tran.Dispose();
                    criacaoUsuario = "Usuário criado com sucesso!";
                }
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
        }

        public string ExcluaUsuario(string codigo)
        {
            throw new NotImplementedException();
        }

        public string GetUsuario(string chave)
        {
            throw new NotImplementedException();
        }

        public string GetUsuarios()
        {
            throw new NotImplementedException();
        }

        
    }
}
