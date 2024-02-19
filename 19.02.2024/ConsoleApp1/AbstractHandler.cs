using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Абстрактный класс
    /// </summary>
    abstract class AbstractHandler
    {

        /// <summary>
        /// открытие
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// создание 
        /// </summary>
        public abstract void Create();

        /// <summary>
        ///  изменение
        /// </summary>
        public abstract void Change();


        /// <summary>
        ///  сохранение
        /// </summary>
        public abstract void Save();












    }
}
