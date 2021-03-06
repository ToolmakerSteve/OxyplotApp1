using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace OxyplotApp1
{
	public partial class MainPage : ContentPage
	{
		Expander expander;
		ReportsClass item;


		public MainPage()
		{
			InitializeComponent();
			BindingContext = new MainPageViewModel();
		}

		MainPageViewModel VM => (MainPageViewModel)BindingContext;


		public void ClearExpanderAndMaybeReportItem()
		{
			if (expander != null) {
				expander.IsExpanded = false;
				expander = null;
			}
			//if (item != null) {
			//	// Drop previous PlotModel.
			//	item.Chart = null;
			//	item = null;
			//}
		}

		private bool _entered;

		void Expander_Tapped(System.Object sender, System.EventArgs e)
		{
			//if (_entered)
			//	// Too quick: skip it (may lose a user action).
			//	return;

			if (ReferenceEquals(sender, expander)) {
				// User is tapping the existing expander. Don't do anything special.
				return;
			}

			//_entered = true;
			//Device.BeginInvokeOnMainThread(() => {
			//	try {
			_Expander_Tapped(sender);
			//	} catch (Exception) {
			//		_entered = false;
			//	}
			//});
		}

		private void _Expander_Tapped(object sender)
		{
			try {
				ClearExpanderAndMaybeReportItem();

				expander = sender as Expander;

				int index = Convert.ToInt32(expander.ClassId);
				item = VM.KidModels[index];

				if (item.Chart == null) {
					PlotModel model = MainPageViewModel.CreateBarChart();   // TMS
																			//PlotModel model = CreateReportChart(item);
					Action action = () => {
						item.Chart = model;
						//_entered = false;
					};
					if (false) {
						action();
					} else if (false) {
						Device.BeginInvokeOnMainThread(() => {
							action();
						});
					} else {
						Device.StartTimer(TimeSpan.FromSeconds(0.5), () => {
							action();

							return false;
						});
					}
				}

			} catch (Exception) {
				//_entered = false;
			}
		}

		private static PlotModel CreateReportChart(ReportsClass item)
		{
			PlotModel model = new PlotModel();

			CategoryAxis xaxis = new CategoryAxis();
			xaxis.Position = AxisPosition.Bottom;
			xaxis.MajorGridlineStyle = LineStyle.None;
			xaxis.MinorGridlineStyle = LineStyle.None;
			xaxis.MinorTickSize = 0;
			xaxis.MajorTickSize = 0;
			xaxis.TextColor = OxyColors.Gray;
			xaxis.FontSize = 10.0;
			xaxis.Labels.Add("S");
			xaxis.Labels.Add("M");
			xaxis.Labels.Add("T");
			xaxis.Labels.Add("W");
			xaxis.Labels.Add("T");
			xaxis.Labels.Add("F");
			xaxis.Labels.Add("S");
			xaxis.GapWidth = 10.0;
			xaxis.IsPanEnabled = false;
			xaxis.IsZoomEnabled = false;


			LinearAxis yaxis = new LinearAxis();
			yaxis.Position = AxisPosition.Left;
			yaxis.MajorGridlineStyle = LineStyle.None;
			xaxis.MinorGridlineStyle = LineStyle.None;
			yaxis.MinorTickSize = 0;
			yaxis.MajorTickSize = 0;
			yaxis.TextColor = OxyColors.Gray;
			yaxis.FontSize = 10.0;
			yaxis.FontWeight = FontWeights.Bold;
			yaxis.IsZoomEnabled = false;
			yaxis.IsPanEnabled = false;


			ColumnSeries s2 = new ColumnSeries();
			s2.TextColor = OxyColors.Black;

			s2.Items.Add(new ColumnItem {
				Value = item.Sunday,
				Color = OxyColor.Parse("#02cc9d")
			});
			//s2.Items.Add(new ColumnItem {
			//	Value = item.Monday,
			//	Color = OxyColor.Parse("#02cc9d")
			//});
			//s2.Items.Add(new ColumnItem {
			//	Value = item.Tuesday,
			//	Color = OxyColor.Parse("#02cc9d")
			//});
			//s2.Items.Add(new ColumnItem {
			//	Value = item.Wednesday,
			//	Color = OxyColor.Parse("#02cc9d")
			//});
			//s2.Items.Add(new ColumnItem {
			//	Value = item.Thursday,
			//	Color = OxyColor.Parse("#02cc9d")

			//});
			//s2.Items.Add(new ColumnItem {
			//	Value = item.Friday,
			//	Color = OxyColor.Parse("#02cc9d")
			//});
			//s2.Items.Add(new ColumnItem {
			//	Value = item.Saturday,
			//	Color = OxyColor.Parse("#02cc9d")
			//});

			model.Axes.Add(xaxis);
			model.Axes.Add(yaxis);
			model.Series.Add(s2);
			//model.PlotAreaBorderColor = OxyColors.Transparent;
			model.PlotAreaBorderColor = OxyColors.Red;
			return model;
		}
	}
}
