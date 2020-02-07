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
        public static string rightPassword = "1234";
        string userName;
        string passWord;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            userName = userInput.Text;
            passWord = passInput.Text;

            if (userName == rightUserName && passWord == rightPassword)
            {
                errorLabel.Visible = false;
            }
            else 
            {
                errorLabel.Visible = true;
            }
        }
    }
}
