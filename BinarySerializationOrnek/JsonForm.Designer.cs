namespace BinarySerializationOrnek
{
    partial class JsonForm
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
            this.jsonserbutton = new System.Windows.Forms.Button();
            this.jsonserlabel = new System.Windows.Forms.Label();
            this.jsondeserbutton = new System.Windows.Forms.Button();
            this.jsondeserlabel = new System.Windows.Forms.Label();
            this.jsonserfilebutton = new System.Windows.Forms.Button();
            this.jsondeserfilebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jsonserbutton
            // 
            this.jsonserbutton.Location = new System.Drawing.Point(164, 122);
            this.jsonserbutton.Name = "jsonserbutton";
            this.jsonserbutton.Size = new System.Drawing.Size(94, 29);
            this.jsonserbutton.TabIndex = 0;
            this.jsonserbutton.Text = "Json Ser.";
            this.jsonserbutton.UseVisualStyleBackColor = true;
            this.jsonserbutton.Click += new System.EventHandler(this.jsonserbutton_Click);
            // 
            // jsonserlabel
            // 
            this.jsonserlabel.AutoSize = true;
            this.jsonserlabel.Location = new System.Drawing.Point(164, 183);
            this.jsonserlabel.Name = "jsonserlabel";
            this.jsonserlabel.Size = new System.Drawing.Size(50, 20);
            this.jsonserlabel.TabIndex = 1;
            this.jsonserlabel.Text = "label1";
            this.jsonserlabel.Visible = false;
            // 
            // jsondeserbutton
            // 
            this.jsondeserbutton.Location = new System.Drawing.Point(459, 122);
            this.jsondeserbutton.Name = "jsondeserbutton";
            this.jsondeserbutton.Size = new System.Drawing.Size(94, 29);
            this.jsondeserbutton.TabIndex = 2;
            this.jsondeserbutton.Text = "Json DeSer.";
            this.jsondeserbutton.UseVisualStyleBackColor = true;
            this.jsondeserbutton.Click += new System.EventHandler(this.jsondeserbutton_Click);
            // 
            // jsondeserlabel
            // 
            this.jsondeserlabel.AutoSize = true;
            this.jsondeserlabel.Location = new System.Drawing.Point(459, 183);
            this.jsondeserlabel.Name = "jsondeserlabel";
            this.jsondeserlabel.Size = new System.Drawing.Size(50, 20);
            this.jsondeserlabel.TabIndex = 3;
            this.jsondeserlabel.Text = "label1";
            this.jsondeserlabel.Visible = false;
            // 
            // jsonserfilebutton
            // 
            this.jsonserfilebutton.Location = new System.Drawing.Point(173, 293);
            this.jsonserfilebutton.Name = "jsonserfilebutton";
            this.jsonserfilebutton.Size = new System.Drawing.Size(94, 29);
            this.jsonserfilebutton.TabIndex = 4;
            this.jsonserfilebutton.Text = "Json Ser File";
            this.jsonserfilebutton.UseVisualStyleBackColor = true;
            this.jsonserfilebutton.Click += new System.EventHandler(this.jsonserfilebutton_Click);
            // 
            // jsondeserfilebutton
            // 
            this.jsondeserfilebutton.Location = new System.Drawing.Point(490, 293);
            this.jsondeserfilebutton.Name = "jsondeserfilebutton";
            this.jsondeserfilebutton.Size = new System.Drawing.Size(94, 29);
            this.jsondeserfilebutton.TabIndex = 5;
            this.jsondeserfilebutton.Text = "Json DeSer File";
            this.jsondeserfilebutton.UseVisualStyleBackColor = true;
            this.jsondeserfilebutton.Click += new System.EventHandler(this.jsondeserfilebutton_Click);
            // 
            // JsonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jsondeserfilebutton);
            this.Controls.Add(this.jsonserfilebutton);
            this.Controls.Add(this.jsondeserlabel);
            this.Controls.Add(this.jsondeserbutton);
            this.Controls.Add(this.jsonserlabel);
            this.Controls.Add(this.jsonserbutton);
            this.Name = "JsonForm";
            this.Text = "JsonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button jsonserbutton;
        private Label jsonserlabel;
        private Button jsondeserbutton;
        private Label jsondeserlabel;
        private Button jsonserfilebutton;
        private Button jsondeserfilebutton;
    }
}