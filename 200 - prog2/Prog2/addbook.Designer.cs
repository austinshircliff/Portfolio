namespace LibraryItems
{
    partial class addbook
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
            this.addbookbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.booktitletxtbox = new System.Windows.Forms.TextBox();
            this.publishertxtbox = new System.Windows.Forms.TextBox();
            this.copytxtbox = new System.Windows.Forms.TextBox();
            this.loantxtbox = new System.Windows.Forms.TextBox();
            this.callnumtxtbox = new System.Windows.Forms.TextBox();
            this.authortxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // addbookbutton
            // 
            this.addbookbutton.Location = new System.Drawing.Point(71, 313);
            this.addbookbutton.Name = "addbookbutton";
            this.addbookbutton.Size = new System.Drawing.Size(150, 54);
            this.addbookbutton.TabIndex = 0;
            this.addbookbutton.Text = "SUBMIT";
            this.addbookbutton.UseVisualStyleBackColor = true;
            this.addbookbutton.Click += new System.EventHandler(this.addbookbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Publisher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loan Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Call Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Title";
            // 
            // booktitletxtbox
            // 
            this.booktitletxtbox.Location = new System.Drawing.Point(162, 59);
            this.booktitletxtbox.Name = "booktitletxtbox";
            this.booktitletxtbox.Size = new System.Drawing.Size(100, 20);
            this.booktitletxtbox.TabIndex = 7;
            this.booktitletxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.booktitletxtbox_Validating);
            this.booktitletxtbox.Validated += new System.EventHandler(this.booktitletxtbox_Validated);
            // 
            // publishertxtbox
            // 
            this.publishertxtbox.Location = new System.Drawing.Point(162, 95);
            this.publishertxtbox.Name = "publishertxtbox";
            this.publishertxtbox.Size = new System.Drawing.Size(100, 20);
            this.publishertxtbox.TabIndex = 8;
            this.publishertxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.publishertxtbox_Validating);
            this.publishertxtbox.Validated += new System.EventHandler(this.publishertxtbox_Validated);
            // 
            // copytxtbox
            // 
            this.copytxtbox.Location = new System.Drawing.Point(162, 133);
            this.copytxtbox.Name = "copytxtbox";
            this.copytxtbox.Size = new System.Drawing.Size(100, 20);
            this.copytxtbox.TabIndex = 9;
            this.copytxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.copytxtbox_Validating);
            this.copytxtbox.Validated += new System.EventHandler(this.copytxtbox_Validated);
            // 
            // loantxtbox
            // 
            this.loantxtbox.Location = new System.Drawing.Point(162, 174);
            this.loantxtbox.Name = "loantxtbox";
            this.loantxtbox.Size = new System.Drawing.Size(100, 20);
            this.loantxtbox.TabIndex = 10;
            this.loantxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.loantxtbox_Validating);
            this.loantxtbox.Validated += new System.EventHandler(this.loantxtbox_Validated);
            // 
            // callnumtxtbox
            // 
            this.callnumtxtbox.Location = new System.Drawing.Point(162, 214);
            this.callnumtxtbox.Name = "callnumtxtbox";
            this.callnumtxtbox.Size = new System.Drawing.Size(100, 20);
            this.callnumtxtbox.TabIndex = 11;
            this.callnumtxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.callnumtxtbox_Validating);
            this.callnumtxtbox.Validated += new System.EventHandler(this.callnumtxtbox_Validated);
            // 
            // authortxtbox
            // 
            this.authortxtbox.Location = new System.Drawing.Point(162, 260);
            this.authortxtbox.Name = "authortxtbox";
            this.authortxtbox.Size = new System.Drawing.Size(100, 20);
            this.authortxtbox.TabIndex = 12;
            this.authortxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.authortxtbox_Validating);
            this.authortxtbox.Validated += new System.EventHandler(this.authortxtbox_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(100, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add Library Book";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 391);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.authortxtbox);
            this.Controls.Add(this.callnumtxtbox);
            this.Controls.Add(this.loantxtbox);
            this.Controls.Add(this.copytxtbox);
            this.Controls.Add(this.publishertxtbox);
            this.Controls.Add(this.booktitletxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbookbutton);
            this.Name = "addbook";
            this.Text = "addbook";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbookbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox booktitletxtbox;
        private System.Windows.Forms.TextBox publishertxtbox;
        private System.Windows.Forms.TextBox copytxtbox;
        private System.Windows.Forms.TextBox loantxtbox;
        private System.Windows.Forms.TextBox callnumtxtbox;
        private System.Windows.Forms.TextBox authortxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}