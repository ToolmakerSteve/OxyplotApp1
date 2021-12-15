using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OxyplotApp1
{
	public class ReportsClass : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;

		public string Id { get; set; }   // TMS
		public int RowNumber {
			get;
			set;
		}

		public ReportsClass(int rowNumber, string id)
		{
			RowNumber = rowNumber;
			Id = id;   // TMS
		}
		
		public PlotModel Chart {
			get => _chart;
			set {
				_chart = value;
				//if (_chart.PlotView == null && value.PlotView == null) {
				OnPropertyChanged("Chart");
				//}

			}
		}

		public double Sunday { get; internal set; } = 1;

		public PlotModel _chart;// = MainPageViewModel.CreateBarChart();   // TMS


		protected void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) {
				//if (Chart.PlotView == null) {
				handler(this, new PropertyChangedEventArgs(propertyName));
				//}
			}
		}

	}
}
