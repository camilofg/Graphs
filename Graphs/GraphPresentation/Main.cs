using System;
using System.Windows.Forms;
using System.Xml;
using GraphLibrary;

namespace GraphPresentation
{
	public partial class Main : Form
	{
	    private string _routeFile;
		public Main()
		{
			InitializeComponent();
		}

		private void buttonCreateGraph_Click(object sender, EventArgs e)
		{
			var option = new Options();

		    if (ChkXml.Checked)
		    {
		        if (string.IsNullOrEmpty(_routeFile))
		        {
		            MessageBox.Show("The xml config file route has not been selected");
		            return;
		        }

		        XmlDocument doc = new XmlDocument();
		        doc.Load(_routeFile);
		        var test = doc.SelectNodes("//feature[@name='DFS' and @manual='selected']").Count;

		        option.SearchOption = doc.SelectNodes("//feature[@name='DFS' and @manual='selected']").Count != 0
		            ? SearchEnum.Dfs
		            : (doc.SelectNodes("//feature[@name='BFS' and @manual='selected']").Count != 0
		                ? SearchEnum.Bfs
		                : SearchEnum.NoSearch);

		        option.DirectionOption = doc.SelectNodes("//feature[@name='Directed' and @manual='selected']").Count != 0
		            ? DirectionEnum.Directed
		            : DirectionEnum.Undirected;

		        option.WheightOption = doc.SelectNodes("//feature[@name='Weight' and @manual='selected']").Count != 0
		            ? WeightEnum.Weighted
		            : WeightEnum.Unweighted;
		    }

		    else
		    {
                //option.DirectionOption = radioButtonDirected.Checked
                //    ? DirectionEnum.Directed
                //    : radioButtonUndirected.Checked
                //        ? DirectionEnum.Undirected
                //        : throw new Exception("No Direction Selected");

                //option.WheightOption = radioButtonWeighted.Checked
                //    ? WeightEnum.Weighted
                //    : radioButtonUnweighted.Checked
                //        ? WeightEnum.Unweighted
                //        : throw new Exception("No Wheight Selected");

                //option.SearchOption = !checkBoxSearch.Checked
                //    ? SearchEnum.NoSearch
                //     : radioButtonBfs.Checked
                //        ? SearchEnum.Bfs
                //        : radioButtonDfs.Checked
                //            ? SearchEnum.Dfs
                //            : throw new Exception("No Search Selected");
            }

		    var gForm = new GraphForm(option);
			gForm.Show();
		}

		private void checkBoxSearch_CheckedChanged(object sender, EventArgs e)
		{
			groupBoxSearch.Enabled = checkBoxSearch.Checked;
		}

        private void ChkXml_CheckedChanged(object sender, EventArgs e)
        {
            ChkManual.Checked = false;
            Gb_Manual.Enabled = false;
            Gb_Xml.Enabled = true;
        }

        private void ChkManual_CheckedChanged(object sender, EventArgs e)
        {
            ChkXml.Checked = false;
            Gb_Manual.Enabled = true;
            Gb_Xml.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.xml";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                Txt_PathFile.Text = path;
                _routeFile = path;
            }
        }
    }
}