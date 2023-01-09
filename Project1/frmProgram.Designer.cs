namespace Project1
{
    partial class frmProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgram));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNoOfTickets = new System.Windows.Forms.Label();
            this.cmBoxNoTickets = new System.Windows.Forms.ComboBox();
            this.cmbBoxTo = new System.Windows.Forms.ComboBox();
            this.cmbBoxFrom = new System.Windows.Forms.ComboBox();
            this.chkBoxWindow = new System.Windows.Forms.CheckBox();
            this.chkBoxVip = new System.Windows.Forms.CheckBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblWelc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departure";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblNoOfTickets);
            this.groupBox1.Controls.Add(this.cmBoxNoTickets);
            this.groupBox1.Controls.Add(this.cmbBoxTo);
            this.groupBox1.Controls.Add(this.cmbBoxFrom);
            this.groupBox1.Controls.Add(this.chkBoxWindow);
            this.groupBox1.Controls.Add(this.chkBoxVip);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.btnCheckOut);
            this.groupBox1.Controls.Add(this.btnBook);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(66, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight Details";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(96, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Unbook revervations";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(81, 222);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 37);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // lblNoOfTickets
            // 
            this.lblNoOfTickets.AutoSize = true;
            this.lblNoOfTickets.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoOfTickets.Location = new System.Drawing.Point(38, 103);
            this.lblNoOfTickets.Name = "lblNoOfTickets";
            this.lblNoOfTickets.Size = new System.Drawing.Size(51, 17);
            this.lblNoOfTickets.TabIndex = 13;
            this.lblNoOfTickets.Text = "Tickets";
            this.lblNoOfTickets.Click += new System.EventHandler(this.lblNoOfTickets_Click);
            // 
            // cmBoxNoTickets
            // 
            this.cmBoxNoTickets.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmBoxNoTickets.FormattingEnabled = true;
            this.cmBoxNoTickets.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmBoxNoTickets.Location = new System.Drawing.Point(104, 100);
            this.cmBoxNoTickets.Name = "cmBoxNoTickets";
            this.cmBoxNoTickets.Size = new System.Drawing.Size(121, 25);
            this.cmBoxNoTickets.TabIndex = 12;
            // 
            // cmbBoxTo
            // 
            this.cmbBoxTo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxTo.FormattingEnabled = true;
            this.cmbBoxTo.Items.AddRange(new object[] {
            "London",
            "Australia",
            "Canada",
            "NewYork",
            "Dubai",
            "Algeria",
            "Morocco",
            "Tunisia",
            "Amman",
            "Paris"});
            this.cmbBoxTo.Location = new System.Drawing.Point(196, 60);
            this.cmbBoxTo.Name = "cmbBoxTo";
            this.cmbBoxTo.Size = new System.Drawing.Size(121, 25);
            this.cmbBoxTo.TabIndex = 11;
            // 
            // cmbBoxFrom
            // 
            this.cmbBoxFrom.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxFrom.FormattingEnabled = true;
            this.cmbBoxFrom.Items.AddRange(new object[] {
            "Alexandria",
            "Cairo",
            "Sharm-El-Sheikh"});
            this.cmbBoxFrom.Location = new System.Drawing.Point(6, 60);
            this.cmbBoxFrom.Name = "cmbBoxFrom";
            this.cmbBoxFrom.Size = new System.Drawing.Size(121, 25);
            this.cmbBoxFrom.TabIndex = 10;
            // 
            // chkBoxWindow
            // 
            this.chkBoxWindow.AutoSize = true;
            this.chkBoxWindow.Location = new System.Drawing.Point(198, 200);
            this.chkBoxWindow.Name = "chkBoxWindow";
            this.chkBoxWindow.Size = new System.Drawing.Size(126, 19);
            this.chkBoxWindow.TabIndex = 9;
            this.chkBoxWindow.Text = "WindowSeat(+50$)";
            this.chkBoxWindow.UseVisualStyleBackColor = true;
            // 
            // chkBoxVip
            // 
            this.chkBoxVip.AutoSize = true;
            this.chkBoxVip.Location = new System.Drawing.Point(6, 200);
            this.chkBoxVip.Name = "chkBoxVip";
            this.chkBoxVip.Size = new System.Drawing.Size(83, 19);
            this.chkBoxVip.TabIndex = 8;
            this.chkBoxVip.Text = "Vip(+100$)";
            this.chkBoxVip.UseVisualStyleBackColor = true;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(198, 40);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 17);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.Location = new System.Drawing.Point(6, 40);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 17);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "From:";
            this.lblFrom.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(242, 278);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(6, 278);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblWelc
            // 
            this.lblWelc.AutoSize = true;
            this.lblWelc.BackColor = System.Drawing.Color.Transparent;
            this.lblWelc.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(68)))));
            this.lblWelc.Location = new System.Drawing.Point(120, 9);
            this.lblWelc.Name = "lblWelc";
            this.lblWelc.Size = new System.Drawing.Size(158, 45);
            this.lblWelc.TabIndex = 8;
            this.lblWelc.Text = "Welcome";
            // 
            // frmProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1003, 475);
            this.Controls.Add(this.lblWelc);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgram";
            this.Load += new System.EventHandler(this.frmProgram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnBook;
        private Button btnCheckOut;
        private Label lblFrom;
        private Label lblTo;
        private ComboBox cmbBoxTo;
        private ComboBox cmbBoxFrom;
        private CheckBox chkBoxWindow;
        private CheckBox chkBoxVip;
        private Label lblNoOfTickets;
        private ComboBox cmBoxNoTickets;
        private Label lblWelc;
        private Label lblTotal;
        private Button btnClear;
    }
}