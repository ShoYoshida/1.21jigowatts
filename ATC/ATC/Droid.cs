using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATC
{
    class Droid
    {
        private readonly string _model;
        public Droid(string model)
        {
            _model = model;
        }

        public string Model 
        {
            get
            {
                return _model;
            }
            
        }

        public void hack()
        {
            //Model = "B1 battle droid";
        }

    }
}
