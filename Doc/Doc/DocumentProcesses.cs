using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doc
{
    public static class DocumentProcesses
    {
        public static void Spellcheck(Document doc)
        {
            Console.WriteLine("文書のスペルチェックを実行しました。");
        }

        public static void Repaginate(Document doc)
        {
            Console.WriteLine("文書のページ番号を振りなおしました。");
        }

        public static void TranslateIntoJapanese(Document doc)
        {
            Console.WriteLine("文書を日本語に翻訳しました。");
        }
    }
}
