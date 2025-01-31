 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmRentRoom : Form
    {

        public FrmRentRoom()
        {
            InitializeComponent();
        }
        private void FrmRentRoom_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
        }
        //shareFunc
        private void keyNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // ปฏิเสธการพิมพ์ตัวอื่นที่ไม่ใช่ตัวเลข
            }
        }
 //CheckBox Click=========================================================   
        private void cbPhone_Click(object sender, EventArgs e)
        {
            if (cbPhone.Checked)
            {
                tbPhone.Enabled = true;
            }
            else
            {
                tbPhone.Clear();
                tbPhone.Enabled = false;
            }
        }
        private void cbInternet_Click(object sender, EventArgs e)
        {
            if (cbInternet.Checked)
            {
                tbInternet.Enabled = true;
            }
            else
            {
                tbInternet.Clear();
                tbInternet.Enabled = false;
            }
        }
        private void cbWater_Click(object sender, EventArgs e)
        {
            if (cbWater.Checked)
            {
                tbWater.Enabled = true;
            }
            else
            {
                tbWater.Clear();
                tbWater.Enabled = false;
            }
        }
        private void cbElectric_Click(object sender, EventArgs e)
        {
            if (cbElectric.Checked)
            {
                tbElectric.Enabled = true;
            }
            else
            {
                tbElectric.Clear();
                tbElectric.Enabled = false;
            }
        }

//Keyup======================================================================
        private void tbPhone_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void tbInternet_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void tbWater_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void tbElectric_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
//Keypress============================================================
        private void mtbIDcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberOnly(sender, e);
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberOnly(sender, e);
        }

        private void tbInternet_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberOnly(sender, e);
        }

        private void tbWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberOnly(sender, e);
        }

        private void tbElectric_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberOnly(sender, e);
        }

//bt Function=========================================================
        //btInternetCafe
        private void btGoInternetCafe_Click(object sender, EventArgs e)
        {
            FrmInternetCafe frmInternetCafe = new FrmInternetCafe();
            frmInternetCafe.Show();
            Hide();
        }
        //btCal
        private void btCal_Click(object sender, EventArgs e)
        {
            // Validate every tb data
            if (!mtbIDcard.MaskCompleted)
            {
                ShareData.showWarningMSG("ป้อนเลขประจำตัวประชาชนด้วย");
            }
            else if (string.IsNullOrWhiteSpace(tbFirstname.Text))
            {
                ShareData.showWarningMSG("ป้อนชื่อด้วย");
            }
            else if (string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                ShareData.showWarningMSG("ป้อนนามสกุลด้วย");
            }
            else
            {
                // Create Variable and Calculate 
                string selectedType = cbbType.SelectedItem?.ToString();
                string payDate = dtpPayDate.Value.ToString("วันที่ d MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));
                //Phone Internet Water and Electric Calculate====================================
                if (tbPhone.Text.Length > 0)
                {
                    int minutes = int.Parse(tbPhone.Text);
                    double totalPayPhone = 1.50 * minutes;
                    lbShowPhone.Text = minutes.ToString("0");
                    lbShowPayPhone.Text = totalPayPhone.ToString("#,###,##0.00");
                }
                else
                {
                    lbShowPhone.Text = "0";
                    lbShowPayPhone.Text = ("0.00");
                }
                if (tbInternet.Text.Length > 0)
                {
                    int minutes = int.Parse(tbInternet.Text);
                    double totalPayInternet = 0.5 * minutes;
                    lbShowInternet.Text = minutes.ToString("0");
                    lbShowPayInternet.Text = totalPayInternet.ToString("#,###,##0.00");
                }
                else
                {
                    lbShowInternet.Text = "0";
                    lbShowPayInternet.Text = ("0.00");
                }
                if (tbWater.Text.Length > 0)
                {
                    int units = int.Parse(tbWater.Text);
                    double totalPayWater = 12.5 * units;
                    lbShowWater.Text = units.ToString("0");
                    lbShowPayWater.Text = totalPayWater.ToString("#,###,##0.00");
                }
                else
                {
                    lbShowWater.Text = "0";
                    lbShowPayWater.Text = ("0.00");
                }
                if (tbWater.Text.Length > 0)
                {
                    int units = int.Parse(tbWater.Text);
                    double totalPayWater = 12.5 * units;
                    lbShowWater.Text = units.ToString("0");
                    lbShowPayWater.Text = totalPayWater.ToString("#,###,##0.00");
                }
                else
                {
                    lbShowWater.Text = "0";
                    lbShowPayWater.Text = ("0.00");
                }
                if (tbElectric.Text.Length > 0)
                {
                    int units = int.Parse(tbElectric.Text);
                    double totalPayElectric = 12.5 * units;
                    lbShowElectric.Text = units.ToString("0");
                    lbShowPayElectric.Text = totalPayElectric.ToString("#,###,##0.00");
                }
                else
                {
                    lbShowElectric.Text = "0";
                    lbShowPayElectric.Text = ("0.00");
                }
                //Total Using Bill Display
                double totalPay =
                double.Parse(lbShowPayPhone.Text) +
                double.Parse(lbShowPayInternet.Text) +
                double.Parse(lbShowPayWater.Text) +
                double.Parse(lbShowPayElectric.Text) ;

                // Display results
                lbShowPayDate.Text = payDate;
                lbShowIDcard.Text = mtbIDcard.Text;
                lbShowFullname.Text = $"{tbFirstname.Text} {tbSurname.Text}";
                lbShowType.Text = selectedType;

                lbShowPayTotal.Text = totalPay.ToString("#,###,##0.00");
            }

        }
        //btCancel
        private void btCancel_Click(object sender, EventArgs e)
        {
            mtbIDcard.Clear();
            rdMr.Checked = true;
            tbFirstname.Clear();
            tbSurname.Clear();
            tbPhone.Clear();
            tbInternet.Clear();
            tbWater.Clear();
            tbElectric.Clear();
            tbPhone.Enabled = false;
            tbInternet.Enabled = false;
            tbWater.Enabled = false;
            tbElectric.Enabled = false;
            cbbType.SelectedIndex = 1;
            cbPhone.Checked = false;
            cbInternet.Checked = false;
            cbWater.Checked = false;
            cbElectric.Checked = false;
            lbShowPayDate.Text = "-";
            lbShowIDcard.Text = "-";
            lbShowFullname.Text = "-";
            lbShowType.Text = "-";
            lbShowPhone.Text = "0";
            lbShowInternet.Text = "0";
            lbShowWater.Text = "0";
            lbShowElectric.Text = "0";
            lbShowPayPhone.Text = "0.00";
            lbShowPayInternet.Text = "0.00";
            lbShowPayWater.Text = "0.00";
            lbShowPayElectric.Text = "0.00";
            lbShowPayTotal.Text = "0.00";
        }
        //Masked TextBox 
        private void mtbIDcard_Click(object sender, EventArgs e)
        {
            mtbIDcard.SelectionStart = 0; //Cursor start at first block
        }
    }
}
