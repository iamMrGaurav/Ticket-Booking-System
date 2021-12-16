
namespace CourseworkAD
{
    partial class WeeklyReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateTimeValue = new System.Windows.Forms.DateTimePicker();
            this.toDateTimeValue = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalTransactionLabel = new System.Windows.Forms.Label();
            this.groupTransactionLabel = new System.Windows.Forms.Label();
            this.childrenTransactionLabel = new System.Windows.Forms.Label();
            this.adultTransactionLabel = new System.Windows.Forms.Label();
            this.totalCountLabel = new System.Windows.Forms.Label();
            this.groupCountLabel = new System.Windows.Forms.Label();
            this.childrenCountLabel = new System.Windows.Forms.Label();
            this.adultCountLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.weeklyReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.getReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Weekly Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(313, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "To";
            // 
            // fromDateTimeValue
            // 
            this.fromDateTimeValue.Location = new System.Drawing.Point(93, 84);
            this.fromDateTimeValue.Name = "fromDateTimeValue";
            this.fromDateTimeValue.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimeValue.TabIndex = 18;
            // 
            // toDateTimeValue
            // 
            this.toDateTimeValue.Location = new System.Drawing.Point(364, 84);
            this.toDateTimeValue.Name = "toDateTimeValue";
            this.toDateTimeValue.Size = new System.Drawing.Size(205, 20);
            this.toDateTimeValue.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(72, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(340, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = ":";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.totalTransactionLabel);
            this.panel1.Controls.Add(this.groupTransactionLabel);
            this.panel1.Controls.Add(this.childrenTransactionLabel);
            this.panel1.Controls.Add(this.adultTransactionLabel);
            this.panel1.Controls.Add(this.totalCountLabel);
            this.panel1.Controls.Add(this.groupCountLabel);
            this.panel1.Controls.Add(this.childrenCountLabel);
            this.panel1.Controls.Add(this.adultCountLabel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 250);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 51);
            this.panel2.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(146, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(252, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Transaction";
            // 
            // totalTransactionLabel
            // 
            this.totalTransactionLabel.AutoSize = true;
            this.totalTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.totalTransactionLabel.Location = new System.Drawing.Point(284, 158);
            this.totalTransactionLabel.Name = "totalTransactionLabel";
            this.totalTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.totalTransactionLabel.TabIndex = 40;
            this.totalTransactionLabel.Text = "--";
            // 
            // groupTransactionLabel
            // 
            this.groupTransactionLabel.AutoSize = true;
            this.groupTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.groupTransactionLabel.Location = new System.Drawing.Point(284, 126);
            this.groupTransactionLabel.Name = "groupTransactionLabel";
            this.groupTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.groupTransactionLabel.TabIndex = 39;
            this.groupTransactionLabel.Text = "--";
            // 
            // childrenTransactionLabel
            // 
            this.childrenTransactionLabel.AutoSize = true;
            this.childrenTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childrenTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.childrenTransactionLabel.Location = new System.Drawing.Point(284, 93);
            this.childrenTransactionLabel.Name = "childrenTransactionLabel";
            this.childrenTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.childrenTransactionLabel.TabIndex = 38;
            this.childrenTransactionLabel.Text = "--";
            // 
            // adultTransactionLabel
            // 
            this.adultTransactionLabel.AutoSize = true;
            this.adultTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.adultTransactionLabel.Location = new System.Drawing.Point(284, 58);
            this.adultTransactionLabel.Name = "adultTransactionLabel";
            this.adultTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.adultTransactionLabel.TabIndex = 37;
            this.adultTransactionLabel.Text = "--";
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.AutoSize = true;
            this.totalCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCountLabel.ForeColor = System.Drawing.Color.Black;
            this.totalCountLabel.Location = new System.Drawing.Point(157, 158);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(19, 20);
            this.totalCountLabel.TabIndex = 36;
            this.totalCountLabel.Text = "--";
            // 
            // groupCountLabel
            // 
            this.groupCountLabel.AutoSize = true;
            this.groupCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCountLabel.ForeColor = System.Drawing.Color.Black;
            this.groupCountLabel.Location = new System.Drawing.Point(157, 126);
            this.groupCountLabel.Name = "groupCountLabel";
            this.groupCountLabel.Size = new System.Drawing.Size(19, 20);
            this.groupCountLabel.TabIndex = 35;
            this.groupCountLabel.Text = "--";
            // 
            // childrenCountLabel
            // 
            this.childrenCountLabel.AutoSize = true;
            this.childrenCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childrenCountLabel.ForeColor = System.Drawing.Color.Black;
            this.childrenCountLabel.Location = new System.Drawing.Point(157, 93);
            this.childrenCountLabel.Name = "childrenCountLabel";
            this.childrenCountLabel.Size = new System.Drawing.Size(19, 20);
            this.childrenCountLabel.TabIndex = 34;
            this.childrenCountLabel.Text = "--";
            // 
            // adultCountLabel
            // 
            this.adultCountLabel.AutoSize = true;
            this.adultCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultCountLabel.ForeColor = System.Drawing.Color.Black;
            this.adultCountLabel.Location = new System.Drawing.Point(157, 58);
            this.adultCountLabel.Name = "adultCountLabel";
            this.adultCountLabel.Size = new System.Drawing.Size(19, 20);
            this.adultCountLabel.TabIndex = 30;
            this.adultCountLabel.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(22, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(22, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Group";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(22, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Children";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Adult";
            // 
            // weeklyReportChart
            // 
            chartArea1.Name = "ChartArea1";
            this.weeklyReportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weeklyReportChart.Legends.Add(legend1);
            this.weeklyReportChart.Location = new System.Drawing.Point(413, 121);
            this.weeklyReportChart.Name = "weeklyReportChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.weeklyReportChart.Series.Add(series1);
            this.weeklyReportChart.Size = new System.Drawing.Size(375, 300);
            this.weeklyReportChart.TabIndex = 23;
            this.weeklyReportChart.Text = "chart1";
            // 
            // getReport
            // 
            this.getReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.getReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getReport.ForeColor = System.Drawing.Color.White;
            this.getReport.Location = new System.Drawing.Point(609, 69);
            this.getReport.Name = "getReport";
            this.getReport.Size = new System.Drawing.Size(104, 37);
            this.getReport.TabIndex = 34;
            this.getReport.Text = "Get Report";
            this.getReport.UseVisualStyleBackColor = false;
            this.getReport.Click += new System.EventHandler(this.getReport_Click);
            // 
            // WeeklyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(145)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.getReport);
            this.Controls.Add(this.weeklyReportChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDateTimeValue);
            this.Controls.Add(this.fromDateTimeValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyReportForm";
            this.Text = "WeeklyReportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDateTimeValue;
        private System.Windows.Forms.DateTimePicker toDateTimeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalTransactionLabel;
        private System.Windows.Forms.Label groupTransactionLabel;
        private System.Windows.Forms.Label childrenTransactionLabel;
        private System.Windows.Forms.Label adultTransactionLabel;
        private System.Windows.Forms.Label totalCountLabel;
        private System.Windows.Forms.Label groupCountLabel;
        private System.Windows.Forms.Label childrenCountLabel;
        private System.Windows.Forms.Label adultCountLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyReportChart;
        private System.Windows.Forms.Button getReport;
        private System.Windows.Forms.Panel panel2;
    }
}