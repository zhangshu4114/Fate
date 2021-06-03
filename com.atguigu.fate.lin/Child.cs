using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.atguigu.fate.lin {

    public class Child {
        

        public event Action Cry;

        public void OnCry(string msg) {
            if(!msg.Equals("哭")){
                return;
            }
            if(Cry!=null){
                Cry();
            }
        }
    }
}
