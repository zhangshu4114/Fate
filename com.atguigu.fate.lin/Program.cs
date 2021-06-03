using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;

using System.Threading;

namespace com.atguigu.fate.lin {
    delegate int Add(int n1,int n2);
    delegate void Show(string msg);
    public class Program {

        public static void Main(string[] args) {
            Program x = new Program();
            x.ChildCry();
        }
        public void Fate() {
            Child child = new Child();
            child.Cry += new Mother().WakeUp;
            child.Cry += new Father().WakeUp;
            child.OnCry("睡得很香");
            Thread.Sleep(2000);
            Console.WriteLine("睡得很香,没有哭");
            Thread.Sleep(2000);
            child.OnCry("哭");
            Console.WriteLine("宝宝哭了");
            string x1 = "233";
            int x2 = x1.stringtoint();
        }
        /**
         * 1  5
         * 10 12 13 14 15
         * 21 22 26 28 
         * 31 33 37 38
         * 43 45 49
         */
        public void ChildCry(){
            int m = 27;
            int n = 39;
            /**
             * 27+39
             */
            m = m + n;
            /**
             * 27+39-39
             */
            n = m - n;
            /**
             * 27+39-
             */
            m = m - n;
            Console.WriteLine("m="+m+",n="+n);
        }
    }
}
