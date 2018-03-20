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

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = @"Text files | *.xml";
			dialog.Multiselect = false;
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string path = dialog.FileName;
				Txt_PathFile.Text = path;
			}
		}

		private void buttonCreateGraph_Click(object sender, EventArgs e)
		{
			var option = new Options();

			if (ChkXml.Checked)
			{
				if (string.IsNullOrWhiteSpace(Txt_PathFile.Text))
				{
					ShowError("You must select a xml file");
					return;
				}

				var doc = new XmlDocument();
				doc.Load(Txt_PathFile.Text);

				if (!DocSanityCheck(doc))
				{
					ShowError("The Xml has errors");
					return;
				}

				var directedNode = GetNode(doc, "Directed");
				var undirectedNode = GetNode(doc, "Undirected");

				var weightNode = GetNode(doc, "Weight");
				var unweightNode = GetNode(doc, "Unweight");

				var searchNode = GetNode(doc, "Search");
				var bfsNode = GetNode(doc, "BFS");
				var dfsNode = GetNode(doc, "DFS");

				option.SearchOption = bfsNode ? SearchEnum.Bfs : option.SearchOption;
				option.SearchOption = dfsNode ? SearchEnum.Dfs : option.SearchOption;
				option.SearchOption = !searchNode ? SearchEnum.NoSearch : option.SearchOption;

				option.DirectionOption = directedNode ? DirectionEnum.Directed : option.DirectionOption;
				option.DirectionOption = undirectedNode ? DirectionEnum.Undirected : option.DirectionOption;

				option.WheightOption = weightNode ? WeightEnum.Weighted : option.WheightOption;
				option.WheightOption = unweightNode ? WeightEnum.Unweighted : option.WheightOption;
			}
			else
			{
				option.DirectionOption = radioButtonDirected.Checked
					? DirectionEnum.Directed
					: radioButtonUndirected.Checked
						? DirectionEnum.Undirected
						: option.DirectionOption;

				option.WheightOption = radioButtonWeighted.Checked
					? WeightEnum.Weighted
					: radioButtonUnweighted.Checked
						? WeightEnum.Unweighted
						: option.WheightOption;

				option.SearchOption = !checkBoxSearch.Checked
					? SearchEnum.NoSearch
					: radioButtonBfs.Checked
						? SearchEnum.Bfs
						: radioButtonDfs.Checked
							? SearchEnum.Dfs
							: option.SearchOption;
			}

			var gForm = new GraphForm(option);
			gForm.Show();
		}

		private void checkBoxSearch_CheckedChanged(object sender, EventArgs e)
		{
			groupBoxSearch.Enabled = checkBoxSearch.Checked;
		}

		private void ChkManual_CheckedChanged(object sender, EventArgs e)
		{
			ChkXml.Checked = false;
			Gb_Manual.Enabled = true;
			Gb_Xml.Enabled = false;
		}

		private void ChkXml_CheckedChanged(object sender, EventArgs e)
		{
			ChkManual.Checked = false;
			Gb_Manual.Enabled = false;
			Gb_Xml.Enabled = true;
		}

		private bool DocSanityCheck(XmlDocument doc)
		{
			if (!GetNode(doc, "GraphLibrary")) return false;
			if (!GetNode(doc, "GraphType")) return false;
			if (!GetNode(doc, "Type1")) return false;
			if (!GetNode(doc, "Type2")) return false;
			if (GetNode(doc, "Directed") && GetNode(doc, "Undirected")) return false;
			if (GetNode(doc, "Weight") && GetNode(doc, "Unweight")) return false;
			if (GetNode(doc, "Search") && GetNode(doc, "BFS") && GetNode(doc, "DFS")) return false;
			if (GetNode(doc, "Search") && !GetNode(doc, "BFS") && !GetNode(doc, "DFS")) return false;
			if (!GetNode(doc, "Search") && (GetNode(doc, "BFS") || GetNode(doc, "DFS"))) return false;
			if (GetNode(doc, "BFS") && GetNode(doc, "DFS")) return false;
			return true;
		}

		private bool GetNode(XmlDocument doc, string nodeName)
		{
			var nodesAuto = doc.SelectNodes($"//feature[@name='{nodeName}' and @manual='selected']");
			var nodesManual = doc.SelectNodes($"//feature[@name='{nodeName}' and @automatic='selected']");
			var nodes = nodesManual ?? nodesAuto;

			return nodes != null && nodes.Count > 0;
		}

		private void ShowError(string text)
		{
			MessageBox.Show(text);
		}
    }
}