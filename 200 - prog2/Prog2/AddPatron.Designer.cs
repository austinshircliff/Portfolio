namespace LibraryItems
{
    partial class AddPatron
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
            this.components = new System.ComponentModel.Container();
            this.addpatronbutton = new System.Windows.Forms.Button();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.idnumtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // addpatronbutton
            // 
            this.addpatronbutton.Location = new System.Drawing.Point(53, 126);
            this.addpatronbutton.Name = "addpatronbutton";
            this.addpatronbutton.Size = new System.Drawing.Size(75, 23);
            this.addpatronbutton.TabIndex = 0;
            this.addpatronbutton.Text = "SUBMIT";
            this.addpatronbutton.UseVisualStyleBackColor = true;
            this.addpatronbutton.Click += new System.EventHandler(this.addpatronbutton_Click);
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(77, 49);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 20);
            this.nametxtbox.TabIndex = 1;
            this.nametxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.nametxtbox_Validating);
            this.nametxtbox.Validated += new System.EventHandler(this.nametxtbox_Validated);
            // 
            // idnumtxtbox
            // 
            this.idnumtxtbox.Location = new System.Drawing.Point(77, 87);
            this.idnumtxtbox.Name = "idnumtxtbox";
            this.idnumtxtbox.Size = new System.Drawing.Size(100, 20);
            this.idnumtxtbox.TabIndex = 2;
            this.idnumtxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.idnumtxtbox_Validating);
            this.idnumtxtbox.Validated += new System.EventHandler(this.idnumtxtbox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(50, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ADD PATRON";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idnumtxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.addpatronbutton);
            this.Name = "AddPatron";
            this.Text = "AddPatron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addpatronbutton;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox idnumtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}