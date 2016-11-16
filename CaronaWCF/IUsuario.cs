using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF
{
    [ServiceContract]
    interface IUsuario
    {
        [OperationContract]
        string CadastreUsuario(string nome, string cpf, DateTime dtNascimento, string emailInstitucional, string emailSecundario, string telefone, string senha);

        [OperationContract]
        string CadastreUsuario();

        [OperationContract]
        string ExcluaUsuario(string codigo);

        [OperationContract]
        string GetUsuario(string chave);

        [OperationContract]
        string GetUsuarios();
    }
}
