
namespace SimpleGraphicDrawer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonParams = new System.Windows.Forms.Button();
            this.chartGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelExtremumMin = new System.Windows.Forms.Label();
            this.labelExtremumMinValue = new System.Windows.Forms.Label();
            this.labelExtremumMax = new System.Windows.Forms.Label();
            this.labelExtremumMaxValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(504, 365);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(267, 43);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Нарисовать график параболы";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonParams
            // 
            this.buttonParams.Location = new System.Drawing.Point(506, 305);
            this.buttonParams.Name = "buttonParams";
            this.buttonParams.Size = new System.Drawing.Size(265, 42);
            this.buttonParams.TabIndex = 2;
            this.buttonParams.Text = "Задать параметры";
            this.buttonParams.UseVisualStyleBackColor = true;
            this.buttonParams.Click += new System.EventHandler(this.buttonParams_Click);
            // 
            // chartGraphic
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGraphic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraphic.Legends.Add(legend2);
            this.chartGraphic.Location = new System.Drawing.Point(30, 36);
            this.chartGraphic.Name = "chartGraphic";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Функция";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.MarkerSize = 8;
            series5.Name = "Минимум";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.LabelBackColor = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.MarkerSize = 8;
            series6.Name = "Максимум";
            this.chartGraphic.Series.Add(series4);
            this.chartGraphic.Series.Add(series5);
            this.chartGraphic.Series.Add(series6);
            this.chartGraphic.Size = new System.Drawing.Size(445, 371);
            this.chartGraphic.TabIndex = 3;
            this.chartGraphic.Text = "chartGraphic";
            // 
            // labelExtremumMin
            // 
            this.labelExtremumMin.AutoSize = true;
            this.labelExtremumMin.Location = new System.Drawing.Point(512, 45);
            this.labelExtremumMin.Name = "labelExtremumMin";
            this.labelExtremumMin.Size = new System.Drawing.Size(61, 13);
            this.labelExtremumMin.TabIndex = 4;
            this.labelExtremumMin.Text = "Минимум :";
            // 
            // labelExtremumMinValue
            // 
            this.labelExtremumMinValue.AutoSize = true;
            this.labelExtremumMinValue.Location = new System.Drawing.Point(588, 45);
            this.labelExtremumMinValue.Name = "labelExtremumMinValue";
            this.labelExtremumMinValue.Size = new System.Drawing.Size(23, 13);
            this.labelExtremumMinValue.TabIndex = 5;
            this.labelExtremumMinValue.Text = "null";
            // 
            // labelExtremumMax
            // 
            this.labelExtremumMax.AutoSize = true;
            this.labelExtremumMax.Location = new System.Drawing.Point(506, 72);
            this.labelExtremumMax.Name = "labelExtremumMax";
            this.labelExtremumMax.Size = new System.Drawing.Size(67, 13);
            this.labelExtremumMax.TabIndex = 6;
            this.labelExtremumMax.Text = "Максимум :";
            // 
            // labelExtremumMaxValue
            // 
            this.labelExtremumMaxValue.AutoSize = true;
            this.labelExtremumMaxValue.Location = new System.Drawing.Point(588, 72);
            this.labelExtremumMaxValue.Name = "labelExtremumMaxValue";
            this.labelExtremumMaxValue.Size = new System.Drawing.Size(23, 13);
            this.labelExtremumMaxValue.TabIndex = 7;
            this.labelExtremumMaxValue.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelExtremumMaxValue);
            this.Controls.Add(this.labelExtremumMax);
            this.Controls.Add(this.labelExtremumMinValue);
            this.Controls.Add(this.labelExtremumMin);
            this.Controls.Add(this.chartGraphic);
            this.Controls.Add(this.buttonParams);
            this.Controls.Add(this.buttonDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonParams;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic;
        private System.Windows.Forms.Label labelExtremumMin;
        private System.Windows.Forms.Label labelExtremumMinValue;
        private System.Windows.Forms.Label labelExtremumMax;
        private System.Windows.Forms.Label labelExtremumMaxValue;
    }
}

