namespace TravelGuide
{
    partial class GuideForm
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.listBox_Continent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(268, 23);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(85, 22);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(576, 468);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_OnExit);
            // 
            // listBox_Continent
            // 
            this.listBox_Continent.FormattingEnabled = true;
            this.listBox_Continent.Location = new System.Drawing.Point(34, 62);
            this.listBox_Continent.Name = "listBox_Continent";
            this.listBox_Continent.Size = new System.Drawing.Size(120, 225);
            this.listBox_Continent.TabIndex = 2;
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 503);
            this.Controls.Add(this.listBox_Continent);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.labelWelcome);
            this.Name = "GuideForm";
            this.Text = "Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.ListBox listBox_Continent;
    }
}