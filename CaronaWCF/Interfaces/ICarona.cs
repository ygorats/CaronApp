using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CaronaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICarona
    {
        [OperationContract]
        IList<Carona> GetCaronas();

        [OperationContract]
        Carona GetCarona(string ID);

        [OperationContract]
        string CadastreCarona(Guid idUsuario, string descricao, string origem, string destino, DateTime horarioPartida, DateTime horarioChegada);

        [OperationContract]
        string ExcluaCarona(Carona carona);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "CaronaWCF.ContractType".
    [DataContract]
    public class Dados
    {
        //bool boolValue = true;
        //string stringValue = "Hello ";

        [DataMember]
        public IList<Carona> _caronas;

        //[DataMember]
        //public string StringValue
        //{
        //    get { return stringValue; }
        //    set { stringValue = value; }
        //}
    }
}
