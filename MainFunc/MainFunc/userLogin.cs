using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFunc
{
    //public string UserName = textbox1.Text;
    public partial class userLogin : UserControl
    {
        public userLogin()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain.Instance.Content.Controls.Add(new userMain());
                frmMain.Instance.Content.Controls[0].SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
