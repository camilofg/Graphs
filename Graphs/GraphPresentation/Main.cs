﻿using System;
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

			//XmlDocument doc = new XmlDocument();
			//doc.Load("C:\\Users\\raul.forero\\Documents\\configs\\default.xml");
			//var test = doc.SelectNodes("//feature[@name='DFS' and @manual='selected']").Count;

			//      option.SearchOption = doc.SelectNodes("//feature[@name='DFS' and @manual='selected']").Count != 0 ? SearchEnum.Dfs : (doc.SelectNodes("//feature[@name='BFS' and @manual='selected']").Count != 0 ? SearchEnum.Bfs : SearchEnum.NoSearch);

			//option.DirectionOption = doc.SelectNodes("//feature[@name='Directed' and @manual='selected']").Count != 0
			//    ? DirectionEnum.Directed
			//    : DirectionEnum.Undirected;

			//option.WheightOption = doc.SelectNodes("//feature[@name='Weight' and @manual='selected']").Count != 0
			//    ? WeightEnum.Weighted
			//    : WeightEnum.Unweighted;

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