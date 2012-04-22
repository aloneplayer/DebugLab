namespace ActiveReflactorClient
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
            this.button_Active = new System.Windows.Forms.Button();
            this.button_Deactive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Active
            // 
            this.button_Active.Location = new System.Drawing.Point(37, 24);
            this.button_Active.Name = "button_Active";
            this.button_Active.Size = new System.Drawing.Size(170, 23);
            this.button_Active.TabIndex = 0;
            this.button_Active.Text = "Active";
            this.button_Active.UseVisualStyleBackColor = true;
            this.button_Active.Click += new System.EventHandler(this.button_Active_Click);
            // 
            // button_Deactive
            // 
            this.button_Deactive.Location = new System.Drawing.Point(37, 63);
            this.button_Deactive.Name = "button_Deactive";
            this.button_Deactive.Size = new System.Drawing.Size(170, 23);
            this.button_Deactive.TabIndex = 1;
            this.button_Deactive.Text = "Deactive";
            this.button_Deactive.UseVisualStyleBackColor = true;
            this.button_Deactive.Click += new System.EventHandler(this.button_Deactive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_Deactive);
            this.Controls.Add(this.button_Active);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Active;
        private System.Windows.Forms.Button button_Deactive;
    }
}

