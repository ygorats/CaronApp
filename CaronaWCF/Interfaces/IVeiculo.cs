using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF
{
    [ServiceContract]
    interface IVeiculo
    {
        [OperationContract]
        string CadastreVeiculo(Guid idUsuario, string placa, string marca, string modelo);

        [OperationContract]
        string ExcluaVeiculo(string placa);

        [OperationContract]
        Veiculo GetVeiculo(string chave);

        [OperationContract]
        Veiculo GetVeiculo(Guid idUsuario);
    }
}
