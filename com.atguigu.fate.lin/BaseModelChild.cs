using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.atguigu.fate.lin {
    //泛型类可以直接继承泛型类
    public  class BaseModelChild<T>:BaseModel<T> where T:new()
    {

    }
}
