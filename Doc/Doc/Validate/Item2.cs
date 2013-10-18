using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doc.Validate
{
    /// <summary>
    /// ２項目目
    /// Not Null
    /// 桁数10
    /// </summary>
    class Item2 : IValidation
    {
        private readonly string _s;

        public Item2(string s) 
        {
            this._s = s;
        }

        public void Validate()
        {
            Console.WriteLine("ITEM2:");
            if (!ValidationTools.NullCheck(_s))
            {
                throw new Exception("Nullエラー");
            };

            if (!ValidationTools.DigitsCheck(_s, 10))
            {
                throw new Exception("桁数エラー");
            };
        }
    }
}
