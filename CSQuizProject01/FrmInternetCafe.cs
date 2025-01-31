using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
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
        //shareFunc
        private void keyNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // ปฏิเสธการพิมพ์ตัวอื่นที่ไม่ใช่ตัวเลข
            }
        }
        private void btGoRentRoom_Click(object sender, EventArgs e)
        {
            FrmRentRoom frmRentRoom = new FrmRentRoom();
            frmRentRoom.Show();
            Hide();
        }
        //Keypress=================================================================
        private void mtbIDcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberOnly(sender, e);
        }
        private void tbAmountUsing_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberOnly(sender, e);
        }
        private void mtbIDcard_Click(object sender, EventArgs e)
        {
            mtbIDcard.SelectionStart = 0; //Cursor start at first block
        }
//btFunc==========================================================================
        //btNew
        private void btNew_Click(object sender, EventArgs e)
        {
            cldUsing.SetDate(DateTime.Today);
            tbFullname.Clear();
            tbAmountUsing.Clear();
            rdMember.Checked = true;
            cbbTypeUsing.SelectedIndex = 0;
            cbAccept.Checked = false;
            lbShowUsingDate.Text = "-";
            lbShowIDcard.Text = "-";
            lbShowFullname.Text = "-";
            lbShowTypeMember.Text = "-";
            lbShowTypeUsing.Text = "-";
            lbShowAmountUsing.Text = "-";
            lbShowTotal.Text = "0.00"; 
        }
        //btExit
        private void dbtExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            //Validate every tb data
            if (!mtbIDcard.MaskCompleted)
            {
                ShareData.showWarningMSG("ป้อนเลขประจำตัวประชาชนด้วย");
            }
            else if (tbFullname.Text.Trim().Length == 0) 
            {
                ShareData.showWarningMSG("ป้อนเลขชื่อ-สกุลด้วย");
            }
            else if (tbAmountUsing.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนจำนวนการใช้บริการด้วย");
            }
            else if (cbAccept.Checked == false)
            {
                ShareData.showWarningMSG("ยีนยันการชำระเงินด้วย");
            }
            else
            {
                //Create Variable and Calculate
                string selectedType = cbbTypeUsing.SelectedItem?.ToString();
                DateTime selectedDate = cldUsing.SelectionStart;
                int buddhistYear = selectedDate.Year + 543; // แปลง ค.ศ. เป็น พ.ศ.
                string ThaiDate = selectedDate.ToString("วันที่ d MMMM ", new CultureInfo("th-TH")) + buddhistYear.ToString();
                double pricePerHour = 0;

                switch (cbbTypeUsing.SelectedIndex)
                {
                    case 0: // อินเตอร์เน็ต
                        pricePerHour = 20.5;
                        lbShowTypeUsing.Text = "อินเตอร์เน็ต";
                        
                        break;
                    case 1: // พิมพ์งาน
                        pricePerHour = 10.5;
                        lbShowTypeUsing.Text = "พิมพ์งาน";
                        break;
                    case 2: // เล่นเกมส์ Offline
                        pricePerHour = 15.5;
                        lbShowTypeUsing.Text = "เล่นเกมส์ Offline";
                        break;
                    case 3: // เล่นเกมส์ Online
                        pricePerHour = 25.5;
                        lbShowTypeUsing.Text = "เล่นเกมส์ Online";
                        break;
                }
                if (rdMember.Checked == true)
                {
                    lbShowTypeMember.Text = "สมาชิก";
                }
                else if (rdStudent.Checked == true)
                {
                    lbShowTypeMember.Text = "นักเรียน/นักศึกษา";
                }
                else
                {
                    lbShowTypeMember.Text = "บุคคลทั่วไป";
                }
                // คำนวณราคาเริ่มต้นตามชั่วโมงที่ใช้
                double totalAmount = double.Parse(tbAmountUsing.Text) * pricePerHour;

                // ตรวจสอบประเภทสมาชิกและคำนวณราคา
                if (lbShowTypeMember.Text == "สมาชิก")
                {
                    totalAmount -= totalAmount * 0.10; // ลด 10%
                    lbShowTotal.Text = totalAmount.ToString("#,###,##0.00");
                }
                else if (lbShowTypeMember.Text == "นักเรียน/นักศึกษา")
                {
                    totalAmount -= totalAmount * 0.05; // ลด 5%
                    lbShowTotal.Text = totalAmount.ToString("#,###,##0.00");
                }
                else
                {
                    lbShowTotal.Text = totalAmount.ToString("#,###,##0.00");
                }

                //Display
                lbShowUsingDate.Text = ThaiDate;
                lbShowIDcard.Text = mtbIDcard.Text;
                lbShowFullname.Text = tbFullname.Text;
                lbShowAmountUsing.Text = tbAmountUsing.Text;
                
                
                
            }
        }
    }
}
