﻿namespace Hospital_Project
{
    partial class FrmDoctorInformationChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorInformationChange));
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbSubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdateInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(233, 277);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(147, 31);
            this.TxtPassword.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Surname:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(233, 50);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(147, 31);
            this.TxtName.TabIndex = 32;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(233, 100);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(147, 31);
            this.TxtSurname.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(233, 151);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(147, 31);
            this.MskTC.TabIndex = 29;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "T.C SSN:";
            // 
            // CmbSubject
            // 
            this.CmbSubject.FormattingEnabled = true;
            this.CmbSubject.Location = new System.Drawing.Point(233, 217);
            this.CmbSubject.Name = "CmbSubject";
            this.CmbSubject.Size = new System.Drawing.Size(147, 31);
            this.CmbSubject.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Subject:";
            // 
            // BtnUpdateInformation
            // 
            this.BtnUpdateInformation.BackColor = System.Drawing.Color.Red;
            this.BtnUpdateInformation.Location = new System.Drawing.Point(233, 326);
            this.BtnUpdateInformation.Name = "BtnUpdateInformation";
            this.BtnUpdateInformation.Size = new System.Drawing.Size(147, 36);
            this.BtnUpdateInformation.TabIndex = 36;
            this.BtnUpdateInformation.Text = "Update";
            this.BtnUpdateInformation.UseVisualStyleBackColor = false;
            this.BtnUpdateInformation.Click += new System.EventHandler(this.BtnUpdateInformation_Click);
            // 
            // FrmDoctorInformationChange
            // 
            this.AcceptButton = this.BtnUpdateInformation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(559, 442);
            this.Controls.Add(this.BtnUpdateInformation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorInformationChange";
            this.Text = "Doctor Information Update";
            this.Load += new System.EventHandler(this.FrmDoctorInformationChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnUpdateInformation;
    }
}