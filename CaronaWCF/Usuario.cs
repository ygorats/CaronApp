using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CaronaWCF
{
    [DataContract]
    class Usuario
    {
        [DataMember]
        public virtual Guid ID { get; set; }

        [DataMember]
        public virtual string Codigo { get; set; }

        [DataMember]
        public virtual string Cpf { get; set; }

        [DataMember]
        public virtual string Nome { get; set; }

        [DataMember]
        public virtual DateTime DtNascimento { get; set; }

        [DataMember]
        public virtual string EmailInstitucional { get; set; }

        [DataMember]
        public virtual string EmailSecundario { get; set; }

        [DataMember]
        public virtual string Telefone { get; set; }

        [DataMember]
        public virtual bool PossuiVeiculo { get; set; }

        [DataMember]
        public virtual int Ativo { get; set; }

        [DataMember]
        public virtual string Senha { get; set; }

    }
}
