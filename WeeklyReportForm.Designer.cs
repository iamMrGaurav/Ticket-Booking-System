
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateTimeValue = new System.Windows.Forms.DateTimePicker();
            this.toDateTimeValue = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saturdayTransactionLabel = new System.Windows.Forms.Label();
            this.saturdayCountLabel = new System.Windows.Forms.Label();
            this.fridayTransactionLabel = new System.Windows.Forms.Label();
            this.fridayCountLabel = new System.Windows.Forms.Label();
            this.thursdayTransactionLabel = new System.Windows.Forms.Label();
            this.thursdayCountLabel = new System.Windows.Forms.Label();
            this.wednesdayTransactionLabel = new System.Windows.Forms.Label();
            this.wednesdayCountLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tuesdayTransactionLabel = new System.Windows.Forms.Label();
            this.mondayTransactionLabel = new System.Windows.Forms.Label();
            this.sundayTransactionLabel = new System.Windows.Forms.Label();
            this.tuesdayCountLabel = new System.Windows.Forms.Label();
            this.mondayCountLabel = new System.Windows.Forms.Label();
            this.sundayCountLabel = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "To";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fromDateTimeValue
            // 
            this.fromDateTimeValue.Location = new System.Drawing.Point(76, 63);
            this.fromDateTimeValue.Name = "fromDateTimeValue";
            this.fromDateTimeValue.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimeValue.TabIndex = 18;
            this.fromDateTimeValue.ValueChanged += new System.EventHandler(this.fromDateTimeValue_ValueChanged);
            // 
            // toDateTimeValue
            // 
            this.toDateTimeValue.Location = new System.Drawing.Point(76, 89);
            this.toDateTimeValue.Name = "toDateTimeValue";
            this.toDateTimeValue.Size = new System.Drawing.Size(200, 20);
            this.toDateTimeValue.TabIndex = 19;
            this.toDateTimeValue.ValueChanged += new System.EventHandler(this.toDateTimeValue_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(55, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = ":";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(55, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = ":";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.saturdayTransactionLabel);
            this.panel1.Controls.Add(this.saturdayCountLabel);
            this.panel1.Controls.Add(this.fridayTransactionLabel);
            this.panel1.Controls.Add(this.fridayCountLabel);
            this.panel1.Controls.Add(this.thursdayTransactionLabel);
            this.panel1.Controls.Add(this.thursdayCountLabel);
            this.panel1.Controls.Add(this.wednesdayTransactionLabel);
            this.panel1.Controls.Add(this.wednesdayCountLabel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tuesdayTransactionLabel);
            this.panel1.Controls.Add(this.mondayTransactionLabel);
            this.panel1.Controls.Add(this.sundayTransactionLabel);
            this.panel1.Controls.Add(this.tuesdayCountLabel);
            this.panel1.Controls.Add(this.mondayCountLabel);
            this.panel1.Controls.Add(this.sundayCountLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(21, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 266);
            this.panel1.TabIndex = 22;
            // 
            // saturdayTransactionLabel
            // 
            this.saturdayTransactionLabel.AutoSize = true;
            this.saturdayTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.saturdayTransactionLabel.Location = new System.Drawing.Point(284, 236);
            this.saturdayTransactionLabel.Name = "saturdayTransactionLabel";
            this.saturdayTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.saturdayTransactionLabel.TabIndex = 53;
            this.saturdayTransactionLabel.Text = "--";
            // 
            // saturdayCountLabel
            // 
            this.saturdayCountLabel.AutoSize = true;
            this.saturdayCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayCountLabel.ForeColor = System.Drawing.Color.Black;
            this.saturdayCountLabel.Location = new System.Drawing.Point(157, 237);
            this.saturdayCountLabel.Name = "saturdayCountLabel";
            this.saturdayCountLabel.Size = new System.Drawing.Size(19, 20);
            this.saturdayCountLabel.TabIndex = 52;
            this.saturdayCountLabel.Text = "--";
            // 
            // fridayTransactionLabel
            // 
            this.fridayTransactionLabel.AutoSize = true;
            this.fridayTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.fridayTransactionLabel.Location = new System.Drawing.Point(284, 210);
            this.fridayTransactionLabel.Name = "fridayTransactionLabel";
            this.fridayTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.fridayTransactionLabel.TabIndex = 51;
            this.fridayTransactionLabel.Text = "--";
            // 
            // fridayCountLabel
            // 
            this.fridayCountLabel.AutoSize = true;
            this.fridayCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayCountLabel.ForeColor = System.Drawing.Color.Black;
            this.fridayCountLabel.Location = new System.Drawing.Point(157, 210);
            this.fridayCountLabel.Name = "fridayCountLabel";
            this.fridayCountLabel.Size = new System.Drawing.Size(19, 20);
            this.fridayCountLabel.TabIndex = 50;
            this.fridayCountLabel.Text = "--";
            // 
            // thursdayTransactionLabel
            // 
            this.thursdayTransactionLabel.AutoSize = true;
            this.thursdayTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.thursdayTransactionLabel.Location = new System.Drawing.Point(284, 179);
            this.thursdayTransactionLabel.Name = "thursdayTransactionLabel";
            this.thursdayTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.thursdayTransactionLabel.TabIndex = 49;
            this.thursdayTransactionLabel.Text = "--";
            // 
            // thursdayCountLabel
            // 
            this.thursdayCountLabel.AutoSize = true;
            this.thursdayCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayCountLabel.ForeColor = System.Drawing.Color.Black;
            this.thursdayCountLabel.Location = new System.Drawing.Point(157, 179);
            this.thursdayCountLabel.Name = "thursdayCountLabel";
            this.thursdayCountLabel.Size = new System.Drawing.Size(19, 20);
            this.thursdayCountLabel.TabIndex = 48;
            this.thursdayCountLabel.Text = "--";
            // 
            // wednesdayTransactionLabel
            // 
            this.wednesdayTransactionLabel.AutoSize = true;
            this.wednesdayTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.wednesdayTransactionLabel.Location = new System.Drawing.Point(284, 149);
            this.wednesdayTransactionLabel.Name = "wednesdayTransactionLabel";
            this.wednesdayTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.wednesdayTransactionLabel.TabIndex = 47;
            this.wednesdayTransactionLabel.Text = "--";
            // 
            // wednesdayCountLabel
            // 
            this.wednesdayCountLabel.AutoSize = true;
            this.wednesdayCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayCountLabel.ForeColor = System.Drawing.Color.Black;
            this.wednesdayCountLabel.Location = new System.Drawing.Point(157, 149);
            this.wednesdayCountLabel.Name = "wednesdayCountLabel";
            this.wednesdayCountLabel.Size = new System.Drawing.Size(19, 20);
            this.wednesdayCountLabel.TabIndex = 46;
            this.wednesdayCountLabel.Text = "--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(23, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "Saturday";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(23, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "Friday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(23, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Thursday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(23, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Wednesday";
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
            // tuesdayTransactionLabel
            // 
            this.tuesdayTransactionLabel.AutoSize = true;
            this.tuesdayTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.tuesdayTransactionLabel.Location = new System.Drawing.Point(284, 121);
            this.tuesdayTransactionLabel.Name = "tuesdayTransactionLabel";
            this.tuesdayTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.tuesdayTransactionLabel.TabIndex = 39;
            this.tuesdayTransactionLabel.Text = "--";
            // 
            // mondayTransactionLabel
            // 
            this.mondayTransactionLabel.AutoSize = true;
            this.mondayTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.mondayTransactionLabel.Location = new System.Drawing.Point(284, 88);
            this.mondayTransactionLabel.Name = "mondayTransactionLabel";
            this.mondayTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.mondayTransactionLabel.TabIndex = 38;
            this.mondayTransactionLabel.Text = "--";
            // 
            // sundayTransactionLabel
            // 
            this.sundayTransactionLabel.AutoSize = true;
            this.sundayTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayTransactionLabel.ForeColor = System.Drawing.Color.Black;
            this.sundayTransactionLabel.Location = new System.Drawing.Point(284, 58);
            this.sundayTransactionLabel.Name = "sundayTransactionLabel";
            this.sundayTransactionLabel.Size = new System.Drawing.Size(19, 20);
            this.sundayTransactionLabel.TabIndex = 37;
            this.sundayTransactionLabel.Text = "--";
            // 
            // tuesdayCountLabel
            // 
            this.tuesdayCountLabel.AutoSize = true;
            this.tuesdayCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayCountLabel.ForeColor = System.Drawing.Color.Black;
            this.tuesdayCountLabel.Location = new System.Drawing.Point(157, 120);
            this.tuesdayCountLabel.Name = "tuesdayCountLabel";
            this.tuesdayCountLabel.Size = new System.Drawing.Size(19, 20);
            this.tuesdayCountLabel.TabIndex = 35;
            this.tuesdayCountLabel.Text = "--";
            // 
            // mondayCountLabel
            // 
            this.mondayCountLabel.AutoSize = true;
            this.mondayCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayCountLabel.ForeColor = System.Drawing.Color.Black;
            this.mondayCountLabel.Location = new System.Drawing.Point(157, 86);
            this.mondayCountLabel.Name = "mondayCountLabel";
            this.mondayCountLabel.Size = new System.Drawing.Size(19, 20);
            this.mondayCountLabel.TabIndex = 34;
            this.mondayCountLabel.Text = "--";
            // 
            // sundayCountLabel
            // 
            this.sundayCountLabel.AutoSize = true;
            this.sundayCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayCountLabel.ForeColor = System.Drawing.Color.Black;
            this.sundayCountLabel.Location = new System.Drawing.Point(157, 58);
            this.sundayCountLabel.Name = "sundayCountLabel";
            this.sundayCountLabel.Size = new System.Drawing.Size(19, 20);
            this.sundayCountLabel.TabIndex = 30;
            this.sundayCountLabel.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(22, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tuesday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(22, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Monday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Sunday";
            // 
            // weeklyReportChart
            // 
            this.weeklyReportChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.weeklyReportChart.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.weeklyReportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weeklyReportChart.Legends.Add(legend1);
            this.weeklyReportChart.Location = new System.Drawing.Point(410, 112);
            this.weeklyReportChart.Name = "weeklyReportChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Income";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Count";
            this.weeklyReportChart.Series.Add(series1);
            this.weeklyReportChart.Series.Add(series2);
            this.weeklyReportChart.Size = new System.Drawing.Size(375, 247);
            this.weeklyReportChart.TabIndex = 23;
            this.weeklyReportChart.Text = "chart1";
            // 
            // getReport
            // 
            this.getReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.getReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getReport.ForeColor = System.Drawing.Color.White;
            this.getReport.Location = new System.Drawing.Point(291, 70);
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
            this.Load += new System.EventHandler(this.WeeklyReportForm_Load);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tuesdayTransactionLabel;
        private System.Windows.Forms.Label mondayTransactionLabel;
        private System.Windows.Forms.Label sundayTransactionLabel;
        private System.Windows.Forms.Label tuesdayCountLabel;
        private System.Windows.Forms.Label mondayCountLabel;
        private System.Windows.Forms.Label sundayCountLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyReportChart;
        private System.Windows.Forms.Button getReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label saturdayTransactionLabel;
        private System.Windows.Forms.Label saturdayCountLabel;
        private System.Windows.Forms.Label fridayTransactionLabel;
        private System.Windows.Forms.Label fridayCountLabel;
        private System.Windows.Forms.Label thursdayTransactionLabel;
        private System.Windows.Forms.Label thursdayCountLabel;
        private System.Windows.Forms.Label wednesdayTransactionLabel;
        private System.Windows.Forms.Label wednesdayCountLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}