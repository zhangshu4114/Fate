using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace com.atguigu.fate.lin {

    public class Mother {

        public void WakeUp(){
            Thread.Sleep(1000);
            Console.WriteLine("妈妈醒来,让爸爸去看看宝宝!");
        }
    }
}
