namespace CSCallDLL
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnWriteLog = new System.Windows.Forms.Button();
            this.TxtLV = new System.Windows.Forms.TextBox();
            this.lblCH = new System.Windows.Forms.Label();
            this.TxtCH = new System.Windows.Forms.TextBox();
            this.lblLV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWriteLog
            // 
            this.btnWriteLog.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.btnWriteLog.Location = new System.Drawing.Point(7, 82);
            this.btnWriteLog.Name = "btnWriteLog";
            this.btnWriteLog.Size = new System.Drawing.Size(217, 36);
            this.btnWriteLog.TabIndex = 33;
            this.btnWriteLog.Text = "Write File Exist(Now)";
            this.btnWriteLog.Click += new System.EventHandler(this.btnWriteLog_Click);
            // 
            // TxtLV
            // 
            this.TxtLV.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.TxtLV.Location = new System.Drawing.Point(56, 44);
            this.TxtLV.Name = "TxtLV";
            this.TxtLV.Size = new System.Drawing.Size(100, 32);
            this.TxtLV.TabIndex = 32;
            this.TxtLV.Text = "20";
            // 
            // lblCH
            // 
            this.lblCH.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.lblCH.Location = new System.Drawing.Point(7, 44);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(51, 32);
            this.lblCH.Text = "CH:";
            // 
            // TxtCH
            // 
            this.TxtCH.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.TxtCH.Location = new System.Drawing.Point(56, 3);
            this.TxtCH.Name = "TxtCH";
            this.TxtCH.Size = new System.Drawing.Size(100, 32);
            this.TxtCH.TabIndex = 31;
            this.TxtCH.Text = "10";
            // 
            // lblLV
            // 
            this.lblLV.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.lblLV.Location = new System.Drawing.Point(7, 3);
            this.lblLV.Name = "lblLV";
            this.lblLV.Size = new System.Drawing.Size(43, 29);
            this.lblLV.Text = "LV:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(521, 217);
            this.Controls.Add(this.btnWriteLog);
            this.Controls.Add(this.TxtLV);
            this.Controls.Add(this.lblCH);
            this.Controls.Add(this.TxtCH);
            this.Controls.Add(this.lblLV);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "CS Call CELOG.DLL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnWriteLog;
        internal System.Windows.Forms.TextBox TxtLV;
        internal System.Windows.Forms.Label lblCH;
        internal System.Windows.Forms.TextBox TxtCH;
        internal System.Windows.Forms.Label lblLV;
    }
}

