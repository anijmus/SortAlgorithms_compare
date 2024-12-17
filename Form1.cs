using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pr1
{
    public partial class Form1 : Form
    {
        private void chartInit()
        {
            chart1.ChartAreas.First().AxisY.Title = "Ilość elementów";
            chart1.ChartAreas.First().AxisX.CustomLabels.Clear();

            chart1.ChartAreas.First().AxisY.Title = "Czas wykonania";
            chart1.ChartAreas.First().AxisY.LabelStyle.Format = "0ms";

            chart1.ChartAreas.First().AxisY.Minimum = 0;
        }

        public Form1()
        {
            InitializeComponent();
            chartInit();

            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Panel1MinSize = 80;
            splitContainer1.IsSplitterFixed = false;

            listBoxElements.Items.Add(ElementType.Losowe);
            listBoxElements.Items.Add(ElementType.Rosnące);
            listBoxElements.Items.Add(ElementType.Malejące);

            listBoxElements.SelectedItem = ElementType.Losowe;
            listBoxAlgorithms.SelectedItem = "Bubble sort";

            progressBar1.Minimum = 0; 
            progressBar1.Step = 1;     
            progressBar1.Value = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
           
            chart1.Series.Clear();
            chart1.Annotations.Clear();
            chart1.ChartAreas[0].RecalculateAxesScale(); 

            buttonStart.Enabled = false;
            int numerTestu = 0;
            this.Text = $"Wykonano {numerTestu} testów";

            try
            {
                int maxSize = (int)numericUpDownMaxSize.Value;
                int step = maxSize < 20000 ? 1000 : 5000; ;

                Elements elements = new Elements();
          
                List<Algorithms> selectedAlgorithms = new List<Algorithms>();


                foreach (string item in listBoxAlgorithms.SelectedItems)
                {
                    switch (item)
                    {
                        case "Bubble sort":
                            selectedAlgorithms.Add(new BubbleSort());
                            break;

                        case "Insertion sort":
                            selectedAlgorithms.Add(new InsertionSort());
                            break;
                        case "Selection sort":
                            selectedAlgorithms.Add(new SelectionSort());
                            break;
                        case "Merge sort":
                            selectedAlgorithms.Add(new MergeSort());
                            break;
                        case "Quick sort":
                            selectedAlgorithms.Add(new QuickSort());
                            break;
                    }
                }

                int totalTests = 0;
         
                for (int i = 0; i <= maxSize; i += step)
                {
                    totalTests+=selectedAlgorithms.Count();
                }
                Console.WriteLine(totalTests);

                progressBar1.Maximum = totalTests;  
                progressBar1.Value = 0;

                foreach (ElementType elementType in listBoxElements.SelectedItems)
                {
                    for (int i = 0; i <= maxSize; i += step)
                    {
                        int[] array = elements.GenerateElements(i, elementType);

                        foreach (Algorithms alg in selectedAlgorithms)
                        {
                            if (chart1.Series.FindByName(alg.GetType().Name) == null)
                            {
                                Series series = new Series()
                                {
                                    Name = alg.GetType().Name,
                                    LegendText = alg.GetType().Name,
                                    BorderWidth = 3,
                                    ChartType = SeriesChartType.Line
                                };
                                series.MarkerStyle = MarkerStyle.Circle; 
                                series.MarkerColor = Color.Fuchsia; 
                                series.MarkerBorderColor = Color.Black;
                                chart1.Series.Add(series);
                            }

                            int[] copyArray = (int[])array.Clone();

                            double time = alg.SortAndTime(copyArray);

                            if (i == maxSize)
                            {
                                DataPoint dpt = new DataPoint(i, time);

                                dpt.Label = (time).ToString();
                                dpt.MarkerStyle = MarkerStyle.Circle;
                                dpt.MarkerColor = Color.DarkBlue;
                                chart1.Series[alg.GetType().Name].Points.Add(dpt);
                            }

                            progressBar1.PerformStep();
                            chart1.Series[alg.GetType().Name].Points.AddXY(i, time);
                            numerTestu++;
                            this.Text = $"Wykonano {numerTestu} testów";
                        }
                    }
                }

                chart1.Invalidate();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonStart.Enabled = true;
                buttonStart.Text = "Start";
            }
        }
    }
}