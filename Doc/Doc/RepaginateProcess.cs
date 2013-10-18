using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doc
{
    class RepaginateProcess : DocumentProcess
    {
        public override void Process(Document doc)
        {
            DocumentProcesses.Repaginate(doc);
        }
    }
}
