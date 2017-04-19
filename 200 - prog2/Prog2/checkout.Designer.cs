namespace LibraryItems
{
    partial class checkout
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
            this.checkoutbutton = new System.Windows.Forms.Button();
            this.patroncombobox = new System.Windows.Forms.ComboBox();
            this.itemcombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.Location = new System.Drawing.Point(134, 204);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(133, 57);
            this.checkoutbutton.TabIndex = 0;
            this.checkoutbutton.Text = "Checkout Item";
            this.checkoutbutton.UseVisualStyleBackColor = true;
            this.checkoutbutton.Click += new System.EventHandler(this.checkoutbutton_Click);
            // 
            // patroncombobox
            // 
            this.patroncombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patroncombobox.FormattingEnabled = true;
            this.patroncombobox.Location = new System.Drawing.Point(134, 124);
            this.patroncombobox.Name = "patroncombobox";
            this.patroncombobox.Size = new System.Drawing.Size(220, 21);
            this.patroncombobox.TabIndex = 1;
            this.patroncombobox.Validating += new System.ComponentModel.CancelEventHandler(this.patroncombobox_Validating);
            this.patroncombobox.Validated += new System.EventHandler(this.patroncombobox_Validated);
            // 
            // itemcombobox
            // 
            this.itemcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemcombobox.FormattingEnabled = true;
            this.itemcombobox.Location = new System.Drawing.Point(134, 60);
            this.itemcombobox.Name = "itemcombobox";
            this.itemcombobox.Size = new System.Drawing.Size(220, 21);
            this.itemcombobox.TabIndex = 2;
            this.itemcombobox.Validating += new System.ComponentModel.CancelEventHandler(this.itemcombobox_Validating);
            this.itemcombobox.Validated += new System.EventHandler(this.itemcombobox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PATRON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ITEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(156, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "CHECKOUT";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 273);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemcombobox);
            this.Controls.Add(this.patroncombobox);
            this.Controls.Add(this.checkoutbutton);
            this.Name = "checkout";
            this.Text = "checkout";
            this.Load += new System.EventHandler(this.checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkoutbutton;
        private System.Windows.Forms.ComboBox patroncombobox;
        private System.Windows.Forms.ComboBox itemcombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}