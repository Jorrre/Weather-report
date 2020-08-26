using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Værvarsel2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            CenterToScreen();
        }

        #region GlobVars
        List<List<Weather>> weatherData = new List<List<Weather>>();

        // int minLength = 6;
        const string defaultURL = @"https://www.yr.no/sted/Norge/Akershus/Bærum/Rud_videregående_skole/forecast_hour_by_hour.xml";
        string xmlURL;

        CheckBox[] checkBoxArray;
        TextBox[] searchBoxArray;
        System.Windows.Forms.DataVisualization.Charting.Chart[] chartArray;

        #endregion

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            checkBoxArray = new CheckBox[] { ChbTemp, ChbPrec, ChbWind };
            searchBoxArray = new TextBox[] { TbSearchLand, TbSearchFylke, TbSearchKommune, TbSearchBy };
            chartArray = new System.Windows.Forms.DataVisualization.Charting.Chart[] { ChartTemperatur, ChartNedbør, ChartVindstyrke };

            xmlURL = defaultURL;
            weatherData = GetWeather(xmlURL);

            ChartNedbør.Visible = false;
            ChartVindstyrke.Visible = false;
            Cb.SelectedItem = Cb.Items[0];
            FillChart(Cb.SelectedIndex);
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            int index = Cb.SelectedIndex;
            Cb.Items.Clear();
            weatherData = GetWeather(xmlURL);
            Cb.SelectedIndex = index;
            FillChart(Cb.SelectedIndex);
        }

        private void Chb_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkBoxArray.Length; i++)
            {
                if (checkBoxArray[i].Checked) chartArray[i].Visible = true;
                else chartArray[i].Visible = false;
            }
        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillChart(Cb.SelectedIndex);
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            bool allFilled = true;
            foreach (TextBox tb in searchBoxArray)
            {
                if (tb.Text == null | tb.Text.Length <= 0)
                {
                    allFilled = false;
                    tb.Focus();
                    break;
                }
            }

            if (!allFilled) MessageBox.Show("Alle felt må være fylt ut.", "Error");
            else
            {
                string prevXML = xmlURL;
                try
                {
                    xmlURL = @"https://www.yr.no/sted/" +
                    TbSearchLand.Text.Replace(' ', '_') + @"/" +
                    TbSearchFylke.Text.Replace(' ', '_') + @"/" +
                    TbSearchKommune.Text.Replace(' ', '_') + @"/" +
                    TbSearchBy.Text.Replace(' ', '_') +
                    @"/forecast_hour_by_hour.xml";

                    XmlDocument newXml = new XmlDocument();
                    newXml.Load(xmlURL);

                    int index = Cb.SelectedIndex;
                    Cb.Items.Clear();
                    weatherData = GetWeather(xmlURL);
                    Cb.SelectedIndex = index;
                    FillChart(Cb.SelectedIndex);

                    foreach (TextBox tb in searchBoxArray) tb.Clear();
                    TbSearchLand.Text = "Norge";

                }
                catch (System.Net.WebException)
                {
                    xmlURL = prevXML;
                    MessageBox.Show("Fant ikke stedet du lette etter.\nSjekk at oppgitt informasjon er korrekt.", "Error");
                    TbSearchFylke.Focus();
                }
            }
        }
        #endregion

        #region Private functions
        /// <summary>
        /// Returns a 2D List<> collection containing instances of the "Weather" class.
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        private List<List<Weather>> GetWeather(string xmlPath)
        {
            List<List<Weather>> retVar = new List<List<Weather>>();
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            XmlNode DataNode = xmlDoc["weatherdata"]["forecast"];

            LbHeader.Text = "Værvarsel for: " + DataNode["text"]["location"].Attributes[0].InnerText;

            Cb.Items.Add(DataNode["tabular"].FirstChild.Attributes[0].InnerText.Split('T')[0]);

            retVar.Add(new List<Weather>());
            int listIndex = 0;

            string dateCheck = DataNode["tabular"].ChildNodes[0].Attributes[0].InnerText.Split('T')[0];
            foreach (XmlNode node in DataNode["tabular"].ChildNodes)
            {
                if (node.Attributes[0].InnerText.Split('T')[0] != dateCheck)
                {
                    retVar.Add(new List<Weather>());
                    listIndex++;
                    
                    Cb.Items.Add(node.Attributes[0].InnerText.Split('T')[0]);
                }

                dateCheck = node.Attributes[0].InnerText.Split('T')[0];

                retVar[listIndex].Add(new Weather(
                    node.Attributes[0].InnerText,
                    node["temperature"].Attributes[1].InnerText,
                    node["precipitation"].Attributes[0].InnerText,
                    node["windSpeed"].Attributes[0].InnerText
                    ));
            }

            LbLastUpdate.Text = "Sist oppdatert:" + DateTime.Now.ToString();
            return retVar;
        }
        
        /// <summary>
        /// "Fills" the charts with relevant information
        /// </summary>
        /// <param name="indexDay"></param>
        private void FillChart(int indexDay)
        {
            foreach (System.Windows.Forms.DataVisualization.Charting.Chart ch in chartArray)
                ch.Series.Clear();

            chartArray[0].Series.Add("Temperatur");
            chartArray[0].Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chartArray[0].Series[0].BorderColor = Color.Red;
            chartArray[0].Series[0].BorderWidth = 4;

            chartArray[1].Series.Add("Nedbør");
            chartArray[1].Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartArray[1].Series[0].BorderColor = Color.Blue;

            chartArray[2].Series.Add("Vindstyrke");
            chartArray[2].Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chartArray[2].Series[0].BorderColor = Color.Green;
            chartArray[2].Series[0].BorderWidth = 4;

            for (int i = 0; i < weatherData[indexDay].Count; i++)
            {
                chartArray[0].Series[0].Points.AddXY(weatherData[indexDay][i].Hour, weatherData[indexDay][i].Temperature);
                chartArray[1].Series[0].Points.AddXY(weatherData[indexDay][i].Hour, weatherData[indexDay][i].Precipitation);
                chartArray[2].Series[0].Points.AddXY(weatherData[indexDay][i].Hour, weatherData[indexDay][i].WindSpeed);
            }
        }
        #endregion
    }
}
