namespace WindowsFormsApp1
{
    partial class mainForm
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
            this.inputTXT = new System.Windows.Forms.TextBox();
            this.pigLRadio = new System.Windows.Forms.RadioButton();
            this.pigGRadio = new System.Windows.Forms.RadioButton();
            this.outputTXT = new System.Windows.Forms.TextBox();
            this.LBLOutText = new System.Windows.Forms.Label();
            this.translateBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter English text here:";
            // 
            // inputTXT
            // 
            this.inputTXT.Location = new System.Drawing.Point(16, 41);
            this.inputTXT.Multiline = true;
            this.inputTXT.Name = "inputTXT";
            this.inputTXT.Size = new System.Drawing.Size(299, 156);
            this.inputTXT.TabIndex = 1;
            // 
            // pigLRadio
            // 
            this.pigLRadio.AutoSize = true;
            this.pigLRadio.Location = new System.Drawing.Point(16, 204);
            this.pigLRadio.Name = "pigLRadio";
            this.pigLRadio.Size = new System.Drawing.Size(66, 17);
            this.pigLRadio.TabIndex = 2;
            this.pigLRadio.TabStop = true;
            this.pigLRadio.Text = "Pig Latin";
            this.pigLRadio.UseVisualStyleBackColor = true;
            this.pigLRadio.CheckedChanged += new System.EventHandler(this.pigLRadio_CheckedChanged);
            // 
            // pigGRadio
            // 
            this.pigGRadio.AutoSize = true;
            this.pigGRadio.Location = new System.Drawing.Point(107, 204);
            this.pigGRadio.Name = "pigGRadio";
            this.pigGRadio.Size = new System.Drawing.Size(72, 17);
            this.pigGRadio.TabIndex = 3;
            this.pigGRadio.TabStop = true;
            this.pigGRadio.Text = "Pig Greek";
            this.pigGRadio.UseVisualStyleBackColor = true;
            this.pigGRadio.CheckedChanged += new System.EventHandler(this.pigGRadio_CheckedChanged);
            // 
            // outputTXT
            // 
            this.outputTXT.Location = new System.Drawing.Point(16, 252);
            this.outputTXT.Multiline = true;
            this.outputTXT.Name = "outputTXT";
            this.outputTXT.Size = new System.Drawing.Size(299, 156);
            this.outputTXT.TabIndex = 5;
            // 
            // LBLOutText
            // 
            this.LBLOutText.AutoSize = true;
            this.LBLOutText.Location = new System.Drawing.Point(13, 224);
            this.LBLOutText.Name = "LBLOutText";
            this.LBLOutText.Size = new System.Drawing.Size(106, 13);
            this.LBLOutText.TabIndex = 4;
            this.LBLOutText.Text = "Pig Latin Translation:";
            // 
            // translateBTN
            // 
            this.translateBTN.Location = new System.Drawing.Point(16, 415);
            this.translateBTN.Name = "translateBTN";
            this.translateBTN.Size = new System.Drawing.Size(75, 23);
            this.translateBTN.TabIndex = 6;
            this.translateBTN.Text = "Translate";
            this.translateBTN.UseVisualStyleBackColor = true;
            this.translateBTN.Click += new System.EventHandler(this.translateBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(97, 414);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 7;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBTN.Location = new System.Drawing.Point(240, 415);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 8;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.translateBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBTN;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.translateBTN);
            this.Controls.Add(this.outputTXT);
            this.Controls.Add(this.LBLOutText);
            this.Controls.Add(this.pigGRadio);
            this.Controls.Add(this.pigLRadio);
            this.Controls.Add(this.inputTXT);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Pig Latin & Greek Translator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Enter += new System.EventHandler(this.translateBTN_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTXT;
        private System.Windows.Forms.RadioButton pigLRadio;
        private System.Windows.Forms.RadioButton pigGRadio;
        private System.Windows.Forms.TextBox outputTXT;
        private System.Windows.Forms.Label LBLOutText;
        private System.Windows.Forms.Button translateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}

