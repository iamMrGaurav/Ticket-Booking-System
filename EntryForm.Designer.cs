
namespace CourseworkAD
{
    partial class EntryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idNumericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.countNumericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.typeValue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(148, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 288);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // idNumericUpDownValue
            // 
            this.idNumericUpDownValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumericUpDownValue.Location = new System.Drawing.Point(198, 73);
            this.idNumericUpDownValue.Name = "idNumericUpDownValue";
            this.idNumericUpDownValue.Size = new System.Drawing.Size(66, 22);
            this.idNumericUpDownValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(478, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count";
            // 
            // countNumericUpDownValue
            // 
            this.countNumericUpDownValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countNumericUpDownValue.Location = new System.Drawing.Point(572, 75);
            this.countNumericUpDownValue.Name = "countNumericUpDownValue";
            this.countNumericUpDownValue.Size = new System.Drawing.Size(66, 22);
            this.countNumericUpDownValue.TabIndex = 5;
            this.countNumericUpDownValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // typeValue
            // 
            this.typeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeValue.FormattingEnabled = true;
            this.typeValue.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group",
            "Staff"});
            this.typeValue.Location = new System.Drawing.Point(376, 70);
            this.typeValue.Name = "typeValue";
            this.typeValue.Size = new System.Drawing.Size(73, 28);
            this.typeValue.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entry Form";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(685, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeValue);
            this.Controls.Add(this.countNumericUpDownValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idNumericUpDownValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown idNumericUpDownValue;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown countNumericUpDownValue;
        private System.Windows.Forms.ComboBox typeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}