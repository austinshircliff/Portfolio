namespace Program4
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
            this.detailsbutton = new System.Windows.Forms.Button();
            this.toULbutton = new System.Windows.Forms.Button();
            this.addpackagebutton = new System.Windows.Forms.Button();
            this.originzip = new System.Windows.Forms.Label();
            this.destinationzip = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.originziptext = new System.Windows.Forms.TextBox();
            this.destinationziptext = new System.Windows.Forms.TextBox();
            this.lengthtext = new System.Windows.Forms.TextBox();
            this.widthtext = new System.Windows.Forms.TextBox();
            this.heighttext = new System.Windows.Forms.TextBox();
            this.weighttext = new System.Windows.Forms.TextBox();
            this.packagelistbox = new System.Windows.Forms.ListBox();
            this.fromULbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detailsbutton
            // 
            this.detailsbutton.Location = new System.Drawing.Point(418, 56);
            this.detailsbutton.Name = "detailsbutton";
            this.detailsbutton.Size = new System.Drawing.Size(75, 23);
            this.detailsbutton.TabIndex = 0;
            this.detailsbutton.Text = "Details";
            this.detailsbutton.UseVisualStyleBackColor = true;
            this.detailsbutton.Click += new System.EventHandler(this.detailsbutton_Click);
            // 
            // toULbutton
            // 
            this.toULbutton.Location = new System.Drawing.Point(418, 108);
            this.toULbutton.Name = "toULbutton";
            this.toULbutton.Size = new System.Drawing.Size(75, 23);
            this.toULbutton.TabIndex = 1;
            this.toULbutton.Text = "To UofL";
            this.toULbutton.UseVisualStyleBackColor = true;
            this.toULbutton.Click += new System.EventHandler(this.toULbutton_Click);
            // 
            // addpackagebutton
            // 
            this.addpackagebutton.Location = new System.Drawing.Point(43, 211);
            this.addpackagebutton.Name = "addpackagebutton";
            this.addpackagebutton.Size = new System.Drawing.Size(175, 52);
            this.addpackagebutton.TabIndex = 2;
            this.addpackagebutton.Text = "ADD PACKAGE";
            this.addpackagebutton.UseVisualStyleBackColor = true;
            this.addpackagebutton.Click += new System.EventHandler(this.addpackagebutton_Click);
            // 
            // originzip
            // 
            this.originzip.AutoSize = true;
            this.originzip.Location = new System.Drawing.Point(40, 56);
            this.originzip.Name = "originzip";
            this.originzip.Size = new System.Drawing.Size(52, 13);
            this.originzip.TabIndex = 3;
            this.originzip.Text = "Origin Zip";
            // 
            // destinationzip
            // 
            this.destinationzip.AutoSize = true;
            this.destinationzip.Location = new System.Drawing.Point(21, 82);
            this.destinationzip.Name = "destinationzip";
            this.destinationzip.Size = new System.Drawing.Size(78, 13);
            this.destinationzip.TabIndex = 4;
            this.destinationzip.Text = "Destination Zip";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(40, 108);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(40, 13);
            this.length.TabIndex = 5;
            this.length.Text = "Length";
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(40, 134);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(35, 13);
            this.Width.TabIndex = 6;
            this.Width.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Height";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(40, 185);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(41, 13);
            this.weight.TabIndex = 8;
            this.weight.Text = "Weight";
            // 
            // originziptext
            // 
            this.originziptext.Location = new System.Drawing.Point(105, 53);
            this.originziptext.Name = "originziptext";
            this.originziptext.Size = new System.Drawing.Size(100, 20);
            this.originziptext.TabIndex = 10;
            // 
            // destinationziptext
            // 
            this.destinationziptext.Location = new System.Drawing.Point(105, 79);
            this.destinationziptext.Name = "destinationziptext";
            this.destinationziptext.Size = new System.Drawing.Size(100, 20);
            this.destinationziptext.TabIndex = 11;
            // 
            // lengthtext
            // 
            this.lengthtext.Location = new System.Drawing.Point(105, 105);
            this.lengthtext.Name = "lengthtext";
            this.lengthtext.Size = new System.Drawing.Size(100, 20);
            this.lengthtext.TabIndex = 12;
            // 
            // widthtext
            // 
            this.widthtext.Location = new System.Drawing.Point(105, 131);
            this.widthtext.Name = "widthtext";
            this.widthtext.Size = new System.Drawing.Size(100, 20);
            this.widthtext.TabIndex = 14;
            // 
            // heighttext
            // 
            this.heighttext.Location = new System.Drawing.Point(105, 156);
            this.heighttext.Name = "heighttext";
            this.heighttext.Size = new System.Drawing.Size(100, 20);
            this.heighttext.TabIndex = 15;
            // 
            // weighttext
            // 
            this.weighttext.Location = new System.Drawing.Point(105, 182);
            this.weighttext.Name = "weighttext";
            this.weighttext.Size = new System.Drawing.Size(100, 20);
            this.weighttext.TabIndex = 16;
            // 
            // packagelistbox
            // 
            this.packagelistbox.FormattingEnabled = true;
            this.packagelistbox.Location = new System.Drawing.Point(242, 51);
            this.packagelistbox.Name = "packagelistbox";
            this.packagelistbox.Size = new System.Drawing.Size(142, 147);
            this.packagelistbox.TabIndex = 17;
            // 
            // fromULbutton
            // 
            this.fromULbutton.Location = new System.Drawing.Point(418, 159);
            this.fromULbutton.Name = "fromULbutton";
            this.fromULbutton.Size = new System.Drawing.Size(75, 23);
            this.fromULbutton.TabIndex = 18;
            this.fromULbutton.Text = "From UofL";
            this.fromULbutton.UseVisualStyleBackColor = true;
            this.fromULbutton.Click += new System.EventHandler(this.fromULbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 275);
            this.Controls.Add(this.fromULbutton);
            this.Controls.Add(this.packagelistbox);
            this.Controls.Add(this.weighttext);
            this.Controls.Add(this.heighttext);
            this.Controls.Add(this.widthtext);
            this.Controls.Add(this.lengthtext);
            this.Controls.Add(this.destinationziptext);
            this.Controls.Add(this.originziptext);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.length);
            this.Controls.Add(this.destinationzip);
            this.Controls.Add(this.originzip);
            this.Controls.Add(this.addpackagebutton);
            this.Controls.Add(this.toULbutton);
            this.Controls.Add(this.detailsbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button detailsbutton;
        private System.Windows.Forms.Button toULbutton;
        private System.Windows.Forms.Button addpackagebutton;
        private System.Windows.Forms.Label originzip;
        private System.Windows.Forms.Label destinationzip;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox originziptext;
        private System.Windows.Forms.TextBox destinationziptext;
        private System.Windows.Forms.TextBox lengthtext;
        private System.Windows.Forms.TextBox widthtext;
        private System.Windows.Forms.TextBox heighttext;
        private System.Windows.Forms.TextBox weighttext;
        private System.Windows.Forms.ListBox packagelistbox;
        private System.Windows.Forms.Button fromULbutton;
    }
}

