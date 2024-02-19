using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Абстрактный класс TXTHandler наследуемый от класса AbstractHandler
    /// </summary>
    class TXTHandler : AbstractHandler
    {

        /// <summary>
        /// методы открытия
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Open document format - TXT");
        }

        /// <summary>
        /// методы  создания
        /// </summary>
        public override void Create()
        {
            Console.WriteLine("Creat document format - TXT");
        }

        /// <summary>
        /// методы редактирования
        /// </summary>
        public override void Change()
        {
            Console.WriteLine("Change document format - TXT");
        }


        /// <summary>
        ///  методы сохранения
        /// </summary>
        public override void Save()
        {
            Console.WriteLine("Save document format - TXT");
        }



















    }
}
