using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmInternetCafe : Form
    {
        public FrmInternetCafe()
        {
            InitializeComponent();
        }
        private void btGoRentRoom_Click(object sender, EventArgs e)
        {
            FrmRentRoom frmRentRoom = new FrmRentRoom();
            frmRentRoom.Show();
            Hide();
        }
    }
}
