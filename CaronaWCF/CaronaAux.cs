using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF
{
    class CaronaAux
    {
        [DataMember]
        public virtual Guid IDCARONA { get; set; }

        [DataMember]
        public virtual String ORIGEMLATITUDE { get; set; }
                                              
        [DataMember]                      
        public virtual String ORIGEMLONGITUDE  { get; set; }

        [DataMember]
        public virtual String DESTINOLATITUDE  { get; set; }

        [DataMember]
        public virtual String DESTINOLONGITUDE { get; set; }
    }
}
