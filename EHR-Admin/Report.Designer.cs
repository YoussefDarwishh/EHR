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
            this.Test1 = new EHR_Admin.Test();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new EHR_Admin.DataSet1();
            this.diagnosisTableAdapter = new EHR_Admin.DataSet1TableAdapters.DiagnosisTableAdapter();
            this.btnLoad = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.selector = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.End = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.chart.Location = new System.Drawing.Point(237, 295);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Count";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(879, 433);
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
            this.diagnosisBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(548, 825);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(228, 31);
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
            this.selector.Location = new System.Drawing.Point(523, 139);
            this.selector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(289, 25);
            this.selector.TabIndex = 2;
            this.selector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kryptonComboBox1_KeyPress);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(1007, 201);
            this.kryptonCheckBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(135, 24);
            this.kryptonCheckBox1.TabIndex = 3;
            this.kryptonCheckBox1.Values.Text = "Pick Date Range";
            this.kryptonCheckBox1.CheckedChanged += new System.EventHandler(this.kryptonCheckBox1_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(336, 201);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(265, 22);
            this.Start.TabIndex = 4;
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(679, 201);
            this.End.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(265, 22);
            this.End.TabIndex = 5;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Test Test1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private DataSet1TableAdapters.DiagnosisTableAdapter diagnosisTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoad;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox selector;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.DateTimePicker End;
    }
}