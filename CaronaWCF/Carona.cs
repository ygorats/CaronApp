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
        public virtual Guid IDUsuario { get; set; }

        [DataMember]
        public virtual string Descricao { get; set; }

        //[DataMember]
        public virtual SqlGeography Origem { get; set; }

        //[DataMember]
        public virtual SqlGeography Desino { get; set; }

        //[DataMember]
        public virtual SqlGeography PontosIntermediarios { get; set; }

        [DataMember]
        public virtual DateTime HorarioPartida { get; set; }

        [DataMember]
        public virtual DateTime HorarioChegada { get; set; }
    }
}
