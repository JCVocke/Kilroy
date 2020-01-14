namespace Kilroy
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
            this.listBoxACT = new System.Windows.Forms.ListBox();
            this.listBoxALL = new System.Windows.Forms.ListBox();
            this.buttonMODLOD = new System.Windows.Forms.Button();
            this.buttonMODSAV = new System.Windows.Forms.Button();
            this.buttonUPPTOP = new System.Windows.Forms.Button();
            this.buttonUPPNUM = new System.Windows.Forms.Button();
            this.buttonUPPONE = new System.Windows.Forms.Button();
            this.buttonTOOSLW = new System.Windows.Forms.Button();
            this.buttonDWNONE = new System.Windows.Forms.Button();
            this.buttonDWNNUM = new System.Windows.Forms.Button();
            this.buttonDWNLOW = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEXPORD = new System.Windows.Forms.Button();
            this.buttonIMPORD = new System.Windows.Forms.Button();
            this.buttonSRTAUT = new System.Windows.Forms.Button();
            this.buttonYaACTALL = new System.Windows.Forms.Button();
            this.buttonYaACTSEL = new System.Windows.Forms.Button();
            this.buttonREMACTSEL = new System.Windows.Forms.Button();
            this.buttonREMACTALL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxACT
            // 
            this.listBoxACT.FormattingEnabled = true;
            this.listBoxACT.Location = new System.Drawing.Point(6, 6);
            this.listBoxACT.Name = "listBoxACT";
            this.listBoxACT.Size = new System.Drawing.Size(331, 745);
            this.listBoxACT.TabIndex = 1;
            this.listBoxACT.SelectedIndexChanged += new System.EventHandler(this.listBoxACT_SelectedIndexChanged);
            // 
            // listBoxALL
            // 
            this.listBoxALL.FormattingEnabled = true;
            this.listBoxALL.Location = new System.Drawing.Point(556, 6);
            this.listBoxALL.Name = "listBoxALL";
            this.listBoxALL.Size = new System.Drawing.Size(331, 745);
            this.listBoxALL.TabIndex = 2;
            this.listBoxALL.SelectedIndexChanged += new System.EventHandler(this.listBoxALL_SelectedIndexChanged);
            this.listBoxALL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoIfYouSeeMeActingStrangely);
            this.listBoxALL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DontBeSurprised);
            // 
            // buttonMODLOD
            // 
            this.buttonMODLOD.Location = new System.Drawing.Point(5, 10);
            this.buttonMODLOD.Name = "buttonMODLOD";
            this.buttonMODLOD.Size = new System.Drawing.Size(190, 40);
            this.buttonMODLOD.TabIndex = 3;
            this.buttonMODLOD.Text = "Load Mods";
            this.buttonMODLOD.UseVisualStyleBackColor = true;
            this.buttonMODLOD.Click += new System.EventHandler(this.MataAuHimaDe_EV);
            // 
            // buttonMODSAV
            // 
            this.buttonMODSAV.Location = new System.Drawing.Point(5, 275);
            this.buttonMODSAV.Name = "buttonMODSAV";
            this.buttonMODSAV.Size = new System.Drawing.Size(190, 40);
            this.buttonMODSAV.TabIndex = 4;
            this.buttonMODSAV.Text = "Save Mods";
            this.buttonMODSAV.UseVisualStyleBackColor = true;
            this.buttonMODSAV.Click += new System.EventHandler(this.HimitsuWoShiriTai_EV);
            // 
            // buttonUPPTOP
            // 
            this.buttonUPPTOP.Location = new System.Drawing.Point(5, 75);
            this.buttonUPPTOP.Name = "buttonUPPTOP";
            this.buttonUPPTOP.Size = new System.Drawing.Size(85, 25);
            this.buttonUPPTOP.TabIndex = 5;
            this.buttonUPPTOP.Text = "Move To Top";
            this.buttonUPPTOP.UseVisualStyleBackColor = true;
            this.buttonUPPTOP.Click += new System.EventHandler(this.buttonUPPTOP_Click);
            // 
            // buttonUPPNUM
            // 
            this.buttonUPPNUM.Location = new System.Drawing.Point(5, 100);
            this.buttonUPPNUM.Name = "buttonUPPNUM";
            this.buttonUPPNUM.Size = new System.Drawing.Size(85, 25);
            this.buttonUPPNUM.TabIndex = 6;
            this.buttonUPPNUM.Text = "Up #";
            this.buttonUPPNUM.UseVisualStyleBackColor = true;
            this.buttonUPPNUM.Click += new System.EventHandler(this.buttonUPPNUM_Click);
            // 
            // buttonUPPONE
            // 
            this.buttonUPPONE.Location = new System.Drawing.Point(5, 125);
            this.buttonUPPONE.Name = "buttonUPPONE";
            this.buttonUPPONE.Size = new System.Drawing.Size(85, 25);
            this.buttonUPPONE.TabIndex = 7;
            this.buttonUPPONE.Text = "Up 1";
            this.buttonUPPONE.UseVisualStyleBackColor = true;
            this.buttonUPPONE.Click += new System.EventHandler(this.buttonUPPONE_Click);
            // 
            // buttonTOOSLW
            // 
            this.buttonTOOSLW.Location = new System.Drawing.Point(5, 150);
            this.buttonTOOSLW.Name = "buttonTOOSLW";
            this.buttonTOOSLW.Size = new System.Drawing.Size(85, 25);
            this.buttonTOOSLW.TabIndex = 8;
            this.buttonTOOSLW.Text = "Move To #";
            this.buttonTOOSLW.UseVisualStyleBackColor = true;
            this.buttonTOOSLW.Click += new System.EventHandler(this.buttonTOOSLW_Click);
            // 
            // buttonDWNONE
            // 
            this.buttonDWNONE.Location = new System.Drawing.Point(5, 175);
            this.buttonDWNONE.Name = "buttonDWNONE";
            this.buttonDWNONE.Size = new System.Drawing.Size(85, 25);
            this.buttonDWNONE.TabIndex = 9;
            this.buttonDWNONE.Text = "Down 1";
            this.buttonDWNONE.UseVisualStyleBackColor = true;
            this.buttonDWNONE.Click += new System.EventHandler(this.buttonDWNONE_Click);
            // 
            // buttonDWNNUM
            // 
            this.buttonDWNNUM.Location = new System.Drawing.Point(5, 200);
            this.buttonDWNNUM.Name = "buttonDWNNUM";
            this.buttonDWNNUM.Size = new System.Drawing.Size(85, 25);
            this.buttonDWNNUM.TabIndex = 10;
            this.buttonDWNNUM.Text = "Down #";
            this.buttonDWNNUM.UseVisualStyleBackColor = true;
            this.buttonDWNNUM.Click += new System.EventHandler(this.buttonDWNNUM_Click);
            // 
            // buttonDWNLOW
            // 
            this.buttonDWNLOW.Location = new System.Drawing.Point(5, 225);
            this.buttonDWNLOW.Name = "buttonDWNLOW";
            this.buttonDWNLOW.Size = new System.Drawing.Size(85, 25);
            this.buttonDWNLOW.TabIndex = 11;
            this.buttonDWNLOW.Text = "Down Bottom";
            this.buttonDWNLOW.UseVisualStyleBackColor = true;
            this.buttonDWNLOW.Click += new System.EventHandler(this.buttonDWNLOW_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEXPORD);
            this.groupBox1.Controls.Add(this.buttonIMPORD);
            this.groupBox1.Controls.Add(this.buttonSRTAUT);
            this.groupBox1.Controls.Add(this.buttonMODLOD);
            this.groupBox1.Controls.Add(this.buttonMODSAV);
            this.groupBox1.Controls.Add(this.buttonUPPTOP);
            this.groupBox1.Controls.Add(this.buttonUPPNUM);
            this.groupBox1.Controls.Add(this.buttonUPPONE);
            this.groupBox1.Controls.Add(this.buttonTOOSLW);
            this.groupBox1.Controls.Add(this.buttonDWNONE);
            this.groupBox1.Controls.Add(this.buttonDWNNUM);
            this.groupBox1.Controls.Add(this.buttonDWNLOW);
            this.groupBox1.Controls.Add(this.buttonYaACTALL);
            this.groupBox1.Controls.Add(this.buttonYaACTSEL);
            this.groupBox1.Controls.Add(this.buttonREMACTSEL);
            this.groupBox1.Controls.Add(this.buttonREMACTALL);
            this.groupBox1.Location = new System.Drawing.Point(350, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 362);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUTTONS!!!";
            // 
            // buttonEXPORD
            // 
            this.buttonEXPORD.Location = new System.Drawing.Point(110, 321);
            this.buttonEXPORD.Name = "buttonEXPORD";
            this.buttonEXPORD.Size = new System.Drawing.Size(85, 25);
            this.buttonEXPORD.TabIndex = 18;
            this.buttonEXPORD.Text = "Export Order";
            this.buttonEXPORD.UseVisualStyleBackColor = true;
            this.buttonEXPORD.Click += new System.EventHandler(this.buttonEXPORD_Click);
            // 
            // buttonIMPORD
            // 
            this.buttonIMPORD.Location = new System.Drawing.Point(5, 321);
            this.buttonIMPORD.Name = "buttonIMPORD";
            this.buttonIMPORD.Size = new System.Drawing.Size(85, 25);
            this.buttonIMPORD.TabIndex = 17;
            this.buttonIMPORD.Text = "Import Order";
            this.buttonIMPORD.UseVisualStyleBackColor = true;
            this.buttonIMPORD.Click += new System.EventHandler(this.buttonIMPORD_Click);
            // 
            // buttonSRTAUT
            // 
            this.buttonSRTAUT.Location = new System.Drawing.Point(109, 50);
            this.buttonSRTAUT.Name = "buttonSRTAUT";
            this.buttonSRTAUT.Size = new System.Drawing.Size(85, 25);
            this.buttonSRTAUT.TabIndex = 16;
            this.buttonSRTAUT.Text = "Auto-Sort";
            this.buttonSRTAUT.UseVisualStyleBackColor = true;
            this.buttonSRTAUT.Click += new System.EventHandler(this.buttonSRTAUT_Click);
            // 
            // buttonYaACTALL
            // 
            this.buttonYaACTALL.Location = new System.Drawing.Point(109, 100);
            this.buttonYaACTALL.Name = "buttonYaACTALL";
            this.buttonYaACTALL.Size = new System.Drawing.Size(85, 25);
            this.buttonYaACTALL.TabIndex = 12;
            this.buttonYaACTALL.Text = "YaACT All";
            this.buttonYaACTALL.UseVisualStyleBackColor = true;
            this.buttonYaACTALL.Click += new System.EventHandler(this.buttonYaACTALL_Click);
            // 
            // buttonYaACTSEL
            // 
            this.buttonYaACTSEL.Location = new System.Drawing.Point(109, 125);
            this.buttonYaACTSEL.Name = "buttonYaACTSEL";
            this.buttonYaACTSEL.Size = new System.Drawing.Size(85, 25);
            this.buttonYaACTSEL.TabIndex = 13;
            this.buttonYaACTSEL.Text = "YaACT Select";
            this.buttonYaACTSEL.UseVisualStyleBackColor = true;
            this.buttonYaACTSEL.Click += new System.EventHandler(this.buttonYaACTSEL_Click);
            // 
            // buttonREMACTSEL
            // 
            this.buttonREMACTSEL.Location = new System.Drawing.Point(110, 175);
            this.buttonREMACTSEL.Name = "buttonREMACTSEL";
            this.buttonREMACTSEL.Size = new System.Drawing.Size(85, 25);
            this.buttonREMACTSEL.TabIndex = 14;
            this.buttonREMACTSEL.Text = "DeACT Select";
            this.buttonREMACTSEL.UseVisualStyleBackColor = true;
            this.buttonREMACTSEL.Click += new System.EventHandler(this.buttonDeACTSEL_Click);
            // 
            // buttonREMACTALL
            // 
            this.buttonREMACTALL.Location = new System.Drawing.Point(110, 200);
            this.buttonREMACTALL.Name = "buttonREMACTALL";
            this.buttonREMACTALL.Size = new System.Drawing.Size(85, 25);
            this.buttonREMACTALL.TabIndex = 15;
            this.buttonREMACTALL.Text = "DeACT All";
            this.buttonREMACTALL.UseVisualStyleBackColor = true;
            this.buttonREMACTALL.Click += new System.EventHandler(this.buttonDeACTALL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxALL);
            this.Controls.Add(this.listBoxACT);
            this.Name = "Form1";
            this.Text = "Kilroy";
            this.Resize += new System.EventHandler(this.TheTimeHasComeAtLast);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxACT;
        private System.Windows.Forms.ListBox listBoxALL;

        private System.Windows.Forms.Button buttonMODLOD;
        private System.Windows.Forms.Button buttonMODSAV;

        private System.Windows.Forms.Button buttonUPPTOP;
        private System.Windows.Forms.Button buttonUPPNUM;
        private System.Windows.Forms.Button buttonUPPONE;

        private System.Windows.Forms.Button buttonTOOSLW;

        private System.Windows.Forms.Button buttonDWNONE;
        private System.Windows.Forms.Button buttonDWNNUM;
        private System.Windows.Forms.Button buttonDWNLOW;

        private System.Windows.Forms.Button buttonYaACTALL;
        private System.Windows.Forms.Button buttonYaACTSEL;
        private System.Windows.Forms.Button buttonREMACTSEL;
        private System.Windows.Forms.Button buttonREMACTALL;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSRTAUT;
        private System.Windows.Forms.Button buttonEXPORD;
        private System.Windows.Forms.Button buttonIMPORD;
    }
}

