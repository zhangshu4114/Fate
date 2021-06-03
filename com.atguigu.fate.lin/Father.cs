using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace com.atguigu.fate.lin {
    public class Father {
        public void WakeUp() {
            Thread.Sleep(2000);
            Console.WriteLine("好的,+1!");
        }
    }
}
