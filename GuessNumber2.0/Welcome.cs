using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber2._0 {
    public partial class Welcome : Form {
        public Welcome () {
            InitializeComponent();
            Run.init_arrange();
            Run.init_table();
        }

        private void btnQuit_Click (object sender, EventArgs e) {
            this.Close();
        }

        private void pictureBox1_Click (object sender, EventArgs e) {
            MessageBox.Show(cb1.Text);
            if (rb1.Checked == true && rb2.Checked == false && rb3.Checked == false) {
                    PlayerToPC ptp = new PlayerToPC(cb1.SelectedText);
                    ptp.ShowDialog();
            }
            else if(rb1.Checked == false && rb2.Checked == true && rb3.Checked == false) {
                SingleTest ST = new SingleTest(cb1.SelectedText);
                ST.ShowDialog();
            }
            else {
                AllTest AT = new AllTest(cb1.SelectedText);
                AT.ShowDialog();
            }
        }
    }
}
