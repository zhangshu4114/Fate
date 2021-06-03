using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.atguigu.fate.lin {
    public class User {
        public int age = 0;
        public int deptId = 1;
        private int _age = 0;

        public int Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }

        private int DeptId { get; set; }
        public User() { }
        public User(int id) {

            this.Id = id;
        }

        public int GetAge() {
            return this.Age;
        }

        public string GetUserInfo(string str) {
            string reStr = $"用户：{UserName},年龄：{Age},部门编号：{DeptId}";
            return reStr;
        }
    }
}
