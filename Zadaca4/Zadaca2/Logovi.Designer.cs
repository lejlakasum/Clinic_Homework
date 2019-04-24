namespace Zadaca2
{
    partial class Logovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logovi));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_POC = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_KRAJ = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Prikazi = new System.Windows.Forms.Button();
            this.button_Zatvori = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(139, 32);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Prikaži sve izuzetke";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sve",
            "Rad sa datotekama",
            "Rad sa bazom",
            "Rad sa UI kontrolama"});
            this.comboBox1.Location = new System.Drawing.Point(18, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odabir kategorije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pocetni datum";
            // 
            // dateTimePicker_POC
            // 
            this.dateTimePicker_POC.Location = new System.Drawing.Point(18, 156);
            this.dateTimePicker_POC.Name = "dateTimePicker_POC";
            this.dateTimePicker_POC.Size = new System.Drawing.Size(291, 27);
            this.dateTimePicker_POC.TabIndex = 4;
            // 
            // dateTimePicker_KRAJ
            // 
            this.dateTimePicker_KRAJ.Location = new System.Drawing.Point(18, 241);
            this.dateTimePicker_KRAJ.Name = "dateTimePicker_KRAJ";
            this.dateTimePicker_KRAJ.Size = new System.Drawing.Size(291, 27);
            this.dateTimePicker_KRAJ.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Krajnji datum";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_KRAJ);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker_POC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 303);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // button_Prikazi
            // 
            this.button_Prikazi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Prikazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Prikazi.Location = new System.Drawing.Point(81, 428);
            this.button_Prikazi.Name = "button_Prikazi";
            this.button_Prikazi.Size = new System.Drawing.Size(116, 39);
            this.button_Prikazi.TabIndex = 8;
            this.button_Prikazi.Text = "Prikaži";
            this.button_Prikazi.UseVisualStyleBackColor = false;
            this.button_Prikazi.Click += new System.EventHandler(this.button_Prikazi_Click);
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Zatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zatvori.Location = new System.Drawing.Point(246, 428);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(116, 39);
            this.button_Zatvori.TabIndex = 9;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = false;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(542, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(554, 435);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Logovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 527);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_Prikazi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Logovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logovi";
            this.Load += new System.EventHandler(this.Logovi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_POC;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KRAJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Prikazi;
        private System.Windows.Forms.Button button_Zatvori;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}