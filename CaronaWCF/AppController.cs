using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaWCF
{
    class AppController
    {
        public void CadastreUsuario(string json)
        {
            dynamic usuario = JsonConvert.DeserializeObject<Usuario>(json);

            var servico = new UsuarioService();

            servico.CadastreUsuario(usuario);
        }
    }
}
