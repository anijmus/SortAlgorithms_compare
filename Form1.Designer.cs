﻿namespace pr1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownMaxSize = new System.Windows.Forms.NumericUpDown();
            this.listBoxElements = new System.Windows.Forms.ListBox();
            this.listBoxAlgorithms = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(895, 535);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(18, 472);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(210, 50);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownMaxSize
            // 
            this.numericUpDownMaxSize.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownMaxSize.Location = new System.Drawing.Point(18, 89);
            this.numericUpDownMaxSize.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMaxSize.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpDownMaxSize.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownMaxSize.Name = "numericUpDownMaxSize";
            this.numericUpDownMaxSize.Size = new System.Drawing.Size(209, 22);
            this.numericUpDownMaxSize.TabIndex = 8;
            this.numericUpDownMaxSize.ThousandsSeparator = true;
            this.numericUpDownMaxSize.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // listBoxElements
            // 
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.ItemHeight = 16;
            this.listBoxElements.Location = new System.Drawing.Point(18, 163);
            this.listBoxElements.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.Size = new System.Drawing.Size(210, 84);
            this.listBoxElements.TabIndex = 9;
            // 
            // listBoxAlgorithms
            // 
            this.listBoxAlgorithms.FormattingEnabled = true;
            this.listBoxAlgorithms.ItemHeight = 16;
            this.listBoxAlgorithms.Items.AddRange(new object[] {
            "Bubble sort",
            "Insertion sort",
            "Selection sort",
            "Merge sort",
            "Quick sort"});
            this.listBoxAlgorithms.Location = new System.Drawing.Point(18, 293);
            this.listBoxAlgorithms.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlgorithms.Name = "listBoxAlgorithms";
            this.listBoxAlgorithms.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAlgorithms.Size = new System.Drawing.Size(209, 100);
            this.listBoxAlgorithms.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 435);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 30);
            this.progressBar1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Typ elementów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ilość elementów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Algorytmy";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(161, 0);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(9, 4);
            this.checkedListBox2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxAlgorithms);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxElements);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownMaxSize);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
            this.splitContainer1.Panel1MinSize = 80;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1085, 535);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Analiza złożoności\r\nobliczeniowej algorytmów";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1085, 535);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.checkedListBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Porównanie algorytmów";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSize)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSize;
        private System.Windows.Forms.ListBox listBoxElements;
        private System.Windows.Forms.ListBox listBoxAlgorithms;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
    }
}

