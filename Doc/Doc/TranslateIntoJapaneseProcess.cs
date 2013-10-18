using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doc
{
    class TranslateIntoJapaneseProcess : DocumentProcess
    {
        public override void Process(Document doc)
        {
            DocumentProcesses.TranslateIntoJapanese(doc);
        }
    }
}
