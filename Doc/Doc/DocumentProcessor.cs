using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doc
{
    //static class DocumentProcessor
    //{
    //    public static void Process(Document doc)
    //    {
    //        DocumentProcesses.TranslateIntoJapanese(doc);
    //        DocumentProcesses.Spellcheck(doc);
    //        DocumentProcesses.Repaginate(doc);
    //    }
    //}

    class DocumentProcessor 
    {
        private readonly List<DocumentProcess> processes = new List<DocumentProcess>();

        public List<DocumentProcess> Processes
        {
            get
            {
                return processes;
            }
        }
    
        public void Process(Document doc)
        {
            foreach(DocumentProcess process in Processes)
            {
                process.Process(doc);
            }
        }
    }
}
