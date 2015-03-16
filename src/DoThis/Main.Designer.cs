using Akka.Actor;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
namespace ChartApp
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuButton = new System.Windows.Forms.Button();
            this.memoryButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea3.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea3);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.sysChart.Legends.Add(legend3);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysChart.Name = "sysChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.sysChart.Series.Add(series3);
            this.sysChart.Size = new System.Drawing.Size(912, 549);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // cpuButton
            // 
            this.cpuButton.Location = new System.Drawing.Point(764, 401);
            this.cpuButton.Name = "cpuButton";
            this.cpuButton.Size = new System.Drawing.Size(122, 23);
            this.cpuButton.TabIndex = 1;
            this.cpuButton.Text = "CPU (on)";
            this.cpuButton.UseVisualStyleBackColor = true;
            this.cpuButton.Click += new System.EventHandler(this.cpuButton_Click);
            // 
            // memoryButton
            // 
            this.memoryButton.Location = new System.Drawing.Point(764, 430);
            this.memoryButton.Name = "memoryButton";
            this.memoryButton.Size = new System.Drawing.Size(122, 23);
            this.memoryButton.TabIndex = 2;
            this.memoryButton.Text = "Memory (off)";
            this.memoryButton.UseVisualStyleBackColor = true;
            this.memoryButton.Click += new System.EventHandler(this.memoryButton_Click);
            // 
            // diskButton
            // 
            this.diskButton.Location = new System.Drawing.Point(764, 459);
            this.diskButton.Name = "diskButton";
            this.diskButton.Size = new System.Drawing.Size(122, 23);
            this.diskButton.TabIndex = 3;
            this.diskButton.Text = "Disk (off)";
            this.diskButton.UseVisualStyleBackColor = true;
            this.diskButton.Click += new System.EventHandler(this.diskButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 549);
            this.Controls.Add(this.diskButton);
            this.Controls.Add(this.memoryButton);
            this.Controls.Add(this.cpuButton);
            this.Controls.Add(this.sysChart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button cpuButton;
        private System.Windows.Forms.Button memoryButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button diskButton;
    }
}

