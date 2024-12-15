//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms.DataVisualization.Charting;
//using System.Windows.Forms;
//using System.Xml.Linq;
//using pr1;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

//namespace pr1
//{
//    internal class Class1
//    {
//        private void buttonStart_Click(object sender, EventArgs e)
//        {
//            chart1.Series.Clear();
//            chart1.Annotations.Clear();
//            buttonStart.Enabled = false;
//            int numerTestu = 0;
//            this.Text = $"Wykonano {numerTestu} testów";
//            buttonStart.Text = "Działa program...";


//            chart1.ChartAreas[0].AxisY.Minimum = Double.NaN; // Resetuje minimum
//            chart1.ChartAreas[0].AxisY.Maximum = Double.NaN; // Resetuje maksimum
//            chart1.ChartAreas[0].RecalculateAxesScale(); // A

//            try
//            {
//                int maxSize = (int)numericUpDownMaxSize.Value;
//                int step = 1; //maxSize < 20000 ? 1000 : 5000; ;
//                List<Algorithms> selectedAlgorithms = new List<Algorithms>();
//                Elements elements = new Elements();


//                foreach (var item in listBoxAlgorithms.SelectedItems)
//                {
//                    switch (item)
//                    {
//                        case "Bubble sort":
//                            selectedAlgorithms.Add(new BubbleSort());
//                            break;

//                        case "Insertion sort":
//                            selectedAlgorithms.Add(new InsertionSort());
//                            break;
//                        case "Selection sort":
//                            selectedAlgorithms.Add(new SelectionSort());
//                            break;
//                        case "Merge sort":
//                            selectedAlgorithms.Add(new MergeSort());
//                            break;
//                        case "Quick sort":
//                            selectedAlgorithms.Add(new QuickSort());
//                            break;
//                    }
//                }
//                int middle = (maxSize) / 2;


//                foreach (ElementType elementType in listBoxElements.SelectedItems)
//                {
//                    for (int i = 9; i <= maxSize; i += step)
//                    {
//                        int[] array = elements.GenerateElements(i, elementType);

//                        foreach (Algorithms alg in selectedAlgorithms)
//                        {

//                            Series series = new Series()
//                            {
//                                Name = alg.GetType().Name,
//                                LegendText = alg.GetType().Name,
//                                BorderWidth = 3,
//                                ChartType = SeriesChartType.Line
//                            };
//                            series.MarkerStyle = MarkerStyle.Circle; // Wyświetlanie punktów jako okręgi
//                            series.MarkerSize = 6; // Rozmiar znacznika
//                            series.MarkerColor = Color.Fuchsia; // Kolor punktów
//                            series.MarkerBorderColor = Color.Black;

//                            int[] copyArray = (int[])array.Clone();

//                            for (int j = 0; j < copyArray.Length; j++)
//                            {
//                                Console.Write(copyArray[j] + " ");
//                            }
//                            Console.WriteLine();
//                            double time = alg.SortAndTime(copyArray);

//                            if (i == maxSize)
//                            {
//                                DataPoint dpt = new DataPoint(i, time);

//                                dpt.Label = (time).ToString();
//                                dpt.MarkerStyle = MarkerStyle.Circle;
//                                dpt.MarkerSize = 8;
//                                dpt.BorderWidth = 3;
//                                dpt.MarkerColor = Color.DarkBlue;
//                                series.Points.Add(dpt);
//                            }

//                            series.Points.AddXY(i, time);
//                            numerTestu++;
//                            this.Text = $"Wykonano {numerTestu} testów";
//                            chart1.Series.Add(series);
//                        }
//                    }



//                }

//                chart1.Invalidate();
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            finally
//            {
//                buttonStart.Enabled = true;
//                buttonStart.Text = "Start";


//            }
//        }

//    }
//}

//foreach (Algorithms alg in selectedAlgorithms)
//{

//    Series series = new Series()
//    {
//        Name = alg.GetType().Name,
//        LegendText = alg.GetType().Name,
//        BorderWidth = 3,
//        ChartType = SeriesChartType.Line
//    };

//    for (int i = 9; i <= maxSize; i += step)
//    {
//        int[] array = elements.GenerateElements(i, elementType);
//        int[] copyArray = (int[])array.Clone();

//        for (int j = 0; j < copyArray.Length; j++)
//        {
//            Console.Write(copyArray[j] + " ");
//        }
//        Console.WriteLine();
//        double time = alg.SortAndTime(copyArray);
//        if (!alg.IsSorted(copyArray))
//        {
//            throw new InvalidOperationException($"Array{Name} ilosc {i} is not sorted correctly!");
//        }
//        series.MarkerStyle = MarkerStyle.Circle; // Wyświetlanie punktów jako okręgi
//        series.MarkerSize = 6; // Rozmiar znacznika
//        series.MarkerColor = Color.Fuchsia; // Kolor punktów
//        series.MarkerBorderColor = Color.Black;
//        if (i == maxSize)
//        {
//            DataPoint dpt = new DataPoint(i, time);

//            dpt.Label = (time).ToString();
//            dpt.MarkerStyle = MarkerStyle.Circle;
//            dpt.MarkerSize = 8;
//            dpt.BorderWidth = 3;
//            dpt.MarkerColor = Color.DarkBlue;
//            series.Points.Add(dpt);
//        }
//        Console.WriteLine($"{alg.GetType().Name} - Time: {time}ms Ilosc: {i}");


//        series.Points.AddXY(i, time);

//        numerTestu++;
//        this.Text = $"Wykonano {numerTestu} testów";
//    }


//    chart1.Series.Add(series);
//}