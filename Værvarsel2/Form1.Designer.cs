namespace Værvarsel2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartVindstyrke = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartNedbør = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTemperatur = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Cb = new System.Windows.Forms.ComboBox();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.LbHeader = new System.Windows.Forms.Label();
            this.LbLastUpdate = new System.Windows.Forms.Label();
            this.ChbTemp = new System.Windows.Forms.CheckBox();
            this.ChbPrec = new System.Windows.Forms.CheckBox();
            this.ChbWind = new System.Windows.Forms.CheckBox();
            this.LbSearch = new System.Windows.Forms.Label();
            this.BtSearch = new System.Windows.Forms.Button();
            this.TbSearchLand = new System.Windows.Forms.TextBox();
            this.TbSearchFylke = new System.Windows.Forms.TextBox();
            this.TbSearchKommune = new System.Windows.Forms.TextBox();
            this.LbSearchLand = new System.Windows.Forms.Label();
            this.LbSearchFylke = new System.Windows.Forms.Label();
            this.LbSearchKommune = new System.Windows.Forms.Label();
            this.LbSearchBy = new System.Windows.Forms.Label();
            this.TbSearchBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVindstyrke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNedbør)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTemperatur)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartVindstyrke
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.Title = "Klokkeslett";
            chartArea1.AxisY.Title = "Hastighet / m/s";
            chartArea1.Name = "ChartArea1";
            this.ChartVindstyrke.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartVindstyrke.Legends.Add(legend1);
            this.ChartVindstyrke.Location = new System.Drawing.Point(315, 700);
            this.ChartVindstyrke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartVindstyrke.Name = "ChartVindstyrke";
            this.ChartVindstyrke.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartVindstyrke.Series.Add(series1);
            this.ChartVindstyrke.Size = new System.Drawing.Size(1569, 242);
            this.ChartVindstyrke.TabIndex = 2;
            this.ChartVindstyrke.TabStop = false;
            this.ChartVindstyrke.Text = "chart1";
            // 
            // ChartNedbør
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Title = "Klokkeslett";
            chartArea2.AxisY.Title = "Mengde / mm";
            chartArea2.Name = "ChartArea1";
            this.ChartNedbør.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartNedbør.Legends.Add(legend2);
            this.ChartNedbør.Location = new System.Drawing.Point(315, 450);
            this.ChartNedbør.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartNedbør.Name = "ChartNedbør";
            this.ChartNedbør.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartNedbør.Series.Add(series2);
            this.ChartNedbør.Size = new System.Drawing.Size(1569, 245);
            this.ChartNedbør.TabIndex = 1;
            this.ChartNedbør.TabStop = false;
            this.ChartNedbør.Text = "chart2";
            // 
            // ChartTemperatur
            // 
            chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.Title = "Klokkeslett";
            chartArea3.AxisY.Title = "Grader / celsius";
            chartArea3.Name = "ChartArea1";
            this.ChartTemperatur.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartTemperatur.Legends.Add(legend3);
            this.ChartTemperatur.Location = new System.Drawing.Point(315, 78);
            this.ChartTemperatur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartTemperatur.Name = "ChartTemperatur";
            this.ChartTemperatur.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.ChartTemperatur.Series.Add(series3);
            this.ChartTemperatur.Series.Add(series4);
            this.ChartTemperatur.Size = new System.Drawing.Size(1569, 369);
            this.ChartTemperatur.TabIndex = 0;
            this.ChartTemperatur.TabStop = false;
            this.ChartTemperatur.Text = "chart3";
            // 
            // Cb
            // 
            this.Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb.FormattingEnabled = true;
            this.Cb.Location = new System.Drawing.Point(41, 293);
            this.Cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cb.Name = "Cb";
            this.Cb.Size = new System.Drawing.Size(140, 28);
            this.Cb.TabIndex = 4;
            this.Cb.SelectedIndexChanged += new System.EventHandler(this.Cb_SelectedIndexChanged);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(41, 150);
            this.BtUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(141, 37);
            this.BtUpdate.TabIndex = 0;
            this.BtUpdate.Text = "Oppdater";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeader.Location = new System.Drawing.Point(305, 9);
            this.LbHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(352, 58);
            this.LbHeader.TabIndex = 6;
            this.LbHeader.Text = "Værvarsel for: ";
            // 
            // LbLastUpdate
            // 
            this.LbLastUpdate.AutoSize = true;
            this.LbLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLastUpdate.Location = new System.Drawing.Point(8, 128);
            this.LbLastUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbLastUpdate.Name = "LbLastUpdate";
            this.LbLastUpdate.Size = new System.Drawing.Size(104, 17);
            this.LbLastUpdate.TabIndex = 7;
            this.LbLastUpdate.Text = "Sist oppdatert: ";
            // 
            // ChbTemp
            // 
            this.ChbTemp.AutoSize = true;
            this.ChbTemp.Checked = true;
            this.ChbTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbTemp.Location = new System.Drawing.Point(41, 194);
            this.ChbTemp.Margin = new System.Windows.Forms.Padding(4);
            this.ChbTemp.Name = "ChbTemp";
            this.ChbTemp.Size = new System.Drawing.Size(117, 24);
            this.ChbTemp.TabIndex = 1;
            this.ChbTemp.Tag = "0";
            this.ChbTemp.Text = "Temperatur";
            this.ChbTemp.UseVisualStyleBackColor = true;
            this.ChbTemp.CheckedChanged += new System.EventHandler(this.Chb_CheckedChanged);
            // 
            // ChbPrec
            // 
            this.ChbPrec.AutoSize = true;
            this.ChbPrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbPrec.Location = new System.Drawing.Point(41, 228);
            this.ChbPrec.Margin = new System.Windows.Forms.Padding(4);
            this.ChbPrec.Name = "ChbPrec";
            this.ChbPrec.Size = new System.Drawing.Size(85, 24);
            this.ChbPrec.TabIndex = 2;
            this.ChbPrec.Tag = "1";
            this.ChbPrec.Text = "Nedbør";
            this.ChbPrec.UseVisualStyleBackColor = true;
            this.ChbPrec.CheckedChanged += new System.EventHandler(this.Chb_CheckedChanged);
            // 
            // ChbWind
            // 
            this.ChbWind.AutoSize = true;
            this.ChbWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbWind.Location = new System.Drawing.Point(41, 261);
            this.ChbWind.Margin = new System.Windows.Forms.Padding(4);
            this.ChbWind.Name = "ChbWind";
            this.ChbWind.Size = new System.Drawing.Size(109, 24);
            this.ChbWind.TabIndex = 3;
            this.ChbWind.Tag = "2";
            this.ChbWind.Text = "Vindstyrke";
            this.ChbWind.UseVisualStyleBackColor = true;
            this.ChbWind.CheckedChanged += new System.EventHandler(this.Chb_CheckedChanged);
            // 
            // LbSearch
            // 
            this.LbSearch.AutoSize = true;
            this.LbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSearch.Location = new System.Drawing.Point(113, 394);
            this.LbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSearch.Name = "LbSearch";
            this.LbSearch.Size = new System.Drawing.Size(138, 25);
            this.LbSearch.TabIndex = 11;
            this.LbSearch.Text = "Søk etter sted:";
            // 
            // BtSearch
            // 
            this.BtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearch.Location = new System.Drawing.Point(131, 569);
            this.BtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(133, 36);
            this.BtSearch.TabIndex = 9;
            this.BtSearch.Text = "Søk";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // TbSearchLand
            // 
            this.TbSearchLand.Enabled = false;
            this.TbSearchLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchLand.Location = new System.Drawing.Point(131, 422);
            this.TbSearchLand.Margin = new System.Windows.Forms.Padding(4);
            this.TbSearchLand.Name = "TbSearchLand";
            this.TbSearchLand.Size = new System.Drawing.Size(132, 26);
            this.TbSearchLand.TabIndex = 5;
            this.TbSearchLand.Text = "Norge";
            // 
            // TbSearchFylke
            // 
            this.TbSearchFylke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchFylke.Location = new System.Drawing.Point(131, 458);
            this.TbSearchFylke.Margin = new System.Windows.Forms.Padding(4);
            this.TbSearchFylke.Name = "TbSearchFylke";
            this.TbSearchFylke.Size = new System.Drawing.Size(132, 26);
            this.TbSearchFylke.TabIndex = 6;
            // 
            // TbSearchKommune
            // 
            this.TbSearchKommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchKommune.Location = new System.Drawing.Point(131, 497);
            this.TbSearchKommune.Margin = new System.Windows.Forms.Padding(4);
            this.TbSearchKommune.Name = "TbSearchKommune";
            this.TbSearchKommune.Size = new System.Drawing.Size(132, 26);
            this.TbSearchKommune.TabIndex = 7;
            // 
            // LbSearchLand
            // 
            this.LbSearchLand.AutoSize = true;
            this.LbSearchLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSearchLand.Location = new System.Drawing.Point(57, 426);
            this.LbSearchLand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSearchLand.Name = "LbSearchLand";
            this.LbSearchLand.Size = new System.Drawing.Size(51, 20);
            this.LbSearchLand.TabIndex = 16;
            this.LbSearchLand.Text = "Land:";
            // 
            // LbSearchFylke
            // 
            this.LbSearchFylke.AutoSize = true;
            this.LbSearchFylke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSearchFylke.Location = new System.Drawing.Point(57, 462);
            this.LbSearchFylke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSearchFylke.Name = "LbSearchFylke";
            this.LbSearchFylke.Size = new System.Drawing.Size(53, 20);
            this.LbSearchFylke.TabIndex = 17;
            this.LbSearchFylke.Text = "Fylke:";
            // 
            // LbSearchKommune
            // 
            this.LbSearchKommune.AutoSize = true;
            this.LbSearchKommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSearchKommune.Location = new System.Drawing.Point(23, 501);
            this.LbSearchKommune.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSearchKommune.Name = "LbSearchKommune";
            this.LbSearchKommune.Size = new System.Drawing.Size(89, 20);
            this.LbSearchKommune.TabIndex = 18;
            this.LbSearchKommune.Text = "Kommune:";
            // 
            // LbSearchBy
            // 
            this.LbSearchBy.AutoSize = true;
            this.LbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSearchBy.Location = new System.Drawing.Point(37, 537);
            this.LbSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSearchBy.Name = "LbSearchBy";
            this.LbSearchBy.Size = new System.Drawing.Size(73, 20);
            this.LbSearchBy.TabIndex = 20;
            this.LbSearchBy.Text = "By/Sted:";
            // 
            // TbSearchBy
            // 
            this.TbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearchBy.Location = new System.Drawing.Point(131, 533);
            this.TbSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.TbSearchBy.Name = "TbSearchBy";
            this.TbSearchBy.Size = new System.Drawing.Size(132, 26);
            this.TbSearchBy.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 608);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "OBS! Case-sensitiv!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbSearchBy);
            this.Controls.Add(this.TbSearchBy);
            this.Controls.Add(this.LbSearchKommune);
            this.Controls.Add(this.LbSearchFylke);
            this.Controls.Add(this.LbSearchLand);
            this.Controls.Add(this.TbSearchKommune);
            this.Controls.Add(this.TbSearchFylke);
            this.Controls.Add(this.TbSearchLand);
            this.Controls.Add(this.BtSearch);
            this.Controls.Add(this.LbSearch);
            this.Controls.Add(this.ChbWind);
            this.Controls.Add(this.ChbPrec);
            this.Controls.Add(this.ChbTemp);
            this.Controls.Add(this.LbLastUpdate);
            this.Controls.Add(this.LbHeader);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.Cb);
            this.Controls.Add(this.ChartTemperatur);
            this.Controls.Add(this.ChartNedbør);
            this.Controls.Add(this.ChartVindstyrke);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Været";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartVindstyrke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartNedbør)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTemperatur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVindstyrke;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartNedbør;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTemperatur;
        private System.Windows.Forms.ComboBox Cb;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Label LbLastUpdate;
        private System.Windows.Forms.CheckBox ChbTemp;
        private System.Windows.Forms.CheckBox ChbPrec;
        private System.Windows.Forms.CheckBox ChbWind;
        private System.Windows.Forms.Label LbSearch;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.TextBox TbSearchLand;
        private System.Windows.Forms.TextBox TbSearchFylke;
        private System.Windows.Forms.TextBox TbSearchKommune;
        private System.Windows.Forms.Label LbSearchLand;
        private System.Windows.Forms.Label LbSearchFylke;
        private System.Windows.Forms.Label LbSearchKommune;
        private System.Windows.Forms.Label LbSearchBy;
        private System.Windows.Forms.TextBox TbSearchBy;
        private System.Windows.Forms.Label label1;
    }
}

