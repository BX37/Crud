namespace Crud
{
    partial class Graphique
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            BTRetour = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlCommand3 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTest).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(chart2);
            panel1.Controls.Add(chartTest);
            panel1.Controls.Add(BTRetour);
            panel1.Location = new Point(36, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1283, 485);
            panel1.TabIndex = 0;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(563, 70);
            chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            chart2.Series.Add(series1);
            chart2.Size = new Size(680, 375);
            chart2.TabIndex = 2;
            chart2.Text = "chart2";
            // 
            // chartTest
            // 
            chartArea2.Name = "ChartArea1";
            chartTest.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTest.Legends.Add(legend2);
            chartTest.Location = new Point(49, 70);
            chartTest.Name = "chartTest";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartTest.Series.Add(series2);
            chartTest.Size = new Size(375, 375);
            chartTest.TabIndex = 1;
            chartTest.Text = "Salary";
            // 
            // BTRetour
            // 
            BTRetour.Location = new Point(49, 14);
            BTRetour.Name = "BTRetour";
            BTRetour.Size = new Size(94, 29);
            BTRetour.TabIndex = 0;
            BTRetour.Text = "Retour";
            BTRetour.UseVisualStyleBackColor = true;
            BTRetour.Click += BTRetour_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // mySqlCommand3
            // 
            mySqlCommand3.CacheAge = 0;
            mySqlCommand3.Connection = null;
            mySqlCommand3.EnableCaching = false;
            mySqlCommand3.Transaction = null;
            // 
            // Graphique
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 545);
            Controls.Add(panel1);
            Name = "Graphique";
            Text = "Graphique";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTRetour;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}