using System;
using System.Windows.Forms;
using System.Xml;
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

		    XmlDocument doc = new XmlDocument();
		    doc.Load("C:\\Users\\raul.forero\\Documents\\configs\\default.xml");
            var option = new Options();
		    var test = doc.SelectNodes("//feature[@name='DFS' and @manual='selected']");

            option.SearchOption = doc.SelectNodes("//feature[@name='DFS' and @manual='selected']") != null ? SearchEnum.Dfs : (doc.SelectNodes("//feature[@name='BFS' and @manual='selected']") != null ? SearchEnum.Bfs : SearchEnum.NoSearch);

		    option.DirectionOption = doc.SelectNodes("//feature[@name='Directed' and @manual='selected']") != null
		        ? DirectionEnum.Directed
		        : DirectionEnum.Undirected;

		    option.WheightOption = doc.SelectNodes("//feature[@name='Weight' and @manual='selected']") != null
		        ? WeightEnum.Weighted
		        : WeightEnum.Unweighted;
            /*
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
            */
            var gForm = new GraphForm(option);
			gForm.Show();
		}

		private void checkBoxSearch_CheckedChanged(object sender, EventArgs e)
		{
			groupBoxSearch.Enabled = checkBoxSearch.Checked;
		}
	}
}