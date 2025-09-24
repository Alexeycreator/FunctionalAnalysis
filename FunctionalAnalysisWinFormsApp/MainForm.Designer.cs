namespace FunctionalAnalysisWinFormsApp
{
    partial class MainForm
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
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chdListBoxChart = new System.Windows.Forms.CheckedListBox();
            this.rTbxPrintInfo = new System.Windows.Forms.RichTextBox();
            this.tbxVariable = new System.Windows.Forms.TextBox();
            this.tbxN = new System.Windows.Forms.TextBox();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelVariable = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(12, 12);
            this.chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Size = new System.Drawing.Size(440, 327);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "chart1";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.Location = new System.Drawing.Point(12, 376);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 39);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Выполнить";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // chdListBoxChart
            // 
            this.chdListBoxChart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chdListBoxChart.FormattingEnabled = true;
            this.chdListBoxChart.Location = new System.Drawing.Point(458, 12);
            this.chdListBoxChart.Name = "chdListBoxChart";
            this.chdListBoxChart.Size = new System.Drawing.Size(140, 304);
            this.chdListBoxChart.TabIndex = 2;
            // 
            // rTbxPrintInfo
            // 
            this.rTbxPrintInfo.Location = new System.Drawing.Point(604, 216);
            this.rTbxPrintInfo.Name = "rTbxPrintInfo";
            this.rTbxPrintInfo.Size = new System.Drawing.Size(286, 210);
            this.rTbxPrintInfo.TabIndex = 3;
            this.rTbxPrintInfo.Text = "";
            // 
            // tbxVariable
            // 
            this.tbxVariable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxVariable.Location = new System.Drawing.Point(604, 38);
            this.tbxVariable.Name = "tbxVariable";
            this.tbxVariable.Size = new System.Drawing.Size(286, 30);
            this.tbxVariable.TabIndex = 4;
            this.tbxVariable.Enter += new System.EventHandler(this.tbxVariable_Enter);
            this.tbxVariable.Leave += new System.EventHandler(this.tbxVariable_Leave);
            // 
            // tbxN
            // 
            this.tbxN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxN.Location = new System.Drawing.Point(604, 108);
            this.tbxN.Name = "tbxN";
            this.tbxN.Size = new System.Drawing.Size(286, 30);
            this.tbxN.TabIndex = 5;
            this.tbxN.Enter += new System.EventHandler(this.tbxN_Enter);
            this.tbxN.Leave += new System.EventHandler(this.tbxN_Leave);
            // 
            // tbxX
            // 
            this.tbxX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxX.Location = new System.Drawing.Point(604, 180);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(286, 30);
            this.tbxX.TabIndex = 7;
            this.tbxX.Enter += new System.EventHandler(this.tbxX_Enter);
            this.tbxX.Leave += new System.EventHandler(this.tbxX_Leave);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(134, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelVariable
            // 
            this.labelVariable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariable.Location = new System.Drawing.Point(604, 12);
            this.labelVariable.Name = "labelVariable";
            this.labelVariable.Size = new System.Drawing.Size(224, 23);
            this.labelVariable.TabIndex = 9;
            this.labelVariable.Text = "Номер варианта";
            // 
            // labelN
            // 
            this.labelN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(604, 82);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(224, 23);
            this.labelN.TabIndex = 10;
            this.labelN.Text = "Число итераций";
            // 
            // labelX
            // 
            this.labelX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(604, 154);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(224, 23);
            this.labelX.TabIndex = 11;
            this.labelX.Text = "Значение x";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelVariable);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.tbxN);
            this.Controls.Add(this.tbxVariable);
            this.Controls.Add(this.rTbxPrintInfo);
            this.Controls.Add(this.chdListBoxChart);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chartGraph);
            this.Name = "MainForm";
            this.Text = "Задание 5";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelVariable;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelX;

        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.TextBox tbxX;

        private System.Windows.Forms.TextBox tbxVariable;
        private System.Windows.Forms.TextBox tbxN;

        private System.Windows.Forms.RichTextBox rTbxPrintInfo;

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckedListBox chdListBoxChart;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;

        #endregion
    }
}