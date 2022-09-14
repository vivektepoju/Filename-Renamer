namespace File_Renamer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.rtbFilesToBeNamed = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtTrim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppend = new System.Windows.Forms.Label();
            this.txtAppend = new System.Windows.Forms.TextBox();
            this.chkReplace = new System.Windows.Forms.CheckBox();
            this.txtReplaceFrom = new System.Windows.Forms.TextBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.lblReplaceWith = new System.Windows.Forms.Label();
            this.chkZipFiles = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.Maroon;
            this.lblPath.Location = new System.Drawing.Point(26, 30);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(55, 14);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Files Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(85, 27);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(398, 20);
            this.txtPath.TabIndex = 1;
            // 
            // rtbFilesToBeNamed
            // 
            this.rtbFilesToBeNamed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFilesToBeNamed.BackColor = System.Drawing.Color.DarkCyan;
            this.rtbFilesToBeNamed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFilesToBeNamed.ForeColor = System.Drawing.Color.White;
            this.rtbFilesToBeNamed.Location = new System.Drawing.Point(12, 164);
            this.rtbFilesToBeNamed.Name = "rtbFilesToBeNamed";
            this.rtbFilesToBeNamed.ReadOnly = true;
            this.rtbFilesToBeNamed.Size = new System.Drawing.Size(534, 233);
            this.rtbFilesToBeNamed.TabIndex = 2;
            this.rtbFilesToBeNamed.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(305, 130);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(192, 130);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // txtTrim
            // 
            this.txtTrim.Location = new System.Drawing.Point(139, 61);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(65, 20);
            this.txtTrim.TabIndex = 5;
            this.txtTrim.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(78, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trim Last";
            // 
            // lblAppend
            // 
            this.lblAppend.AutoSize = true;
            this.lblAppend.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppend.ForeColor = System.Drawing.Color.Maroon;
            this.lblAppend.Location = new System.Drawing.Point(252, 64);
            this.lblAppend.Name = "lblAppend";
            this.lblAppend.Size = new System.Drawing.Size(67, 14);
            this.lblAppend.TabIndex = 7;
            this.lblAppend.Text = "Append Last";
            // 
            // txtAppend
            // 
            this.txtAppend.Location = new System.Drawing.Point(325, 62);
            this.txtAppend.Name = "txtAppend";
            this.txtAppend.Size = new System.Drawing.Size(84, 20);
            this.txtAppend.TabIndex = 8;
            // 
            // chkReplace
            // 
            this.chkReplace.AutoSize = true;
            this.chkReplace.Location = new System.Drawing.Point(61, 99);
            this.chkReplace.Name = "chkReplace";
            this.chkReplace.Size = new System.Drawing.Size(66, 17);
            this.chkReplace.TabIndex = 11;
            this.chkReplace.Text = "Replace";
            this.chkReplace.UseVisualStyleBackColor = true;
            this.chkReplace.CheckedChanged += new System.EventHandler(this.ChkReplace_CheckedChanged);
            // 
            // txtReplaceFrom
            // 
            this.txtReplaceFrom.Enabled = false;
            this.txtReplaceFrom.Location = new System.Drawing.Point(140, 95);
            this.txtReplaceFrom.Name = "txtReplaceFrom";
            this.txtReplaceFrom.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceFrom.TabIndex = 12;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Enabled = false;
            this.txtReplaceWith.Location = new System.Drawing.Point(324, 95);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(96, 20);
            this.txtReplaceWith.TabIndex = 13;
            // 
            // lblReplaceWith
            // 
            this.lblReplaceWith.AutoSize = true;
            this.lblReplaceWith.Location = new System.Drawing.Point(270, 98);
            this.lblReplaceWith.Name = "lblReplaceWith";
            this.lblReplaceWith.Size = new System.Drawing.Size(29, 13);
            this.lblReplaceWith.TabIndex = 14;
            this.lblReplaceWith.Text = "With";
            // 
            // chkZipFiles
            // 
            this.chkZipFiles.AutoSize = true;
            this.chkZipFiles.Checked = true;
            this.chkZipFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZipFiles.Location = new System.Drawing.Point(61, 135);
            this.chkZipFiles.Name = "chkZipFiles";
            this.chkZipFiles.Size = new System.Drawing.Size(84, 17);
            this.chkZipFiles.TabIndex = 15;
            this.chkZipFiles.Text = "Zip files only";
            this.chkZipFiles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(558, 409);
            this.Controls.Add(this.chkZipFiles);
            this.Controls.Add(this.lblReplaceWith);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.txtReplaceFrom);
            this.Controls.Add(this.chkReplace);
            this.Controls.Add(this.txtAppend);
            this.Controls.Add(this.lblAppend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrim);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbFilesToBeNamed);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trim/Append File Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox rtbFilesToBeNamed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtTrim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppend;
        private System.Windows.Forms.TextBox txtAppend;
        private System.Windows.Forms.CheckBox chkReplace;
        private System.Windows.Forms.TextBox txtReplaceFrom;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Label lblReplaceWith;
        private System.Windows.Forms.CheckBox chkZipFiles;
    }
}

