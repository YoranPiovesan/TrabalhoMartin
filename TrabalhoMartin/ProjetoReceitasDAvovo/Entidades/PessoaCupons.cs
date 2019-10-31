using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent_Cupons
{
    public class PessoaCupons
    {
        public double _Desconto5 { get; set; }
        public double _Desconto10 { get; set; }
        public double _Desconto20 { get; set; }
        public double _Desconto30 { get; set; }
        public double _Desconto50 { get; set; }

        PessoaCupons()
        {
            this._Desconto5 = 5;
            this._Desconto10 = 10;
            this._Desconto20 = 20;
            this._Desconto30 = 30;
            this._Desconto50 = 50;

        }
    }
}
