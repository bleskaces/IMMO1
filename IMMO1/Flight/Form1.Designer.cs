
namespace Snaryad
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.edMass = new System.Windows.Forms.NumericUpDown();
            this.edStep = new System.Windows.Forms.NumericUpDown();
            this.edTime = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flightTimer = new System.Windows.Forms.Timer(this.components);
            this.dg_flightData = new System.Windows.Forms.DataGridView();
            this.clm_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_flightData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Угол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Размер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Масса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Шаг";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Время шага ";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(627, 15);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(121, 38);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Запуск";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(63, 11);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 20);
            this.edHeight.TabIndex = 8;
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(63, 38);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 20);
            this.edAngle.TabIndex = 9;
            this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(63, 65);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 20);
            this.edSpeed.TabIndex = 10;
            this.edSpeed.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // edSize
            // 
            this.edSize.DecimalPlaces = 2;
            this.edSize.Location = new System.Drawing.Point(250, 11);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 20);
            this.edSize.TabIndex = 11;
            this.edSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // edMass
            // 
            this.edMass.DecimalPlaces = 2;
            this.edMass.Location = new System.Drawing.Point(250, 38);
            this.edMass.Name = "edMass";
            this.edMass.Size = new System.Drawing.Size(120, 20);
            this.edMass.TabIndex = 12;
            this.edMass.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // edStep
            // 
            this.edStep.DecimalPlaces = 7;
            this.edStep.Location = new System.Drawing.Point(482, 11);
            this.edStep.Name = "edStep";
            this.edStep.Size = new System.Drawing.Size(120, 20);
            this.edStep.TabIndex = 13;
            this.edStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // edTime
            // 
            this.edTime.Location = new System.Drawing.Point(482, 38);
            this.edTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edTime.Name = "edTime";
            this.edTime.Size = new System.Drawing.Size(120, 20);
            this.edTime.TabIndex = 14;
            this.edTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(6, 100);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(983, 549);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // flightTimer
            // 
            this.flightTimer.Tick += new System.EventHandler(this.flightTimer_Tick);
            // 
            // dg_flightData
            // 
            this.dg_flightData.AllowUserToAddRows = false;
            this.dg_flightData.AllowUserToDeleteRows = false;
            this.dg_flightData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_flightData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Time,
            this.clmn_distance,
            this.clmn_height,
            this.clmn_speed});
            this.dg_flightData.Location = new System.Drawing.Point(995, 100);
            this.dg_flightData.Name = "dg_flightData";
            this.dg_flightData.ReadOnly = true;
            this.dg_flightData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dg_flightData.ShowCellErrors = false;
            this.dg_flightData.ShowCellToolTips = false;
            this.dg_flightData.ShowEditingIcon = false;
            this.dg_flightData.ShowRowErrors = false;
            this.dg_flightData.Size = new System.Drawing.Size(334, 549);
            this.dg_flightData.TabIndex = 16;
            // 
            // clm_Time
            // 
            this.clm_Time.HeaderText = "Time step";
            this.clm_Time.Name = "clm_Time";
            this.clm_Time.ReadOnly = true;
            this.clm_Time.Width = 50;
            // 
            // clmn_distance
            // 
            this.clmn_distance.HeaderText = "Distance";
            this.clmn_distance.Name = "clmn_distance";
            this.clmn_distance.ReadOnly = true;
            this.clmn_distance.Width = 80;
            // 
            // clmn_height
            // 
            this.clmn_height.HeaderText = "Max height";
            this.clmn_height.Name = "clmn_height";
            this.clmn_height.ReadOnly = true;
            this.clmn_height.Width = 80;
            // 
            // clmn_speed
            // 
            this.clmn_speed.HeaderText = "Speed at the end point";
            this.clmn_speed.Name = "clmn_speed";
            this.clmn_speed.ReadOnly = true;
            this.clmn_speed.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 661);
            this.Controls.Add(this.dg_flightData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.edTime);
            this.Controls.Add(this.edStep);
            this.Controls.Add(this.edMass);
            this.Controls.Add(this.edSize);
            this.Controls.Add(this.edSpeed);
            this.Controls.Add(this.edAngle);
            this.Controls.Add(this.edHeight);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1350, 700);
            this.MinimumSize = new System.Drawing.Size(1278, 678);
            this.Name = "Form1";
            this.Text = "Plane model";
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_flightData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.NumericUpDown edMass;
        private System.Windows.Forms.NumericUpDown edStep;
        private System.Windows.Forms.NumericUpDown edTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer flightTimer;
        private System.Windows.Forms.DataGridView dg_flightData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_height;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_speed;
    }
}

