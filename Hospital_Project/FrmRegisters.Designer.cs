namespace Hospital_Project
{
    partial class FrmRegisters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisters));
            this.BtnPatient = new System.Windows.Forms.Button();
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.BtnSecretary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPatient
            // 
            this.BtnPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatient.BackgroundImage")));
            this.BtnPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatient.Location = new System.Drawing.Point(41, 233);
            this.BtnPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(229, 172);
            this.BtnPatient.TabIndex = 0;
            this.BtnPatient.UseVisualStyleBackColor = true;
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoctor.BackgroundImage")));
            this.BtnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctor.Location = new System.Drawing.Point(290, 233);
            this.BtnDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(229, 172);
            this.BtnDoctor.TabIndex = 1;
            this.BtnDoctor.UseVisualStyleBackColor = true;
            // 
            // BtnSecretary
            // 
            this.BtnSecretary.BackColor = System.Drawing.Color.MintCream;
            this.BtnSecretary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSecretary.BackgroundImage")));
            this.BtnSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecretary.Location = new System.Drawing.Point(541, 233);
            this.BtnSecretary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSecretary.Name = "BtnSecretary";
            this.BtnSecretary.Size = new System.Drawing.Size(229, 172);
            this.BtnSecretary.TabIndex = 2;
            this.BtnSecretary.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(132, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(380, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(612, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ali Wert Hospital";
            // 
            // FrmRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(837, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSecretary);
            this.Controls.Add(this.BtnDoctor);
            this.Controls.Add(this.BtnPatient);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegisters";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button BtnDoctor;
        private System.Windows.Forms.Button BtnSecretary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

