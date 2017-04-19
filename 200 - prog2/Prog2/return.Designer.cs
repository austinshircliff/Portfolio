namespace LibraryItems
{
    partial class @return
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
            this.returnbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.returncombobox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnbutton
            // 
            this.returnbutton.Location = new System.Drawing.Point(80, 189);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(121, 46);
            this.returnbutton.TabIndex = 0;
            this.returnbutton.Text = "Return Item";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(105, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Return Item";
            // 
            // returncombobox
            // 
            this.returncombobox.FormattingEnabled = true;
            this.returncombobox.Location = new System.Drawing.Point(48, 106);
            this.returncombobox.Name = "returncombobox";
            this.returncombobox.Size = new System.Drawing.Size(198, 21);
            this.returncombobox.TabIndex = 2;
            this.returncombobox.Validating += new System.ComponentModel.CancelEventHandler(this.returncombobox_Validating);
            this.returncombobox.Validated += new System.EventHandler(this.returncombobox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // @return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.returncombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnbutton);
            this.Name = "@return";
            this.Text = "@return";
            this.Load += new System.EventHandler(this.return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox returncombobox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}