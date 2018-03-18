using System;
using System.Windows.Forms;
using GraphLibrary;

namespace GraphPresentation
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void buttonCreateGraph_Click(object sender, EventArgs e)
		{
			var option = new Options();

			option.DirectionOption = radioButtonDirected.Checked
				? DirectionEnum.Directed
				: radioButtonUndirected.Checked
					? DirectionEnum.Undirected
					: throw new Exception("No Direction Selected");

			option.WheightOption = radioButtonWeighted.Checked
				? WeightEnum.Weighted
				: radioButtonUnweighted.Checked
					? WeightEnum.Unweighted
					: throw new Exception("No Wheight Selected");

			option.SearchOption = !checkBoxSearch.Checked
				? SearchEnum.NoSearch
				 : radioButtonBfs.Checked
					? SearchEnum.Bfs
					: radioButtonDfs.Checked
						? SearchEnum.Dfs
						: throw new Exception("No Search Selected");

			var gForm = new GraphForm(option);
			gForm.Show();
		}

		private void checkBoxSearch_CheckedChanged(object sender, EventArgs e)
		{
			groupBoxSearch.Enabled = checkBoxSearch.Checked;
		}
	}
}