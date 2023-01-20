using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Speak_Dicionario.Classes
{
    class Dicionario
    {
        private Dictionary<string, string> _termo;

        public Dictionary<string, string> Termos
        {
            get { return _termo; }
            set 
            {
                foreach (var item in value)
                {
                    _termo.Add(item.Key, item.Value);
                }
            }
        }

        public Dicionario()
        {
            _termo = new Dictionary<string, string>();
        }
    }
}
