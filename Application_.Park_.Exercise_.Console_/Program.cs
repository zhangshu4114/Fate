using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_.Park_.Exercise_.Test_;
using System.Reflection;
namespace Application_.Park_.Exercise_.Console_ {

    delegate int Add(int n1,int n2);

    public class Program {
        /*GenericMethod method = new GenericMethod();
            DateTime date = method.ConvertType<DateTime>("2020-1-1");
            Console.WriteLine(date);*/
        /*Student student = new Student();
        Type type = student.GetType();*/
        /*FieldInfo[] fields = type.GetFields();*/
        /*FieldInfo[] fields = type.GetFields();
        Console.WriteLine(fields.Length);
        foreach (FieldInfo field in fields) {
            Console.WriteLine(field.Name);
        }*/
        
        public static void Main(string[] args) {
            /*Program.SortUseWhile();*/
            
        }

        public static void Sort() {

            int[] list = {25,43,98,12,55,22,4,87,33,41,39,11,69,101,77 };
            int length = list.Length;
            int t1 = 0;
            for (int i = 0; i <= length-2; i++) {
                for (int j = i+1; j <= length-1; j++) {

                    if (list[i]>list[j]) {
                        t1 = list[i];
                        list[i] = list[j];
                        list[j] = t1;
                    }
                }
                
            }
            Console.WriteLine(String.Join(",",list));
        }
        public static void SortUseWhile() {

            int[] list = { 25, 43, 98, 12, 55, 22, 4, 87, 33, 41, 39, 11, 69, 101, 77 };
            int length = list.Length;
            int t1 = 0;
            int i = 0;
            int j = 0;
            while (i <= length-2) {
                j = i + 1;
                while (j <= length-1) {
                    if (list[i] > list[j]) {
                        t1 = list[i];
                        list[i] = list[j];
                        list[j] = t1;
                    }
                    j++;
                }
                i++;
            }
            Console.WriteLine(String.Join(",", list));
        }
        public int AddNum(int n1, int n2) {
            return n1 + n2;
        }
        public int Add(int n1, int n2) {
            return n1 + n2;
        }
        public void Test() {
            Add add = new Add(AddNum);
            int r = add.Invoke(25,52);
            int x = add(1, 1);
            Add plus = AddNum;
            int y = Add(123,456);
        }
        /*Action<int> Reduce = (m) => {
            int x = m;
        };
        Func<string,int> f = (name) => {
            Console.WriteLine(name);
            return 25;
        }*/
    }
    
}
