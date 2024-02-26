
namespace TestPrototype
{
    partial class Startup
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
            this.radioButtonStandardCofig = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomConfig = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonStandardCofig
            // 
            this.radioButtonStandardCofig.AutoSize = true;
            this.radioButtonStandardCofig.Checked = true;
            this.radioButtonStandardCofig.Location = new System.Drawing.Point(35, 35);
            this.radioButtonStandardCofig.Name = "radioButtonStandardCofig";
            this.radioButtonStandardCofig.Size = new System.Drawing.Size(166, 17);
            this.radioButtonStandardCofig.TabIndex = 0;
            this.radioButtonStandardCofig.TabStop = true;
            this.radioButtonStandardCofig.Text = " &Standard SeDeM Paramaters";
            this.radioButtonStandardCofig.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomConfig
            // 
            this.radioButtonCustomConfig.AutoSize = true;
            this.radioButtonCustomConfig.Location = new System.Drawing.Point(35, 58);
            this.radioButtonCustomConfig.Name = "radioButtonCustomConfig";
            this.radioButtonCustomConfig.Size = new System.Drawing.Size(155, 17);
            this.radioButtonCustomConfig.TabIndex = 1;
            this.radioButtonCustomConfig.Text = "C&ustom SeDeM Paramaters";
            this.radioButtonCustomConfig.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(257, 28);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 31);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(257, 65);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 31);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 119);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.radioButtonCustomConfig);
            this.Controls.Add(this.radioButtonStandardCofig);
            this.Name = "Startup";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonStandardCofig;
        private System.Windows.Forms.RadioButton radioButtonCustomConfig;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}