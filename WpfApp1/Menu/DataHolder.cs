using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Crud
{
    public class DataHolder
    {
        private static DataHolder _instance;

        // Ваше нестатическое поле или свойство для передачи данных
        public int SomeValue { get; set; }

        private DataHolder()
        {
            // Приватный конструктор
        }

        public static DataHolder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataHolder();
                }
                return _instance;
            }
        }
    }


}
