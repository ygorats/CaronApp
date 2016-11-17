using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF
{
    [DataContract]
    class Veiculo
    {
        [DataMember]
        public virtual Guid ID { get; set; }

        [DataMember]
        public virtual Guid IDUsuario { get; set; }

        [DataMember]
        public virtual string Placa { get; set; }

        [DataMember]
        public virtual string Marca { get; set; }

        [DataMember]
        public virtual string Modelo { get; set; }
    }
}
