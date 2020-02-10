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
    public partial class UserControl1 : UserControl
    {
        

        string userName;
        string passWord;

        public UserControl1()
        {
            InitializeComponent();

            
            



            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            userName = userInput.Text;
            passWord = passInput.Text;

            if (userName == Form1.rightUserName && passWord == Form1.rightPassword)
            {
                errorLabel.Visible = false;

                Form f = this.FindForm();

                f.Controls.Remove(this);
                SecondScreen ss = new SecondScreen();
                f.Controls.Add(ss);
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}
