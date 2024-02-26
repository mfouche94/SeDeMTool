using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPrototype
{
    public partial class Startup : Form
    {
        private bool standardConfig = true;
        public Startup()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonStandardCofig.Checked == true)
            {
                standardConfig = true;
            }
            else
            {
                standardConfig = false;
            }
            Form sedemedsTool = new sedemEdsTool(standardConfig);
            sedemedsTool.Show();
        }
    }
}
