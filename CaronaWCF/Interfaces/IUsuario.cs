using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF
{
    [ServiceContract]
    interface IUsuario
    {
        //[OperationContract]
        //string CadastreUsuarioDetailed(string nome, string cpf, DateTime dtNascimento, string emailInstitucional, string emailSecundario, string telefone, string senha);

        [OperationContract]
        [WebInvoke]
        string CadastreUsuario(Usuario usuario);

        [OperationContract]
        [WebInvoke]
        string CadastreUsuarioJson(string json);

        [OperationContract]
        string ExcluaUsuario(string codigo);

        [OperationContract]
        Usuario GetUsuario(string chave);

        [OperationContract]
        IList<Usuario> GetUsuarios();
    }
}
