using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Создание объекта для каждого формата документа
            AbstractHandler xmlHandler = new XMLHandler();
            AbstractHandler txtHandler = new TXTHandler();
            AbstractHandler docHandler = new DOCHandler();

            //1 способ

            ////Вызов метода
            //xmlHandler.Open();
            //xmlHandler.Create();
            //xmlHandler.Change();
            //xmlHandler.Save();
            //Console.WriteLine();
            //txtHandler.Open();
            //txtHandler.Create();
            //txtHandler.Change();
            //txtHandler.Save();
            //Console.WriteLine();
            //docHandler.Open();
            //docHandler.Create();
            //docHandler.Change();
            //docHandler.Save();





            //2 способ

            List<AbstractHandler> List = new List<AbstractHandler>();
            bool flag = true;
            while(flag) //если я захочу сделать что б бесконечно раз можно было вводить, то пишу while(true), a bool flag = true; - убираю
            {
                Console.Write("Введите формат: ");
                string format = Console.ReadLine();
                switch(format)
                {
                    case "XML":
                    case "xml":
                    AbstractHandler xml = new XMLHandler();
                        xmlHandler.Open();
                        xmlHandler.Create();
                        xmlHandler.Change();
                        xmlHandler.Save();
                    break;
                      
                    case "TXT":
                    case "txt":
                        AbstractHandler txt = new TXTHandler();
                        txtHandler.Open();
                        txtHandler.Create();
                        txtHandler.Change();
                        txtHandler.Save();
                    break;

                    case "DOC":
                    case "doc":
                        AbstractHandler doc = new TXTHandler();
                        docHandler.Open();
                        docHandler.Create();
                        docHandler.Change();
                        docHandler.Save();
                        break;

                    case "a":
                    case "A":return;

                    default: Console.Write("Такого формата не существует!");flag = false; // это тоже убираю, если захочу сделать бесконечным ввод  flag = false;
                        break;


                }

                Console.ReadKey();

            }

            









        }
    }
}
