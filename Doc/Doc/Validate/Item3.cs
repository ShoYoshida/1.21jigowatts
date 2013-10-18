using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doc.Validate
{
    /// <summary>
    /// ３項目目
    /// Null許容
    /// 桁数20
    /// </summary>
    class Item3 : IValidation
    {
        private readonly string _s;

        public Item3(string s) 
        {
            this._s = s;
        }

        public void Validate()
        {
            Console.WriteLine("ITEM3:");           
            if (!ValidationTools.DigitsCheck(_s, 20))
            {
                throw new Exception("桁数エラー");
            };
            
        }
    }
}
