using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATC
{
    class Plane
    {
        private readonly string _Identifier;
        public Plane(string newIdentifier) 
        {
            _Identifier = newIdentifier;
        }

        public string Identifier 
        {
            get
            {
                return _Identifier;
            }
            //private set; 
        }


        public void test()
        {
            //_Identifier = "change!";
            System.Diagnostics.Debug.WriteLine("フィールド：" + this._Identifier);
            System.Diagnostics.Debug.WriteLine("プロパティ：" + this.Identifier);
        }
    }
}
