using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserName_textBox.Tag = UserName_label;
            Password_textBox.Tag = Password_label;
        }

        private void UserName_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
