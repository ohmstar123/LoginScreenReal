using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreenReal
{
    public partial class SecondScreen : UserControl
    {
        


        public SecondScreen()
        {
            InitializeComponent();

            welcomeLabel.Text = "Welcome back " + Form1.rightUserName;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            UserControl1 us = new UserControl1();
            f.Controls.Add(us);

        }
    }
}
