using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFunc
{
    public partial class frmMain : MaterialForm
    {
        private static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmMain();
                    return _instance;
                }
                else
                {
                    return null;
                }
            }
        }
        public frmMain()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey700, Primary.Grey800, Accent.LightBlue200, TextShade.WHITE);

        }
        public Panel Content
        {
            get { return panel1; }
            set { panel1 = value; }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _instance = this;
            panel1.Controls.Add(new userLogin());
        }

        
    }
}
