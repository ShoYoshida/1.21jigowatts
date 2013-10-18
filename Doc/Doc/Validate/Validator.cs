﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doc.Validate
{
    class Validator
    {
        private readonly List<IValidation> validationList = new List<IValidation>();

        public List<IValidation> ValidationList
        {
            get 
            {
                return validationList;
            }
        }

        public void Validate() 
        {
            foreach (IValidation item in validationList)
            {
                item.Validate();
            }
        
        }
    }
}
