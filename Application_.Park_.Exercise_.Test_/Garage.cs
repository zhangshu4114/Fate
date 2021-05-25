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
    public partial class Garage : Form {
        public Garage() {
            InitializeComponent();
        }

        private void ButtonX_Click(object sender, EventArgs e) {
            MessageBox.Show("回车键");
        }

        private void ButtonY_Click(object sender, EventArgs e) {
            MessageBox.Show("ESC键");
        }

        private void Garage_Load(object sender, EventArgs e) {

        }
    }
}
