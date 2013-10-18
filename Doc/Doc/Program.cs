using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Doc.Validate;

namespace Doc
{
    class Program
    {
        class MyData
        {
            internal string Item1 { get; set; }
            internal string Item2 { get; set; }
            internal string Item3 { get; set; }
        }

        static DocumentProcessor Configure()
        {
            DocumentProcessor rc = new DocumentProcessor();
            rc.Processes.Add(new TranslateIntoJapaneseProcess());
            rc.Processes.Add(new SpellcheckProcess());
            rc.Processes.Add(new RepaginateProcess());
            return rc;
        }

        static Validator CreateValidator(MyData data)
        {
            Validator validator = new Validator();
            validator.ValidationList.Add(new Item1(data.Item1));
            validator.ValidationList.Add(new Item2(data.Item2));
            validator.ValidationList.Add(new Item3(data.Item3));
            return validator;
        }

        static void Main(string[] args)
        {
            //データ作成
            List<MyData> data = new List<MyData>();
            MyData rec1 = new MyData() { Item1 = "12345", Item2 = "1234567890", Item3 = "12345678901234567890" };
            MyData rec2 = new MyData() { Item1 = "00001", Item2 = "12345678901", Item3 = "app" };
            MyData rec3 = new MyData() { Item1 = null, Item2 = "zx", Item3 = "123" };
            data.Add(rec1);
            data.Add(rec2);
            data.Add(rec3);

            int i = 0;
            foreach (MyData rec in data)
            {
                Console.WriteLine("[" + ++i + "レコード目]");
                Validator validator = CreateValidator(rec);
                try 
                {
                    validator.Validate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("エラーが発生しました。：" + ex.Message);
                }                
            }           

            Console.ReadKey();
        }
    }
}
