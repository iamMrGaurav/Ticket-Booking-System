
namespace CourseworkAD
{
    partial class HomePage
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
            this.ticketRateButton = new System.Windows.Forms.CheckBox();
            this.viewRecordButton = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketRateButton
            // 
            this.ticketRateButton.AutoSize = true;
            this.ticketRateButton.Location = new System.Drawing.Point(265, 34);
            this.ticketRateButton.Name = "ticketRateButton";
            this.ticketRateButton.Size = new System.Drawing.Size(108, 17);
            this.ticketRateButton.TabIndex = 0;
            this.ticketRateButton.Text = "View Ticket Rate";
            this.ticketRateButton.UseVisualStyleBackColor = true;
            this.ticketRateButton.CheckedChanged += new System.EventHandler(this.ticketRateButton_CheckedChanged);
            // 
            // viewRecordButton
            // 
            this.viewRecordButton.AutoSize = true;
            this.viewRecordButton.Location = new System.Drawing.Point(414, 34);
            this.viewRecordButton.Name = "viewRecordButton";
            this.viewRecordButton.Size = new System.Drawing.Size(61, 17);
            this.viewRecordButton.TabIndex = 1;
            this.viewRecordButton.Text = "Record";
            this.viewRecordButton.UseVisualStyleBackColor = true;
            this.viewRecordButton.CheckedChanged += new System.EventHandler(this.viewRecordButton_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 86);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(719, 255);
            this.dataGridView.TabIndex = 2;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.viewRecordButton);
            this.Controls.Add(this.ticketRateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ticketRateButton;
        private System.Windows.Forms.CheckBox viewRecordButton;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}