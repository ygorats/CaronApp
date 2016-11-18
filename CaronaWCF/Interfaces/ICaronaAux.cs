using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF.Interfaces
{
    [ServiceContract]
    interface ICaronaAux
    {
        [OperationContract]
        string CadastrePontos(Guid idCarona, string origLatitude, string origLongitude, string destLatitude, string destLongitude);
    }
}
