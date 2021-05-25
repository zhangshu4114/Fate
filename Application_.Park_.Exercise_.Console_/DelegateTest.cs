using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_.Park_.Exercise_.Console_ {

    public delegate int Calculate(int m,int n);
    public class DelegateTest {


        public void Test() {
            /**
             * 实例化委托
             */
            Calculate c1 = new Calculate(Add);
            /**
             * 赋值委托
             */
            Calculate c2 = Add;
            /**
             * 匿名函数
             */
            Calculate c3 = delegate (int m, int n) {
                return m;
            };
            /**
             * 简化
             */
            Calculate c4 = (int m, int n) => {
                return m;
            };
            /**
             * 简化-2
             */
            Calculate c5 = (m, n) => {

                return m+n;
            };
            /**
             * 简化-2
             */
            Calculate c6 = (m, n) =>

                m + n;
            Action action = () => {
                Console.WriteLine("*--*");
            };
            Action<string> action1 = (m) => {

                Console.WriteLine($"*--*{m}");
            };
            Func<string> f = () => {
                return "----";
            };

            List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9,12,13,14,15,16};
            List<int> list1 = list.Where(item => { return item > 5; }).ToList();
        }



        [Obsolete]
        public int Add(int m, int n) {
            return m + n;
        }
        public int Reduce(int m, int n) {
            
            return m - n;
        }
        public int Divided(int m, int n) {
            return m / n;
        }
    }
}
