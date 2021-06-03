using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.atguigu.fate.lin {
    //基类约束  不与能引用类型约束共存
    //约束不能既是引用类型又是值类型约束
    //无参构造函数约束new()  它必须是最后(有其他约束共存的情况)
    public class BaseModel<T> where T:new()
    {
        public void AddModel(T t)
        {
            T t1 = new T();
            //$" " 格式化字符串
            Console.WriteLine($"添加{typeof(T).Name}信息");
            Console.WriteLine("添加{0}信息", typeof(T).Name);
            Console.WriteLine(string.Format("添加{0}信息", typeof(T).Name));
        }

        public void UpdateModel(T t)
        {
            Console.WriteLine($"修改{typeof(T).Name}信息");
        }

        public void DeleteModel(T t)
        {
            Console.WriteLine($"删除{typeof(T).Name}信息");
        }
    }
}
