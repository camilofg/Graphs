using System;
using System.Windows.Forms;
using GraphLibrary;
using GraphLibrary.Exceptions;
using GraphLibrary.GraphObjects;

namespace GraphPresentation
{
	public partial class GraphForm : Form
	{
		private readonly Graph _graph;
		private readonly Options _options;

		public GraphForm(Options options)
		{
			_options = options;
			InitializeComponent();


			_graph = GraphBuilder.GetGraph(options);

			labelWeight.Visible = options.WheightOption == WeightEnum.Weighted;
			textBoxWeight.Visible = options.WheightOption == WeightEnum.Weighted;
			textBoxWeight.Enabled = options.WheightOption == WeightEnum.Weighted;
		}

		private void buttonAddEdge_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxVertexFrom.Text))
			{
				ShowError("Vertex from can no be empty");
				return;
			}

			if (string.IsNullOrWhiteSpace(textBoxVertexTo.Text))
			{
				ShowError("Vertex to can no be empty");
				return;
			}

			if (_options.WheightOption == WeightEnum.Weighted && string.IsNullOrWhiteSpace(textBoxWeight.Text))
			{
				ShowError("Weight can no be empty");
				return;
			}

			switch (_options.WheightOption)
			{
				case WeightEnum.Weighted:

					int weight;

					if (!int.TryParse(textBoxWeight.Text, out weight))
					{
						ShowError("Weight must be a number");
						return;
					}

					CallGraphLibrary(() => _graph.AddEdge(textBoxVertexFrom.Text, textBoxVertexTo.Text, weight));

					break;

				case WeightEnum.Unweighted:

					CallGraphLibrary(() => _graph.AddEdge(textBoxVertexFrom.Text, textBoxVertexTo.Text));

					break;
			}

			var matrix = CallGraphLibrary(() => _graph.GetGraphView());

			CleanForm();

			PrintGraph(matrix);
		}

		private void buttonAddVertex_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxVertexName.Text))
			{
				ShowError("Vertex name can no be empty");
				return;
			}

			CallGraphLibrary(() => _graph.AddVertex(textBoxVertexName.Text));

			var matrix = CallGraphLibrary(() => _graph.GetGraphView());

			CleanForm();

			PrintGraph(matrix);
		}

		private T CallGraphLibrary<T>(Func<T> func) where T : class
		{
			try
			{
				return func.Invoke();
			}
			catch (GraphException exception)
			{
				ShowError(exception.Message);
				return default(T);
			}
		}

		private void CleanForm()
		{
			textBoxWeight.Text = "";
			textBoxVertexFrom.Text = "";
			textBoxVertexName.Text = "";
			textBoxVertexTo.Text = "";

			dataGridViewGraph.DataSource = null;
			dataGridViewGraph.Rows.Clear();
			dataGridViewGraph.Refresh();
		}

		private void PrintGraph(string[,] matrix)
		{
			var height = matrix.GetLength(0);
			var width = matrix.GetLength(1);

			dataGridViewGraph.ColumnCount = width;

			for (var r = 0; r < height; r++)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dataGridViewGraph);

				for (var c = 0; c < width; c++)
				{
					row.Cells[c].Value = matrix[r, c];

					dataGridViewGraph.Columns[c].Width = 20;
				}

				dataGridViewGraph.Rows.Add(row);
			}
		}

		private void ShowError(string text)
		{
			MessageBox.Show(text);
		}
	}
}