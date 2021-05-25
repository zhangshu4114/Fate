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
    public partial class CalculateForm : Form {
        

        public CalculateForm() {
            InitializeComponent();
        }
        
        private void inputClick(object sender, EventArgs e) {
            MessageBox.Show(sender+"");
            Button button = sender as Button;
            if (button.Name.Contains("Input")) {
                MessageBox.Show(button.Text);
            }
            DateTime dateTime = DateTime.Now;
        }
    }
}
