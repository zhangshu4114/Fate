using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_.Park_.Exercise_.Test_ {
    public partial class ListBoxForm : Form {
        public ListBoxForm() {
            InitializeComponent();
        }
        /**
         *
        这是老师今晚课程的资料总链接哦
链接：https://pan.baidu.com/s/1ptLTgPAMoMQqSPdLcX27KA 
提取码：yqso


        【一线大厂Redis高并发架构与源码深度剖析】课程回放总链接+文档+脑图: 
        总链接：https://pan.baidu.com/s/1ptLTgPAMoMQqSPdLcX27KA 
提取码：yqso
         */
        private void ListBoxForm_Load(object sender, EventArgs e) {
            ListBox1.Items.Add("十香");
            ListBox1.Items.Add("士道");
            ListBox1.Items.Add("折纸");
            ListBox1.Items.Add("铃音");

        }
    }
}
