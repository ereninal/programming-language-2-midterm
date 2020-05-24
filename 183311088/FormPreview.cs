using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _183311088
{
    public partial class FormPreview : Form
    {
        public FormPreview()
        {
            InitializeComponent();
        }

        private void FormPreview_Load(object sender, EventArgs e)
        {
            HelperMineField.DinamicButton(panelMine);
            
            refresh.Start();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            HelperMineField.MinePreview(panelMine);
        }
    }
}
