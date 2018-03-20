namespace GraphPresentation
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.labelGraphType = new System.Windows.Forms.Label();
            this.groupBoxType1 = new System.Windows.Forms.GroupBox();
            this.radioButtonUndirected = new System.Windows.Forms.RadioButton();
            this.radioButtonDirected = new System.Windows.Forms.RadioButton();
            this.radioButtonUnweighted = new System.Windows.Forms.RadioButton();
            this.radioButtonWeighted = new System.Windows.Forms.RadioButton();
            this.groupBoxType2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSearch = new System.Windows.Forms.CheckBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radioButtonDfs = new System.Windows.Forms.RadioButton();
            this.radioButtonBfs = new System.Windows.Forms.RadioButton();
            this.labelArrow = new System.Windows.Forms.Label();
            this.buttonCreateGraph = new System.Windows.Forms.Button();
            this.Gb_Manual = new System.Windows.Forms.GroupBox();
            this.ChkManual = new System.Windows.Forms.CheckBox();
            this.Txt_PathFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Gb_Xml = new System.Windows.Forms.GroupBox();
            this.ChkXml = new System.Windows.Forms.CheckBox();
            this.groupBoxType1.SuspendLayout();
            this.groupBoxType2.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.Gb_Manual.SuspendLayout();
            this.Gb_Xml.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGraphType
            // 
            this.labelGraphType.AutoSize = true;
            this.labelGraphType.Location = new System.Drawing.Point(16, 25);
            this.labelGraphType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGraphType.Name = "labelGraphType";
            this.labelGraphType.Size = new System.Drawing.Size(84, 17);
            this.labelGraphType.TabIndex = 0;
            this.labelGraphType.Text = "Graph Type";
            // 
            // groupBoxType1
            // 
            this.groupBoxType1.Controls.Add(this.radioButtonUndirected);
            this.groupBoxType1.Controls.Add(this.radioButtonDirected);
            this.groupBoxType1.Location = new System.Drawing.Point(16, 36);
            this.groupBoxType1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxType1.Name = "groupBoxType1";
            this.groupBoxType1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxType1.Size = new System.Drawing.Size(145, 94);
            this.groupBoxType1.TabIndex = 1;
            this.groupBoxType1.TabStop = false;
            this.groupBoxType1.Text = "Type 1";
            // 
            // radioButtonUndirected
            // 
            this.radioButtonUndirected.AutoSize = true;
            this.radioButtonUndirected.Checked = true;
            this.radioButtonUndirected.Location = new System.Drawing.Point(8, 25);
            this.radioButtonUndirected.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonUndirected.Name = "radioButtonUndirected";
            this.radioButtonUndirected.Size = new System.Drawing.Size(98, 21);
            this.radioButtonUndirected.TabIndex = 1;
            this.radioButtonUndirected.TabStop = true;
            this.radioButtonUndirected.Text = "Undirected";
            this.radioButtonUndirected.UseVisualStyleBackColor = true;
            // 
            // radioButtonDirected
            // 
            this.radioButtonDirected.AutoSize = true;
            this.radioButtonDirected.Location = new System.Drawing.Point(8, 53);
            this.radioButtonDirected.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDirected.Name = "radioButtonDirected";
            this.radioButtonDirected.Size = new System.Drawing.Size(82, 21);
            this.radioButtonDirected.TabIndex = 0;
            this.radioButtonDirected.Text = "Directed";
            this.radioButtonDirected.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnweighted
            // 
            this.radioButtonUnweighted.AutoSize = true;
            this.radioButtonUnweighted.Checked = true;
            this.radioButtonUnweighted.Location = new System.Drawing.Point(8, 26);
            this.radioButtonUnweighted.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonUnweighted.Name = "radioButtonUnweighted";
            this.radioButtonUnweighted.Size = new System.Drawing.Size(103, 21);
            this.radioButtonUnweighted.TabIndex = 1;
            this.radioButtonUnweighted.TabStop = true;
            this.radioButtonUnweighted.Text = "Unweighted";
            this.radioButtonUnweighted.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeighted
            // 
            this.radioButtonWeighted.AutoSize = true;
            this.radioButtonWeighted.Location = new System.Drawing.Point(8, 54);
            this.radioButtonWeighted.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWeighted.Name = "radioButtonWeighted";
            this.radioButtonWeighted.Size = new System.Drawing.Size(89, 21);
            this.radioButtonWeighted.TabIndex = 0;
            this.radioButtonWeighted.Text = "Weighted";
            this.radioButtonWeighted.UseVisualStyleBackColor = true;
            // 
            // groupBoxType2
            // 
            this.groupBoxType2.Controls.Add(this.radioButtonUnweighted);
            this.groupBoxType2.Controls.Add(this.radioButtonWeighted);
            this.groupBoxType2.Location = new System.Drawing.Point(169, 36);
            this.groupBoxType2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxType2.Name = "groupBoxType2";
            this.groupBoxType2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxType2.Size = new System.Drawing.Size(145, 94);
            this.groupBoxType2.TabIndex = 2;
            this.groupBoxType2.TabStop = false;
            this.groupBoxType2.Text = "Type 2";
            // 
            // checkBoxSearch
            // 
            this.checkBoxSearch.AutoSize = true;
            this.checkBoxSearch.Location = new System.Drawing.Point(323, 75);
            this.checkBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSearch.Name = "checkBoxSearch";
            this.checkBoxSearch.Size = new System.Drawing.Size(104, 21);
            this.checkBoxSearch.TabIndex = 3;
            this.checkBoxSearch.Text = "Has Search";
            this.checkBoxSearch.UseVisualStyleBackColor = true;
            this.checkBoxSearch.CheckedChanged += new System.EventHandler(this.checkBoxSearch_CheckedChanged);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.radioButtonDfs);
            this.groupBoxSearch.Controls.Add(this.radioButtonBfs);
            this.groupBoxSearch.Enabled = false;
            this.groupBoxSearch.Location = new System.Drawing.Point(492, 36);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Size = new System.Drawing.Size(145, 94);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Type Search";
            // 
            // radioButtonDfs
            // 
            this.radioButtonDfs.AutoSize = true;
            this.radioButtonDfs.Checked = true;
            this.radioButtonDfs.Location = new System.Drawing.Point(8, 26);
            this.radioButtonDfs.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDfs.Name = "radioButtonDfs";
            this.radioButtonDfs.Size = new System.Drawing.Size(56, 21);
            this.radioButtonDfs.TabIndex = 1;
            this.radioButtonDfs.TabStop = true;
            this.radioButtonDfs.Text = "DFS";
            this.radioButtonDfs.UseVisualStyleBackColor = true;
            // 
            // radioButtonBfs
            // 
            this.radioButtonBfs.AutoSize = true;
            this.radioButtonBfs.Location = new System.Drawing.Point(8, 54);
            this.radioButtonBfs.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonBfs.Name = "radioButtonBfs";
            this.radioButtonBfs.Size = new System.Drawing.Size(55, 21);
            this.radioButtonBfs.TabIndex = 0;
            this.radioButtonBfs.Text = "BFS";
            this.radioButtonBfs.UseVisualStyleBackColor = true;
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Location = new System.Drawing.Point(439, 75);
            this.labelArrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(40, 17);
            this.labelArrow.TabIndex = 4;
            this.labelArrow.Text = "===>";
            // 
            // buttonCreateGraph
            // 
            this.buttonCreateGraph.Location = new System.Drawing.Point(556, 412);
            this.buttonCreateGraph.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateGraph.Name = "buttonCreateGraph";
            this.buttonCreateGraph.Size = new System.Drawing.Size(100, 28);
            this.buttonCreateGraph.TabIndex = 5;
            this.buttonCreateGraph.Text = "Create Graph";
            this.buttonCreateGraph.UseVisualStyleBackColor = true;
            this.buttonCreateGraph.Click += new System.EventHandler(this.buttonCreateGraph_Click);
            // 
            // Gb_Manual
            // 
            this.Gb_Manual.Controls.Add(this.groupBoxType1);
            this.Gb_Manual.Controls.Add(this.groupBoxType2);
            this.Gb_Manual.Controls.Add(this.labelArrow);
            this.Gb_Manual.Controls.Add(this.checkBoxSearch);
            this.Gb_Manual.Controls.Add(this.groupBoxSearch);
            this.Gb_Manual.Location = new System.Drawing.Point(19, 88);
            this.Gb_Manual.Name = "Gb_Manual";
            this.Gb_Manual.Size = new System.Drawing.Size(662, 154);
            this.Gb_Manual.TabIndex = 6;
            this.Gb_Manual.TabStop = false;
            this.Gb_Manual.Text = "Manual";
            // 
            // ChkManual
            // 
            this.ChkManual.AutoSize = true;
            this.ChkManual.Checked = true;
            this.ChkManual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkManual.Location = new System.Drawing.Point(19, 61);
            this.ChkManual.Name = "ChkManual";
            this.ChkManual.Size = new System.Drawing.Size(164, 21);
            this.ChkManual.TabIndex = 7;
            this.ChkManual.Text = "Manual Configuration";
            this.ChkManual.UseVisualStyleBackColor = true;
            this.ChkManual.Click += new System.EventHandler(this.ChkManual_CheckedChanged);
            // 
            // Txt_PathFile
            // 
            this.Txt_PathFile.Location = new System.Drawing.Point(24, 45);
            this.Txt_PathFile.Name = "Txt_PathFile";
            this.Txt_PathFile.Size = new System.Drawing.Size(250, 22);
            this.Txt_PathFile.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gb_Xml
            // 
            this.Gb_Xml.Controls.Add(this.Txt_PathFile);
            this.Gb_Xml.Controls.Add(this.button1);
            this.Gb_Xml.Enabled = false;
            this.Gb_Xml.Location = new System.Drawing.Point(19, 299);
            this.Gb_Xml.Name = "Gb_Xml";
            this.Gb_Xml.Size = new System.Drawing.Size(662, 93);
            this.Gb_Xml.TabIndex = 11;
            this.Gb_Xml.TabStop = false;
            this.Gb_Xml.Text = "XML";
            // 
            // ChkXml
            // 
            this.ChkXml.AutoSize = true;
            this.ChkXml.Location = new System.Drawing.Point(19, 272);
            this.ChkXml.Name = "ChkXml";
            this.ChkXml.Size = new System.Drawing.Size(146, 21);
            this.ChkXml.TabIndex = 12;
            this.ChkXml.Text = "XML Configuration";
            this.ChkXml.UseVisualStyleBackColor = true;
            this.ChkXml.Click += new System.EventHandler(this.ChkXml_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 460);
            this.Controls.Add(this.ChkXml);
            this.Controls.Add(this.Gb_Xml);
            this.Controls.Add(this.buttonCreateGraph);
            this.Controls.Add(this.ChkManual);
            this.Controls.Add(this.Gb_Manual);
            this.Controls.Add(this.labelGraphType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Configuration";
            this.groupBoxType1.ResumeLayout(false);
            this.groupBoxType1.PerformLayout();
            this.groupBoxType2.ResumeLayout(false);
            this.groupBoxType2.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.Gb_Manual.ResumeLayout(false);
            this.Gb_Manual.PerformLayout();
            this.Gb_Xml.ResumeLayout(false);
            this.Gb_Xml.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGraphType;
		private System.Windows.Forms.GroupBox groupBoxType1;
		private System.Windows.Forms.RadioButton radioButtonUndirected;
		private System.Windows.Forms.RadioButton radioButtonDirected;
		private System.Windows.Forms.RadioButton radioButtonUnweighted;
		private System.Windows.Forms.RadioButton radioButtonWeighted;
		private System.Windows.Forms.GroupBox groupBoxType2;
		private System.Windows.Forms.CheckBox checkBoxSearch;
		private System.Windows.Forms.GroupBox groupBoxSearch;
		private System.Windows.Forms.RadioButton radioButtonDfs;
		private System.Windows.Forms.RadioButton radioButtonBfs;
		private System.Windows.Forms.Label labelArrow;
		private System.Windows.Forms.Button buttonCreateGraph;
        private System.Windows.Forms.GroupBox Gb_Manual;
        private System.Windows.Forms.CheckBox ChkManual;
        private System.Windows.Forms.TextBox Txt_PathFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Gb_Xml;
        private System.Windows.Forms.CheckBox ChkXml;
    }
}

