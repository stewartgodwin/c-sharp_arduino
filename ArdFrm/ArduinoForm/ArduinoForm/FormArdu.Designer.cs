namespace ArduinoForm
{
    partial class ArduForm
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
            this.BtnRedOn = new System.Windows.Forms.Button();
            this.BtnRedOff = new System.Windows.Forms.Button();
            this.BtnBlueLED = new System.Windows.Forms.Button();
            this.BtnBuzzer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRedOn
            // 
            this.BtnRedOn.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnRedOn.Location = new System.Drawing.Point(64, 52);
            this.BtnRedOn.Name = "BtnRedOn";
            this.BtnRedOn.Size = new System.Drawing.Size(124, 40);
            this.BtnRedOn.TabIndex = 0;
            this.BtnRedOn.Text = "Turn On Red LED";
            this.BtnRedOn.UseVisualStyleBackColor = false;
            this.BtnRedOn.Click += new System.EventHandler(this.BtnRedOn_Click);
            // 
            // BtnRedOff
            // 
            this.BtnRedOff.BackColor = System.Drawing.Color.Snow;
            this.BtnRedOff.Location = new System.Drawing.Point(194, 52);
            this.BtnRedOff.Name = "BtnRedOff";
            this.BtnRedOff.Size = new System.Drawing.Size(122, 40);
            this.BtnRedOff.TabIndex = 1;
            this.BtnRedOff.Text = "Turn Off Red LED";
            this.BtnRedOff.UseVisualStyleBackColor = false;
            this.BtnRedOff.Click += new System.EventHandler(this.BtnRedOff_Click);
            // 
            // BtnBlueLED
            // 
            this.BtnBlueLED.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBlueLED.Location = new System.Drawing.Point(64, 98);
            this.BtnBlueLED.Name = "BtnBlueLED";
            this.BtnBlueLED.Size = new System.Drawing.Size(124, 38);
            this.BtnBlueLED.TabIndex = 2;
            this.BtnBlueLED.Text = "Blue LED toggle";
            this.BtnBlueLED.UseVisualStyleBackColor = false;
            this.BtnBlueLED.Click += new System.EventHandler(this.BtnBlueLED_Click);
            // 
            // BtnBuzzer
            // 
            this.BtnBuzzer.Location = new System.Drawing.Point(64, 142);
            this.BtnBuzzer.Name = "BtnBuzzer";
            this.BtnBuzzer.Size = new System.Drawing.Size(124, 39);
            this.BtnBuzzer.TabIndex = 3;
            this.BtnBuzzer.Text = "Buzzer";
            this.BtnBuzzer.UseVisualStyleBackColor = true;
            this.BtnBuzzer.Click += new System.EventHandler(this.BtnBuzzer_Click);
            // 
            // ArduForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 223);
            this.Controls.Add(this.BtnBuzzer);
            this.Controls.Add(this.BtnBlueLED);
            this.Controls.Add(this.BtnRedOff);
            this.Controls.Add(this.BtnRedOn);
            this.Name = "ArduForm";
            this.Text = "Arduino Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRedOn;
        private System.Windows.Forms.Button BtnRedOff;
        private System.Windows.Forms.Button BtnBlueLED;
        private System.Windows.Forms.Button BtnBuzzer;
    }
}

