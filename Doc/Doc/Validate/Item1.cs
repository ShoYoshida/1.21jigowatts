using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doc.Validate
{
    /// <summary>
    /// １項目
    /// 必須
    /// 数値
    /// </summary>
    class Item1 : IValidation
    {
        private readonly string _s;

        public Item1(string s) 
        {
            this._s = s;
        }

        public void Validate()
        {
            Console.WriteLine("ITEM1:");
            if (!ValidationTools.NullCheck(_s)) { 
                throw new Exception("Nullエラー");
            };
            if (!ValidationTools.RequiredCheck(_s)) {
                throw new Exception("必須エラー");
            };
            if (!ValidationTools.DigitsCheck(_s, 5)) { 
                throw new Exception("桁数エラー");
            };
            if (!ValidationTools.NumberCheck(_s)) { 
                throw new Exception("数値エラー");
            };
        }
    }
}
