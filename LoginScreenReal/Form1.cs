using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreenReal
{
    public partial class Form1 : Form
    {

        static public string rightUserName = "Bob";
        static public string rightPassword = "1234";

        UserControl1 uc = new UserControl1();
        
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(uc);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
