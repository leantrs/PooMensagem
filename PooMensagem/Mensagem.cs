using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem
{
   public class Mensagem
    {
        /*
       private String TextoMensagem;

        public void ExibirMensagem() {
            Console.WriteLine(this.TextoMensagem);
        }

        public String GetTextoMensagemm() {
            return this.TextoMensagem;        
        }

        public void setTextoMensagem(String msg1)
        {
            this.TextoMensagem = msg1;
        }
        */

        private String textoMensagem;

        public String TextoMensagem
        {
            get  { return this.textoMensagem; }

            set  { this.textoMensagem = value; }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }



    }
}
