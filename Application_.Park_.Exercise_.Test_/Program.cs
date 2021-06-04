using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_.Park_.Exercise_.Test_ {
    public static class Program {
        /**
         * (0+120)*10/2=600/60
         * 100*180-30*100
         * 100+250+360+450+360
         * 2n=137-99=36 n=18
         * 应用程序的入口
         * 单线程执行
         */
        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClientForm());
        }
        
    }
}
