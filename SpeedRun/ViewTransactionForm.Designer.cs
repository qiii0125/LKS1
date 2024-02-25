namespace SpeedRun
{
    partial class ViewTransactionForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepaidPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.greeting = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpeedRun.Properties.Resources.navigation_bar;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // viewTransactionToolStripMenuItem
            // 
            this.viewTransactionToolStripMenuItem.Name = "viewTransactionToolStripMenuItem";
            this.viewTransactionToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.viewTransactionToolStripMenuItem.Text = "View Transaction";
            // 
            // prepaidPackageToolStripMenuItem
            // 
            this.prepaidPackageToolStripMenuItem.Name = "prepaidPackageToolStripMenuItem";
            this.prepaidPackageToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.prepaidPackageToolStripMenuItem.Text = "Prepaid Package";
            // 
            // transactionDepositToolStripMenuItem
            // 
            this.transactionDepositToolStripMenuItem.Name = "transactionDepositToolStripMenuItem";
            this.transactionDepositToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.transactionDepositToolStripMenuItem.Text = "Transaction Deposit";
            // 
            // manageServiceToolStripMenuItem
            // 
            this.manageServiceToolStripMenuItem.Name = "manageServiceToolStripMenuItem";
            this.manageServiceToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.manageServiceToolStripMenuItem.Text = "Manage Service";
            // 
            // managePackageToolStripMenuItem
            // 
            this.managePackageToolStripMenuItem.Name = "managePackageToolStripMenuItem";
            this.managePackageToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.managePackageToolStripMenuItem.Text = "Manage Package";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
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
            this.menuStrip1.Size = new System.Drawing.Size(162, 150);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 87);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 421);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.tableLayoutPanel1.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(279, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esemka Laundry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greeting
            // 
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(817, 0);
            this.greeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greeting.Name = "greeting";
            this.tableLayoutPanel1.SetRowSpan(this.greeting, 2);
            this.greeting.Size = new System.Drawing.Size(229, 44);
            this.greeting.TabIndex = 1;
            this.greeting.Text = "greeting";
            this.greeting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1054, 4);
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
            this.time.Location = new System.Drawing.Point(341, 0);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.tableLayoutPanel1.SetRowSpan(this.time, 2);
            this.time.Size = new System.Drawing.Size(468, 44);
            this.time.TabIndex = 1;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.greeting, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.logoutBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.time, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 48);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(188, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 289);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header Deposit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(188, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 349);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Deposit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(970, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(970, 322);
            this.dataGridView2.TabIndex = 0;
            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewTransactionForm";
            this.Text = "ViewTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prepaidPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}