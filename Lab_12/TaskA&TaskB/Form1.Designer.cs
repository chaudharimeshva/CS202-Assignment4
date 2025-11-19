namespace EventPlayground
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnChangeText;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ComboBox comboBoxColors;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnChangeText = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();

            this.SuspendLayout();
            
            // btnChangeColor
            this.btnChangeColor.Location = new System.Drawing.Point(30, 150);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(120, 35);
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);

            // btnChangeText
            this.btnChangeText.Location = new System.Drawing.Point(180, 150);
            this.btnChangeText.Name = "btnChangeText";
            this.btnChangeText.Size = new System.Drawing.Size(120, 35);
            this.btnChangeText.Text = "Change Text";
            this.btnChangeText.UseVisualStyleBackColor = true;
            this.btnChangeText.Click += new System.EventHandler(this.btnChangeText_Click);

            // lblDisplay
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDisplay.Location = new System.Drawing.Point(30, 30);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(224, 22);
            this.lblDisplay.Text = "Welcome to Events Lab";

            // comboBoxColors
            this.comboBoxColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Location = new System.Drawing.Point(30, 90);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(150, 23);

            // Form1
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.btnChangeText);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.comboBoxColors);
            this.Name = "Form1";
            this.Text = "Event Playground";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

