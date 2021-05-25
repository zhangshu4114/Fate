using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.atguigu.fate.lin {
    public partial class TestForm : Form {
        public TestForm() {
            InitializeComponent();
        }
        public void Lin_Click(object sender, EventArgs e) {
            List<Student> list_ = this.students();
            List<StudentClass> classes = this.studentclasses();
            /*var list0 = from s in list select s;*/
            /*var list0 = from s in list 
                        select new {
                            id = s.id,
                            name = s.name,
                            age = s.age,
                            classid = s.classid
                        };*/
            /*var list0 = from s in list
                        where s.age > 19
                        select new {
                            id = s.id,
                            name = s.name,
                            age = s.age,
                            classid = s.classid
                        };*/
            /*var list = list_.Select(s => new {
                id = s.id,
                name = s.name,
                age = s.age,
                classid = s.classid
            });*/
            /*var list = list_.Where(s => {
                return s.age > 20;
            });*/
            /*var list = from s in list_
                       where s.age > 15
                       orderby s.age
                        select s;*/
            /*var list = list_.OrderByDescending(s => {
                return s.age;
            });*/
            /*var list = list_.OrderBy(s => {
                return s.age;
            });*/
            var list = from s in list_
                       join c in classes on s.classid equals c.id
                       into sclist
                       from sc in sclist
                       select sc;
            foreach (var item in list) {
                Console.WriteLine($"id={item.id}, name={item.name}");
            }
            /*foreach (Student item in list) {
                Console.WriteLine($"id={item.id}, name={item.name}, age={item.age}, classid={item.classid}");
            }*/
            int i = 0;
        }

        /**
         * 
         */
        public List<Student> students() {
            List<Student> list = new List<Student>();
            list.Add(new Student() { id = 1, name = "韩菱纱", age = 18, classid = 4 });
            list.Add(new Student() { id = 2, name = "柳梦璃", age = 19, classid = 5 });
            list.Add(new Student() { id = 3, name = "慕容紫英", age = 17, classid = 1 });
            list.Add(new Student() { id = 4, name = "云天河", age = 20, classid = 2 });
            list.Add(new Student() { id = 5, name = "羲和", age = 21, classid = 3 });
            list.Add(new Student() { id = 6, name = "望舒", age = 233, classid = 6 });
            return list;
        }
        /**
         * 获取班级信息
         */
        public List<StudentClass> studentclasses() {
            List<StudentClass> list = new List<StudentClass>();
            list.Add(new StudentClass() { id = 1, name = "一班" });
            list.Add(new StudentClass() { id = 2, name = "二班" });
            list.Add(new StudentClass() { id = 3, name = "三班" });
            return list;
        }
    }
}
