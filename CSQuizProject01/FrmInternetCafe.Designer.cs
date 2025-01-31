namespace CSQuizProject01
{
    partial class FrmInternetCafe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.rdMember = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbIDcard = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cldUsing = new System.Windows.Forms.MonthCalendar();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAmountUsing = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTypeUsing = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.cbAccept = new System.Windows.Forms.CheckBox();
            this.dbtExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbShowTotal = new System.Windows.Forms.Label();
            this.lbShowAmountUsing = new System.Windows.Forms.Label();
            this.lbShowTypeUsing = new System.Windows.Forms.Label();
            this.lbShowTypeMember = new System.Windows.Forms.Label();
            this.lbShowFullname = new System.Windows.Forms.Label();
            this.lbShowIDcard = new System.Windows.Forms.Label();
            this.lbShowUsingDate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btGoRentRoom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdNormal);
            this.groupBox1.Controls.Add(this.rdStudent);
            this.groupBox1.Controls.Add(this.rdMember);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbFullname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mtbIDcard);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cldUsing);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(504, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "วันที่ใช้บริการ";
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Location = new System.Drawing.Point(230, 190);
            this.rdNormal.Margin = new System.Windows.Forms.Padding(2);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(134, 19);
            this.rdNormal.TabIndex = 10;
            this.rdNormal.Text = "บุคคลทั่วไป ไม่มีส่วนลด";
            this.rdNormal.UseVisualStyleBackColor = true;
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(230, 158);
            this.rdStudent.Margin = new System.Windows.Forms.Padding(2);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(149, 19);
            this.rdStudent.TabIndex = 9;
            this.rdStudent.Text = "นักเรียน/นักศึกษา ลด 5%";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // rdMember
            // 
            this.rdMember.AutoSize = true;
            this.rdMember.Checked = true;
            this.rdMember.Location = new System.Drawing.Point(230, 126);
            this.rdMember.Margin = new System.Windows.Forms.Padding(2);
            this.rdMember.Name = "rdMember";
            this.rdMember.Size = new System.Drawing.Size(101, 19);
            this.rdMember.TabIndex = 8;
            this.rdMember.TabStop = true;
            this.rdMember.Text = "สมาชิก ลด 10%";
            this.rdMember.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ประเภทผู้ใช้บริการ";
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(292, 66);
            this.tbFullname.Margin = new System.Windows.Forms.Padding(2);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(159, 21);
            this.tbFullname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ชื่อ-สกุล";
            // 
            // mtbIDcard
            // 
            this.mtbIDcard.Location = new System.Drawing.Point(335, 38);
            this.mtbIDcard.Margin = new System.Windows.Forms.Padding(2);
            this.mtbIDcard.Mask = "0-0000-00000-00-0";
            this.mtbIDcard.Name = "mtbIDcard";
            this.mtbIDcard.Size = new System.Drawing.Size(116, 21);
            this.mtbIDcard.TabIndex = 4;
            this.mtbIDcard.Click += new System.EventHandler(this.mtbIDcard_Click);
            this.mtbIDcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbIDcard_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสประจำตัวประชาชน";
            // 
            // cldUsing
            // 
            this.cldUsing.Location = new System.Drawing.Point(20, 52);
            this.cldUsing.Margin = new System.Windows.Forms.Padding(7);
            this.cldUsing.Name = "cldUsing";
            this.cldUsing.TabIndex = 2;
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(177, 36);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(248, 29);
            this.HeadLabel.TabIndex = 1;
            this.HeadLabel.Text = "โปรแกรม Internet Cafe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbAmountUsing);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbbTypeUsing);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 359);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(331, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "ชั่วโมง";
            // 
            // tbAmountUsing
            // 
            this.tbAmountUsing.Location = new System.Drawing.Point(120, 111);
            this.tbAmountUsing.Margin = new System.Windows.Forms.Padding(2);
            this.tbAmountUsing.Name = "tbAmountUsing";
            this.tbAmountUsing.Size = new System.Drawing.Size(126, 21);
            this.tbAmountUsing.TabIndex = 12;
            this.tbAmountUsing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmountUsing_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "จำนวนการใช้บริการ";
            // 
            // cbbTypeUsing
            // 
            this.cbbTypeUsing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeUsing.FormattingEnabled = true;
            this.cbbTypeUsing.Items.AddRange(new object[] {
            "อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท",
            "พิมพ์งาน ชั่วโมงละ 10.50 บาท",
            "เล่นเกมส์ Offline ชั่วโมงละ 15.50 บาท",
            "เล่นเกมส์ Online  ชั่วโมงละ 25.50 บาท"});
            this.cbbTypeUsing.Location = new System.Drawing.Point(120, 53);
            this.cbbTypeUsing.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTypeUsing.Name = "cbbTypeUsing";
            this.cbbTypeUsing.Size = new System.Drawing.Size(186, 23);
            this.cbbTypeUsing.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "ประเภทการใช้บริการ";
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(368, 366);
            this.btNew.Margin = new System.Windows.Forms.Padding(2);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(170, 28);
            this.btNew.TabIndex = 3;
            this.btNew.Text = "เริ่มใหม่";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCal.Location = new System.Drawing.Point(470, 439);
            this.btCal.Margin = new System.Windows.Forms.Padding(2);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(68, 28);
            this.btCal.TabIndex = 4;
            this.btCal.Text = "คำนวณ";
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // cbAccept
            // 
            this.cbAccept.AutoSize = true;
            this.cbAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccept.Location = new System.Drawing.Point(369, 445);
            this.cbAccept.Margin = new System.Windows.Forms.Padding(2);
            this.cbAccept.Name = "cbAccept";
            this.cbAccept.Size = new System.Drawing.Size(97, 19);
            this.cbAccept.TabIndex = 5;
            this.cbAccept.Text = "ยืนยันชำระเงิน";
            this.cbAccept.UseVisualStyleBackColor = true;
            // 
            // dbtExit
            // 
            this.dbtExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dbtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbtExit.Location = new System.Drawing.Point(368, 519);
            this.dbtExit.Margin = new System.Windows.Forms.Padding(2);
            this.dbtExit.Name = "dbtExit";
            this.dbtExit.Size = new System.Drawing.Size(170, 28);
            this.dbtExit.TabIndex = 6;
            this.dbtExit.Text = "จบโปรแกรม";
            this.dbtExit.UseVisualStyleBackColor = false;
            this.dbtExit.Click += new System.EventHandler(this.dbtExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lbShowTotal);
            this.groupBox3.Controls.Add(this.lbShowAmountUsing);
            this.groupBox3.Controls.Add(this.lbShowTypeUsing);
            this.groupBox3.Controls.Add(this.lbShowTypeMember);
            this.groupBox3.Controls.Add(this.lbShowFullname);
            this.groupBox3.Controls.Add(this.lbShowIDcard);
            this.groupBox3.Controls.Add(this.lbShowUsingDate);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(556, 83);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(327, 464);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox1.Image = global::CSQuizProject01.Properties.Resources.marvel1;
            this.pictureBox1.Location = new System.Drawing.Point(119, 297);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 102);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lbShowTotal
            // 
            this.lbShowTotal.BackColor = System.Drawing.Color.Aqua;
            this.lbShowTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTotal.ForeColor = System.Drawing.Color.Red;
            this.lbShowTotal.Location = new System.Drawing.Point(44, 414);
            this.lbShowTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShowTotal.Name = "lbShowTotal";
            this.lbShowTotal.Size = new System.Drawing.Size(255, 38);
            this.lbShowTotal.TabIndex = 23;
            this.lbShowTotal.Text = "00.00";
            this.lbShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbShowAmountUsing
            // 
            this.lbShowAmountUsing.BackColor = System.Drawing.Color.Aqua;
            this.lbShowAmountUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowAmountUsing.ForeColor = System.Drawing.Color.Red;
            this.lbShowAmountUsing.Location = new System.Drawing.Point(122, 260);
            this.lbShowAmountUsing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShowAmountUsing.Name = "lbShowAmountUsing";
            this.lbShowAmountUsing.Size = new System.Drawing.Size(170, 20);
            this.lbShowAmountUsing.TabIndex = 22;
            this.lbShowAmountUsing.Text = "-";
            // 
            // lbShowTypeUsing
            // 
            this.lbShowTypeUsing.BackColor = System.Drawing.Color.Aqua;
            this.lbShowTypeUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTypeUsing.ForeColor = System.Drawing.Color.Red;
            this.lbShowTypeUsing.Location = new System.Drawing.Point(122, 222);
            this.lbShowTypeUsing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShowTypeUsing.Name = "lbShowTypeUsing";
            this.lbShowTypeUsing.Size = new System.Drawing.Size(170, 20);
            this.lbShowTypeUsing.TabIndex = 21;
            this.lbShowTypeUsing.Text = "-";
            // 
            // lbShowTypeMember
            // 
            this.lbShowTypeMember.BackColor = System.Drawing.Color.Aqua;
            this.lbShowTypeMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTypeMember.ForeColor = System.Drawing.Color.Red;
            this.lbShowTypeMember.Location = new System.Drawing.Point(122, 179);
            this.lbShowTypeMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShowTypeMember.Name = "lbShowTypeMember";
            this.lbShowTypeMember.Size = new System.Drawing.Size(170, 20);
            this.lbShowTypeMember.TabIndex = 20;
            this.lbShowTypeMember.Text = "-";
            // 
            // lbShowFullname
            // 
            this.lbShowFullname.BackColor = System.Drawing.Color.Aqua;
            this.lbShowFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowFullname.ForeColor = System.Drawing.Color.Red;
            this.lbShowFullname.Location = new System.Drawing.Point(122, 142);
            this.lbShowFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShowFullname.Name = "lbShowFullname";
            this.lbShowFullname.Size = new System.Drawing.Size(170, 20);
            this.lbShowFullname.TabIndex = 19;
            this.lbShowFullname.Text = "-";
            // 
            // lbShowIDcard
            // 
            this.lbShowIDcard.BackColor = System.Drawing.Color.Aqua;
            this.lbShowIDcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowIDcard.ForeColor = System.Drawing.Color.Red;
            this.lbShowIDcard.Location = new System.Drawing.Point(122, 106);
            this.lbShowIDcard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShowIDcard.Name = "lbShowIDcard";
            this.lbShowIDcard.Size = new System.Drawing.Size(170, 19);
            this.lbShowIDcard.TabIndex = 18;
            this.lbShowIDcard.Text = "-";
            // 
            // lbShowUsingDate
            // 
            this.lbShowUsingDate.BackColor = System.Drawing.Color.Aqua;
            this.lbShowUsingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowUsingDate.ForeColor = System.Drawing.Color.Red;
            this.lbShowUsingDate.Location = new System.Drawing.Point(122, 68);
            this.lbShowUsingDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShowUsingDate.Name = "lbShowUsingDate";
            this.lbShowUsingDate.Size = new System.Drawing.Size(170, 19);
            this.lbShowUsingDate.TabIndex = 17;
            this.lbShowUsingDate.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 261);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 15);
            this.label15.TabIndex = 16;
            this.label15.Text = "จำนวนการใช้บริการ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 223);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "ประเภทการใช้บริการ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 180);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "ประเภทผู้ใช้บริการ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 142);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "ชื่อ-สกุล";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "รหัสประจำตัวประชาชน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "วันที่ใช้บริการ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(80, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "ข้อมูลการชำระเงิน";
            // 
            // btGoRentRoom
            // 
            this.btGoRentRoom.Location = new System.Drawing.Point(808, 12);
            this.btGoRentRoom.Name = "btGoRentRoom";
            this.btGoRentRoom.Size = new System.Drawing.Size(75, 23);
            this.btGoRentRoom.TabIndex = 33;
            this.btGoRentRoom.Text = "RentRoom";
            this.btGoRentRoom.UseVisualStyleBackColor = true;
            this.btGoRentRoom.Click += new System.EventHandler(this.btGoRentRoom_Click);
            // 
            // FrmInternetCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 569);
            this.Controls.Add(this.btGoRentRoom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dbtExit);
            this.Controls.Add(this.cbAccept);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInternetCafe";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรม Quiz1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.MonthCalendar cldUsing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbIDcard;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.RadioButton rdStudent;
        private System.Windows.Forms.RadioButton rdMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbTypeUsing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAmountUsing;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.CheckBox cbAccept;
        private System.Windows.Forms.Button dbtExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbShowTotal;
        private System.Windows.Forms.Label lbShowAmountUsing;
        private System.Windows.Forms.Label lbShowTypeUsing;
        private System.Windows.Forms.Label lbShowTypeMember;
        private System.Windows.Forms.Label lbShowFullname;
        private System.Windows.Forms.Label lbShowIDcard;
        private System.Windows.Forms.Label lbShowUsingDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btGoRentRoom;
    }
}

