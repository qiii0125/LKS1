namespace SpeedRun
{
    partial class EmployeeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.greeting = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepaidPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.RichTextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.connPass = new System.Windows.Forms.TextBox();
            this.jobTitle = new System.Windows.Forms.ComboBox();
            this.salary = new System.Windows.Forms.NumericUpDown();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.greeting, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.logoutBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.time, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 48);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpeedRun.Properties.Resources.navigation_bar;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.tableLayoutPanel1.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(281, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esemka Laundry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greeting
            // 
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(820, 0);
            this.greeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greeting.Name = "greeting";
            this.tableLayoutPanel1.SetRowSpan(this.greeting, 2);
            this.greeting.Size = new System.Drawing.Size(229, 44);
            this.greeting.TabIndex = 1;
            this.greeting.Text = "label1";
            this.greeting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1057, 4);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.tableLayoutPanel1.SetRowSpan(this.logoutBtn, 2);
            this.logoutBtn.Size = new System.Drawing.Size(89, 40);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(344, 0);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.tableLayoutPanel1.SetRowSpan(this.time, 2);
            this.time.Size = new System.Drawing.Size(468, 44);
            this.time.TabIndex = 1;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 89);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 421);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.managePackageToolStripMenuItem,
            this.manageServiceToolStripMenuItem,
            this.transactionDepositToolStripMenuItem,
            this.prepaidPackageToolStripMenuItem,
            this.viewTransactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(130, 120);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            // 
            // managePackageToolStripMenuItem
            // 
            this.managePackageToolStripMenuItem.Name = "managePackageToolStripMenuItem";
            this.managePackageToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.managePackageToolStripMenuItem.Text = "Manage Package";
            // 
            // manageServiceToolStripMenuItem
            // 
            this.manageServiceToolStripMenuItem.Name = "manageServiceToolStripMenuItem";
            this.manageServiceToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.manageServiceToolStripMenuItem.Text = "Manage Service";
            // 
            // transactionDepositToolStripMenuItem
            // 
            this.transactionDepositToolStripMenuItem.Name = "transactionDepositToolStripMenuItem";
            this.transactionDepositToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.transactionDepositToolStripMenuItem.Text = "Transaction Deposit";
            // 
            // prepaidPackageToolStripMenuItem
            // 
            this.prepaidPackageToolStripMenuItem.Name = "prepaidPackageToolStripMenuItem";
            this.prepaidPackageToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.prepaidPackageToolStripMenuItem.Text = "Prepaid Package";
            // 
            // viewTransactionToolStripMenuItem
            // 
            this.viewTransactionToolStripMenuItem.Name = "viewTransactionToolStripMenuItem";
            this.viewTransactionToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.viewTransactionToolStripMenuItem.Text = "View Transaction";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(208, 89);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(959, 224);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(955, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(212, 321);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(955, 326);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.43631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.56368F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.id, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.name, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.email, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.PhoneNum, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.address, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.pass, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.connPass, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.jobTitle, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.salary, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.insert, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.update, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.delete, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.save, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.cancel, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.dob, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(947, 322);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date of Birt";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(461, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Job Title";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(461, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Salary";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(461, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(461, 173);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Confirm Password";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(147, 4);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(265, 22);
            this.id.TabIndex = 1;
            // 
            // name
            // 
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(147, 58);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(265, 22);
            this.name.TabIndex = 1;
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(147, 120);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(265, 22);
            this.email.TabIndex = 1;
            // 
            // PhoneNum
            // 
            this.PhoneNum.Enabled = false;
            this.PhoneNum.Location = new System.Drawing.Point(147, 177);
            this.PhoneNum.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(265, 22);
            this.PhoneNum.TabIndex = 1;
            // 
            // address
            // 
            this.address.Enabled = false;
            this.address.Location = new System.Drawing.Point(147, 230);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(265, 41);
            this.address.TabIndex = 2;
            this.address.Text = "";
            // 
            // pass
            // 
            this.pass.Enabled = false;
            this.pass.Location = new System.Drawing.Point(590, 120);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(213, 22);
            this.pass.TabIndex = 3;
            // 
            // connPass
            // 
            this.connPass.Enabled = false;
            this.connPass.Location = new System.Drawing.Point(590, 177);
            this.connPass.Margin = new System.Windows.Forms.Padding(4);
            this.connPass.Name = "connPass";
            this.connPass.Size = new System.Drawing.Size(215, 22);
            this.connPass.TabIndex = 3;
            // 
            // jobTitle
            // 
            this.jobTitle.Enabled = false;
            this.jobTitle.FormattingEnabled = true;
            this.jobTitle.Location = new System.Drawing.Point(590, 4);
            this.jobTitle.Margin = new System.Windows.Forms.Padding(4);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(215, 24);
            this.jobTitle.TabIndex = 4;
            // 
            // salary
            // 
            this.salary.Enabled = false;
            this.salary.Location = new System.Drawing.Point(590, 58);
            this.salary.Margin = new System.Windows.Forms.Padding(4);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(215, 22);
            this.salary.TabIndex = 5;
            // 
            // dob
            // 
            this.dob.Enabled = false;
            this.dob.Location = new System.Drawing.Point(147, 279);
            this.dob.Margin = new System.Windows.Forms.Padding(4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(265, 22);
            this.dob.TabIndex = 6;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(841, 4);
            this.insert.Margin = new System.Windows.Forms.Padding(4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(100, 46);
            this.insert.TabIndex = 7;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(841, 58);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 54);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(841, 120);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 48);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(841, 177);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 45);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Enabled = false;
            this.cancel.Location = new System.Drawing.Point(841, 230);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 41);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 662);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prepaidPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox connPass;
        private System.Windows.Forms.ComboBox jobTitle;
        private System.Windows.Forms.NumericUpDown salary;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}