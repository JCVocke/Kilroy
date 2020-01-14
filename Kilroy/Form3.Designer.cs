namespace Kilroy
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelNAM = new System.Windows.Forms.Label();
            this.labelMID = new System.Windows.Forms.Label();
            this.labelUID = new System.Windows.Forms.Label();
            this.labelVER = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MID :: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UID :: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAM :: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "VER :: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TAG ::";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(56, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 199);
            this.listBox1.TabIndex = 5;
            // 
            // labelNAM
            // 
            this.labelNAM.AutoSize = true;
            this.labelNAM.Location = new System.Drawing.Point(53, 9);
            this.labelNAM.Name = "labelNAM";
            this.labelNAM.Size = new System.Drawing.Size(35, 13);
            this.labelNAM.TabIndex = 6;
            this.labelNAM.Text = "label6";
            // 
            // labelMID
            // 
            this.labelMID.AutoSize = true;
            this.labelMID.Location = new System.Drawing.Point(53, 37);
            this.labelMID.Name = "labelMID";
            this.labelMID.Size = new System.Drawing.Size(35, 13);
            this.labelMID.TabIndex = 7;
            this.labelMID.Text = "label7";
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(53, 50);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(35, 13);
            this.labelUID.TabIndex = 8;
            this.labelUID.Text = "label8";
            // 
            // labelVER
            // 
            this.labelVER.AutoSize = true;
            this.labelVER.Location = new System.Drawing.Point(53, 62);
            this.labelVER.Name = "labelVER";
            this.labelVER.Size = new System.Drawing.Size(51, 13);
            this.labelVER.TabIndex = 9;
            this.labelVER.Text = "labelVER";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 504);
            this.Controls.Add(this.labelVER);
            this.Controls.Add(this.labelUID);
            this.Controls.Add(this.labelMID);
            this.Controls.Add(this.labelNAM);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelNAM;
        private System.Windows.Forms.Label labelMID;
        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.Label labelVER;
    }
}