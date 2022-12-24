﻿namespace EHR_Admin
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
     
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
   
           
            this.btnLoad = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.selector = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.End = new System.Windows.Forms.DateTimePicker();
            this.kryptonCheckBox2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
      
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.DataSource = this.diagnosisBindingSource;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(178, 308);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Count";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(659, 352);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            title1.Name = "Diagnosis";
            title1.Text = "Diagnosis";
            this.chart.Titles.Add(title1);
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "Diagnosis";
           
            // diagnosisTableAdapter
            // 
      
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(411, 670);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(171, 25);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Values.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // selector
            // 
            this.selector.DropDownWidth = 217;
            this.selector.Items.AddRange(new object[] {
            "Diagnosis",
            "Medications",
            "Lab Tests",
            "Surgeries"});
            this.selector.Location = new System.Drawing.Point(389, 202);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(217, 21);
            this.selector.TabIndex = 2;
            this.selector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kryptonComboBox1_KeyPress);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(752, 252);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(112, 20);
            this.kryptonCheckBox1.TabIndex = 3;
            this.kryptonCheckBox1.Values.Text = "Pick Date Range";
            this.kryptonCheckBox1.CheckedChanged += new System.EventHandler(this.kryptonCheckBox1_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(249, 252);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 20);
            this.Start.TabIndex = 4;
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(506, 252);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(200, 20);
            this.End.TabIndex = 5;
            // 
            // kryptonCheckBox2
            // 
            this.kryptonCheckBox2.Location = new System.Drawing.Point(752, 278);
            this.kryptonCheckBox2.Name = "kryptonCheckBox2";
            this.kryptonCheckBox2.Size = new System.Drawing.Size(169, 20);
            this.kryptonCheckBox2.TabIndex = 6;
            this.kryptonCheckBox2.Values.Text = "Split into Male and Female";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHR_Admin.Properties.Resources.Statistics_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.kryptonCheckBox2);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chart);
            this.DoubleBuffered = true;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
       
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
     
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
   
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoad;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox selector;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.DateTimePicker End;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox2;
    }
}