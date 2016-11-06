using Microsoft.SqlServer.Types;
using System;
using System.Runtime.Serialization;
using System.Spatial;

namespace CaronaWCF
{
    [DataContract]
    public class Carona
    {
        [DataMember]
        public virtual Guid ID { get; set; }

        [DataMember]
        public virtual string Descricao { get; set; }

        [DataMember]
        public virtual string OrigemLatitude { get; set; }

        [DataMember]
        public virtual string OrigemLongitude { get; set; }

        [DataMember]
        public virtual string DestinoLatitude { get; set; }

        [DataMember]
        public virtual string DestinoLongitude { get; set; }
    }
}
