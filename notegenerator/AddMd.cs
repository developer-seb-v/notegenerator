using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notegenerator
{
    public partial class AddMd : Form
    {
        public AddMd()
        {
            InitializeComponent();
        }

        private void addMdBtn_Click(object sender, EventArgs e)
        {

            DataAcess.AddOrderingMd(mdTxtBox.Text);
        }
    }
}
