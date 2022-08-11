namespace BinarySerializationOrnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Adlabel = new System.Windows.Forms.Label();
            this.AdtextBox = new System.Windows.Forms.TextBox();
            this.Telefonlabel = new System.Windows.Forms.Label();
            this.telefontextBox = new System.Windows.Forms.TextBox();
            this.Dogumtarihilabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.departmanlabel = new System.Windows.Forms.Label();
            this.departmantextBox = new System.Windows.Forms.TextBox();
            this.maaslabel = new System.Windows.Forms.Label();
            this.maastextBox = new System.Windows.Forms.TextBox();
            this.serializedbutton = new System.Windows.Forms.Button();
            this.Sonuclabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adlabel
            // 
            this.Adlabel.AutoSize = true;
            this.Adlabel.Location = new System.Drawing.Point(43, 30);
            this.Adlabel.Name = "Adlabel";
            this.Adlabel.Size = new System.Drawing.Size(31, 20);
            this.Adlabel.TabIndex = 0;
            this.Adlabel.Text = "Ad:";
            // 
            // AdtextBox
            // 
            this.AdtextBox.Location = new System.Drawing.Point(202, 27);
            this.AdtextBox.Name = "AdtextBox";
            this.AdtextBox.Size = new System.Drawing.Size(200, 27);
            this.AdtextBox.TabIndex = 1;
            // 
            // Telefonlabel
            // 
            this.Telefonlabel.AutoSize = true;
            this.Telefonlabel.Location = new System.Drawing.Point(43, 85);
            this.Telefonlabel.Name = "Telefonlabel";
            this.Telefonlabel.Size = new System.Drawing.Size(61, 20);
            this.Telefonlabel.TabIndex = 2;
            this.Telefonlabel.Text = "Telefon:";
            // 
            // telefontextBox
            // 
            this.telefontextBox.Location = new System.Drawing.Point(202, 82);
            this.telefontextBox.Name = "telefontextBox";
            this.telefontextBox.Size = new System.Drawing.Size(200, 27);
            this.telefontextBox.TabIndex = 3;
            // 
            // Dogumtarihilabel
            // 
            this.Dogumtarihilabel.AutoSize = true;
            this.Dogumtarihilabel.Location = new System.Drawing.Point(43, 150);
            this.Dogumtarihilabel.Name = "Dogumtarihilabel";
            this.Dogumtarihilabel.Size = new System.Drawing.Size(101, 20);
            this.Dogumtarihilabel.TabIndex = 5;
            this.Dogumtarihilabel.Text = "Doğum Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // departmanlabel
            // 
            this.departmanlabel.AutoSize = true;
            this.departmanlabel.Location = new System.Drawing.Point(43, 208);
            this.departmanlabel.Name = "departmanlabel";
            this.departmanlabel.Size = new System.Drawing.Size(91, 20);
            this.departmanlabel.TabIndex = 7;
            this.departmanlabel.Text = "Departmani:";
            // 
            // departmantextBox
            // 
            this.departmantextBox.Location = new System.Drawing.Point(202, 201);
            this.departmantextBox.Name = "departmantextBox";
            this.departmantextBox.Size = new System.Drawing.Size(200, 27);
            this.departmantextBox.TabIndex = 8;
            // 
            // maaslabel
            // 
            this.maaslabel.AutoSize = true;
            this.maaslabel.Location = new System.Drawing.Point(43, 270);
            this.maaslabel.Name = "maaslabel";
            this.maaslabel.Size = new System.Drawing.Size(47, 20);
            this.maaslabel.TabIndex = 9;
            this.maaslabel.Text = "Maaş:";
            // 
            // maastextBox
            // 
            this.maastextBox.Location = new System.Drawing.Point(202, 263);
            this.maastextBox.Name = "maastextBox";
            this.maastextBox.Size = new System.Drawing.Size(200, 27);
            this.maastextBox.TabIndex = 10;
            // 
            // serializedbutton
            // 
            this.serializedbutton.Location = new System.Drawing.Point(110, 344);
            this.serializedbutton.Name = "serializedbutton";
            this.serializedbutton.Size = new System.Drawing.Size(154, 29);
            this.serializedbutton.TabIndex = 11;
            this.serializedbutton.Text = "Serialized";
            this.serializedbutton.UseVisualStyleBackColor = true;
            this.serializedbutton.Click += new System.EventHandler(this.serializedbutton_Click);
            // 
            // Sonuclabel
            // 
            this.Sonuclabel.AutoSize = true;
            this.Sonuclabel.Location = new System.Drawing.Point(502, 33);
            this.Sonuclabel.Name = "Sonuclabel";
            this.Sonuclabel.Size = new System.Drawing.Size(50, 20);
            this.Sonuclabel.TabIndex = 12;
            this.Sonuclabel.Text = "label1";
            this.Sonuclabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sonuclabel);
            this.Controls.Add(this.serializedbutton);
            this.Controls.Add(this.maastextBox);
            this.Controls.Add(this.maaslabel);
            this.Controls.Add(this.departmantextBox);
            this.Controls.Add(this.departmanlabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dogumtarihilabel);
            this.Controls.Add(this.telefontextBox);
            this.Controls.Add(this.Telefonlabel);
            this.Controls.Add(this.AdtextBox);
            this.Controls.Add(this.Adlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Adlabel;
        private TextBox AdtextBox;
        private Label Telefonlabel;
        private TextBox telefontextBox;
        private Label Dogumtarihilabel;
        private DateTimePicker dateTimePicker1;
        private Label departmanlabel;
        private TextBox departmantextBox;
        private Label maaslabel;
        private TextBox maastextBox;
        private Button serializedbutton;
        private Label Sonuclabel;
    }
}