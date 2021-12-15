using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Text;

namespace OxyplotApp1
{
	public class ReportsClass
	{
		public PlotModel chart {
			get {
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
				s2.TextColor = OxyColors.White;

				//s2.Items.Add(new ColumnItem {
				//	Value = Sunday,
				//	Color = OxyColor.Parse("#02cc9d")
				//});
				//s2.Items.Add(new ColumnItem {
				//	Value = Monday,
				//	Color = OxyColor.Parse("#02cc9d")
				//});
				//s2.Items.Add(new ColumnItem {
				//	Value = Tuesday,
				//	Color = OxyColor.Parse("#02cc9d")
				//});
				//s2.Items.Add(new ColumnItem {
				//	Value = Wednesday,
				//	Color = OxyColor.Parse("#02cc9d")
				//});
				//s2.Items.Add(new ColumnItem {
				//	Value = Thursday,
				//	Color = OxyColor.Parse("#02cc9d")

				//});
				//s2.Items.Add(new ColumnItem {
				//	Value = Friday,
				//	Color = OxyColor.Parse("#02cc9d")
				//});
				//s2.Items.Add(new ColumnItem {
				//	Value = Saturday,
				//	Color = OxyColor.Parse("#02cc9d")
				//});

				model.Axes.Add(xaxis);
				model.Axes.Add(yaxis);
				model.Series.Add(s2);
				model.PlotAreaBorderColor = OxyColors.Transparent;

				return model;
			}
		}

	}
}
