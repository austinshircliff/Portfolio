namespace Program2
{
    partial class Program2
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
            this.juniorbutton = new System.Windows.Forms.RadioButton();
            this.seniorbutton = new System.Windows.Forms.RadioButton();
            this.sophomorebutton = new System.Windows.Forms.RadioButton();
            this.freshmanbutton = new System.Windows.Forms.RadioButton();
            this.nameentry = new System.Windows.Forms.TextBox();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.directions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // juniorbutton
            // 
            this.juniorbutton.AutoSize = true;
            this.juniorbutton.Checked = true;
            this.juniorbutton.Location = new System.Drawing.Point(103, 12);
            this.juniorbutton.Name = "juniorbutton";
            this.juniorbutton.Size = new System.Drawing.Size(53, 17);
            this.juniorbutton.TabIndex = 0;
            this.juniorbutton.TabStop = true;
            this.juniorbutton.Text = "Junior";
            this.juniorbutton.UseVisualStyleBackColor = true;
            // 
            // seniorbutton
            // 
            this.seniorbutton.AutoSize = true;
            this.seniorbutton.Location = new System.Drawing.Point(103, 57);
            this.seniorbutton.Name = "seniorbutton";
            this.seniorbutton.Size = new System.Drawing.Size(55, 17);
            this.seniorbutton.TabIndex = 1;
            this.seniorbutton.Text = "Senior";
            this.seniorbutton.UseVisualStyleBackColor = true;
            // 
            // sophomorebutton
            // 
            this.sophomorebutton.AutoSize = true;
            this.sophomorebutton.Location = new System.Drawing.Point(12, 57);
            this.sophomorebutton.Name = "sophomorebutton";
            this.sophomorebutton.Size = new System.Drawing.Size(79, 17);
            this.sophomorebutton.TabIndex = 2;
            this.sophomorebutton.Text = "Sophomore";
            this.sophomorebutton.UseVisualStyleBackColor = true;
            // 
            // freshmanbutton
            // 
            this.freshmanbutton.AutoSize = true;
            this.freshmanbutton.Location = new System.Drawing.Point(12, 12);
            this.freshmanbutton.Name = "freshmanbutton";
            this.freshmanbutton.Size = new System.Drawing.Size(71, 17);
            this.freshmanbutton.TabIndex = 3;
            this.freshmanbutton.Text = "Freshman";
            this.freshmanbutton.UseVisualStyleBackColor = true;
            // 
            // nameentry
            // 
            this.nameentry.Location = new System.Drawing.Point(31, 127);
            this.nameentry.Name = "nameentry";
            this.nameentry.Size = new System.Drawing.Size(100, 20);
            this.nameentry.TabIndex = 4;
            // 
            // calculatebutton
            // 
            this.calculatebutton.Location = new System.Drawing.Point(41, 164);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(75, 23);
            this.calculatebutton.TabIndex = 7;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // directions
            // 
            this.directions.AutoSize = true;
            this.directions.Location = new System.Drawing.Point(38, 99);
            this.directions.Name = "directions";
            this.directions.Size = new System.Drawing.Size(86, 13);
            this.directions.TabIndex = 8;
            this.directions.Text = "Enter Last Name";
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 199);
            this.Controls.Add(this.directions);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.nameentry);
            this.Controls.Add(this.freshmanbutton);
            this.Controls.Add(this.sophomorebutton);
            this.Controls.Add(this.seniorbutton);
            this.Controls.Add(this.juniorbutton);
            this.Name = "Program2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton juniorbutton;
        private System.Windows.Forms.RadioButton seniorbutton;
        private System.Windows.Forms.RadioButton sophomorebutton;
        private System.Windows.Forms.RadioButton freshmanbutton;
        private System.Windows.Forms.TextBox nameentry;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Label directions;
    }
}

