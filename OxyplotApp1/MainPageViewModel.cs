using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OxyplotApp1
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		//private PlotModel graphModel { get; set; }
		//public PlotModel GraphModel {
		//	get {
		//		return graphModel;
		//	}
		//	set {
		//		graphModel = value;
		//	}
		//}

		//public ICommand btnLoadGraph { get; set; }

		public ObservableCollection<ReportsClass> KidModels { get; set; } = new ObservableCollection<ReportsClass>() {
			new ReportsClass(0, "1"),
			new ReportsClass(1, "2"),
			new ReportsClass(2, "3"),
			new ReportsClass(3, "4")
		};


		public MainPageViewModel()
		{
			//GraphModel = new PlotModel();
			//btnLoadGraph = new Command(LoadBarChart);
		}


		//public void LoadBarChart()
		//{
		//	GraphModel = null;
		//	OnPropertyChanged("GraphModel");
		//	PlotModel model = CreateBarChart();

		//	GraphModel = model;
		//	OnPropertyChanged("GraphModel");
		//}

		public static PlotModel CreateBarChart()
		{
			var model = new PlotModel { Title = "Kinds of Pet People Own - Independent Survey." };

			var barSeries = new ColumnSeries {
				LabelPlacement = LabelPlacement.Inside,
				LabelFormatString = "{0}"
			};

			barSeries.Items.Add(new ColumnItem {
				Value = Convert.ToDouble(33),
				Color = OxyColor.Parse("#3498db")
			});

			barSeries.Items.Add(new ColumnItem {
				Value = Convert.ToDouble(196),
				Color = OxyColor.Parse("#2ecc71")
			});

			barSeries.Items.Add(new ColumnItem {
				Value = Convert.ToDouble(152),
				Color = OxyColor.Parse("#9b59b6")
			});

			barSeries.Items.Add(new ColumnItem {
				Value = Convert.ToDouble(62),
				Color = OxyColor.Parse("#34495e")
			});

			barSeries.Items.Add(new ColumnItem {
				Value = Convert.ToDouble(68),
				Color = OxyColor.Parse("#e74c3c")
			});

			barSeries.Items.Add(new ColumnItem {
				Value = Convert.ToDouble(101),
				Color = OxyColor.Parse("#f1c40f")
			});

			model.Series.Add(barSeries);
			String[] strNames = new String[] { "Rabbit", "Dog", "Cat", "Goldfish", "Hamster", "Birds" };
			model.Axes.Add(new CategoryAxis {
				Position = AxisPosition.Bottom,
				Key = "Sample Data",
				ItemsSource = strNames,
				IsPanEnabled = false,
				IsZoomEnabled = false,
				Selectable = false,
			});

			return model;
		}

		#region INotifyChangedProperties
		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		#endregion INotifyChangedProperties
	}
}