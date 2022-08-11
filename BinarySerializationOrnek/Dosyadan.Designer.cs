namespace BinarySerializationOrnek
{
    partial class Dosyadan
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
            this.dosyadanokubutton = new System.Windows.Forms.Button();
            this.dosyayayazbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dosyadanokubutton
            // 
            this.dosyadanokubutton.Location = new System.Drawing.Point(452, 205);
            this.dosyadanokubutton.Name = "dosyadanokubutton";
            this.dosyadanokubutton.Size = new System.Drawing.Size(123, 29);
            this.dosyadanokubutton.TabIndex = 0;
            this.dosyadanokubutton.Text = "Dosyadan Oku";
            this.dosyadanokubutton.UseVisualStyleBackColor = true;
            this.dosyadanokubutton.Click += new System.EventHandler(this.dosyadanokubutton_Click);
            // 
            // dosyayayazbutton
            // 
            this.dosyayayazbutton.Location = new System.Drawing.Point(146, 205);
            this.dosyayayazbutton.Name = "dosyayayazbutton";
            this.dosyayayazbutton.Size = new System.Drawing.Size(127, 29);
            this.dosyayayazbutton.TabIndex = 1;
            this.dosyayayazbutton.Text = "Dosyaya Yaz";
            this.dosyayayazbutton.UseVisualStyleBackColor = true;
            this.dosyayayazbutton.Click += new System.EventHandler(this.dosyayayazbutton_Click);
            // 
            // Dosyadan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dosyayayazbutton);
            this.Controls.Add(this.dosyadanokubutton);
            this.Name = "Dosyadan";
            this.Text = "Dosyadan";
            this.ResumeLayout(false);

        }

        #endregion

        private Button dosyadanokubutton;
        private Button dosyayayazbutton;
    }
}