using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls; //Нужно подключить пространство имен

namespace Kursach_2._0
{
    //класс Manager. Доступ к страницам запрещен,
    //поэтому для этого можно создать класс
    internal class Manager
    {
        public static Frame MainFrame { get; set; }
    }
}
