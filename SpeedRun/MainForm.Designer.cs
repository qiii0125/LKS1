namespace SpeedRun
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.greeting = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepaidPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.greeting, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.logoutBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.time, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpeedRun.Properties.Resources.navigation_bar;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(42, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.tableLayoutPanel1.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(278, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esemka Laundry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greeting
            // 
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(816, 0);
            this.greeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greeting.Name = "greeting";
            this.tableLayoutPanel1.SetRowSpan(this.greeting, 2);
            this.greeting.Size = new System.Drawing.Size(229, 44);
            this.greeting.TabIndex = 1;
            this.greeting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1053, 4);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.tableLayoutPanel1.SetRowSpan(this.logoutBtn, 2);
            this.logoutBtn.Size = new System.Drawing.Size(89, 39);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(340, 0);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.tableLayoutPanel1.SetRowSpan(this.time, 2);
            this.time.Size = new System.Drawing.Size(468, 44);
            this.time.TabIndex = 1;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32558F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.67442F));
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 73);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1147, 466);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.managePackageToolStripMenuItem,
            this.manageServiceToolStripMenuItem,
            this.transactionDepositToolStripMenuItem,
            this.prepaidPackageToolStripMenuItem,
            this.viewTransactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(127, 466);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // managePackageToolStripMenuItem
            // 
            this.managePackageToolStripMenuItem.Name = "managePackageToolStripMenuItem";
            this.managePackageToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.managePackageToolStripMenuItem.Text = "Manage Package";
            this.managePackageToolStripMenuItem.Click += new System.EventHandler(this.managePackageToolStripMenuItem_Click);
            // 
            // manageServiceToolStripMenuItem
            // 
            this.manageServiceToolStripMenuItem.Name = "manageServiceToolStripMenuItem";
            this.manageServiceToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.manageServiceToolStripMenuItem.Text = "Manage Service";
            this.manageServiceToolStripMenuItem.Click += new System.EventHandler(this.manageServiceToolStripMenuItem_Click);
            // 
            // transactionDepositToolStripMenuItem
            // 
            this.transactionDepositToolStripMenuItem.Name = "transactionDepositToolStripMenuItem";
            this.transactionDepositToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.transactionDepositToolStripMenuItem.Text = "Transaction Deposit";
            this.transactionDepositToolStripMenuItem.Click += new System.EventHandler(this.transactionDepositToolStripMenuItem_Click);
            // 
            // prepaidPackageToolStripMenuItem
            // 
            this.prepaidPackageToolStripMenuItem.Name = "prepaidPackageToolStripMenuItem";
            this.prepaidPackageToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.prepaidPackageToolStripMenuItem.Text = "Prepaid Package";
            this.prepaidPackageToolStripMenuItem.Click += new System.EventHandler(this.prepaidPackageToolStripMenuItem_Click);
            // 
            // viewTransactionToolStripMenuItem
            // 
            this.viewTransactionToolStripMenuItem.Name = "viewTransactionToolStripMenuItem";
            this.viewTransactionToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.viewTransactionToolStripMenuItem.Text = "View Transaction";
            this.viewTransactionToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(202, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(941, 466);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 554);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prepaidPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label greeting;
    }
}