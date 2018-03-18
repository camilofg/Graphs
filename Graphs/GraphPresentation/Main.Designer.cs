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
			this.groupBoxType1.SuspendLayout();
			this.groupBoxType2.SuspendLayout();
			this.groupBoxSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelGraphType
			// 
			this.labelGraphType.AutoSize = true;
			this.labelGraphType.Location = new System.Drawing.Point(12, 20);
			this.labelGraphType.Name = "labelGraphType";
			this.labelGraphType.Size = new System.Drawing.Size(63, 13);
			this.labelGraphType.TabIndex = 0;
			this.labelGraphType.Text = "Graph Type";
			// 
			// groupBoxType1
			// 
			this.groupBoxType1.Controls.Add(this.radioButtonUndirected);
			this.groupBoxType1.Controls.Add(this.radioButtonDirected);
			this.groupBoxType1.Location = new System.Drawing.Point(15, 51);
			this.groupBoxType1.Name = "groupBoxType1";
			this.groupBoxType1.Size = new System.Drawing.Size(109, 76);
			this.groupBoxType1.TabIndex = 1;
			this.groupBoxType1.TabStop = false;
			this.groupBoxType1.Text = "Type 1";
			// 
			// radioButtonUndirected
			// 
			this.radioButtonUndirected.AutoSize = true;
			this.radioButtonUndirected.Checked = true;
			this.radioButtonUndirected.Location = new System.Drawing.Point(6, 20);
			this.radioButtonUndirected.Name = "radioButtonUndirected";
			this.radioButtonUndirected.Size = new System.Drawing.Size(77, 17);
			this.radioButtonUndirected.TabIndex = 1;
			this.radioButtonUndirected.TabStop = true;
			this.radioButtonUndirected.Text = "Undirected";
			this.radioButtonUndirected.UseVisualStyleBackColor = true;
			// 
			// radioButtonDirected
			// 
			this.radioButtonDirected.AutoSize = true;
			this.radioButtonDirected.Location = new System.Drawing.Point(6, 43);
			this.radioButtonDirected.Name = "radioButtonDirected";
			this.radioButtonDirected.Size = new System.Drawing.Size(65, 17);
			this.radioButtonDirected.TabIndex = 0;
			this.radioButtonDirected.Text = "Directed";
			this.radioButtonDirected.UseVisualStyleBackColor = true;
			// 
			// radioButtonUnweighted
			// 
			this.radioButtonUnweighted.AutoSize = true;
			this.radioButtonUnweighted.Checked = true;
			this.radioButtonUnweighted.Location = new System.Drawing.Point(6, 21);
			this.radioButtonUnweighted.Name = "radioButtonUnweighted";
			this.radioButtonUnweighted.Size = new System.Drawing.Size(82, 17);
			this.radioButtonUnweighted.TabIndex = 1;
			this.radioButtonUnweighted.TabStop = true;
			this.radioButtonUnweighted.Text = "Unweighted";
			this.radioButtonUnweighted.UseVisualStyleBackColor = true;
			// 
			// radioButtonWeighted
			// 
			this.radioButtonWeighted.AutoSize = true;
			this.radioButtonWeighted.Location = new System.Drawing.Point(6, 44);
			this.radioButtonWeighted.Name = "radioButtonWeighted";
			this.radioButtonWeighted.Size = new System.Drawing.Size(71, 17);
			this.radioButtonWeighted.TabIndex = 0;
			this.radioButtonWeighted.Text = "Weighted";
			this.radioButtonWeighted.UseVisualStyleBackColor = true;
			// 
			// groupBoxType2
			// 
			this.groupBoxType2.Controls.Add(this.radioButtonUnweighted);
			this.groupBoxType2.Controls.Add(this.radioButtonWeighted);
			this.groupBoxType2.Location = new System.Drawing.Point(130, 51);
			this.groupBoxType2.Name = "groupBoxType2";
			this.groupBoxType2.Size = new System.Drawing.Size(109, 76);
			this.groupBoxType2.TabIndex = 2;
			this.groupBoxType2.TabStop = false;
			this.groupBoxType2.Text = "Type 2";
			// 
			// checkBoxSearch
			// 
			this.checkBoxSearch.AutoSize = true;
			this.checkBoxSearch.Location = new System.Drawing.Point(245, 83);
			this.checkBoxSearch.Name = "checkBoxSearch";
			this.checkBoxSearch.Size = new System.Drawing.Size(82, 17);
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
			this.groupBoxSearch.Location = new System.Drawing.Point(372, 51);
			this.groupBoxSearch.Name = "groupBoxSearch";
			this.groupBoxSearch.Size = new System.Drawing.Size(109, 76);
			this.groupBoxSearch.TabIndex = 3;
			this.groupBoxSearch.TabStop = false;
			this.groupBoxSearch.Text = "Type Search";
			// 
			// radioButtonDfs
			// 
			this.radioButtonDfs.AutoSize = true;
			this.radioButtonDfs.Checked = true;
			this.radioButtonDfs.Location = new System.Drawing.Point(6, 21);
			this.radioButtonDfs.Name = "radioButtonDfs";
			this.radioButtonDfs.Size = new System.Drawing.Size(46, 17);
			this.radioButtonDfs.TabIndex = 1;
			this.radioButtonDfs.TabStop = true;
			this.radioButtonDfs.Text = "DFS";
			this.radioButtonDfs.UseVisualStyleBackColor = true;
			// 
			// radioButtonBfs
			// 
			this.radioButtonBfs.AutoSize = true;
			this.radioButtonBfs.Location = new System.Drawing.Point(6, 44);
			this.radioButtonBfs.Name = "radioButtonBfs";
			this.radioButtonBfs.Size = new System.Drawing.Size(45, 17);
			this.radioButtonBfs.TabIndex = 0;
			this.radioButtonBfs.Text = "BFS";
			this.radioButtonBfs.UseVisualStyleBackColor = true;
			// 
			// labelArrow
			// 
			this.labelArrow.AutoSize = true;
			this.labelArrow.Location = new System.Drawing.Point(332, 83);
			this.labelArrow.Name = "labelArrow";
			this.labelArrow.Size = new System.Drawing.Size(31, 13);
			this.labelArrow.TabIndex = 4;
			this.labelArrow.Text = "===>";
			// 
			// buttonCreateGraph
			// 
			this.buttonCreateGraph.Location = new System.Drawing.Point(498, 79);
			this.buttonCreateGraph.Name = "buttonCreateGraph";
			this.buttonCreateGraph.Size = new System.Drawing.Size(75, 23);
			this.buttonCreateGraph.TabIndex = 5;
			this.buttonCreateGraph.Text = "Create Graph";
			this.buttonCreateGraph.UseVisualStyleBackColor = true;
			this.buttonCreateGraph.Click += new System.EventHandler(this.buttonCreateGraph_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 161);
			this.Controls.Add(this.buttonCreateGraph);
			this.Controls.Add(this.labelArrow);
			this.Controls.Add(this.groupBoxSearch);
			this.Controls.Add(this.checkBoxSearch);
			this.Controls.Add(this.groupBoxType2);
			this.Controls.Add(this.groupBoxType1);
			this.Controls.Add(this.labelGraphType);
			this.Name = "Main";
			this.Text = "Configuration";
			this.groupBoxType1.ResumeLayout(false);
			this.groupBoxType1.PerformLayout();
			this.groupBoxType2.ResumeLayout(false);
			this.groupBoxType2.PerformLayout();
			this.groupBoxSearch.ResumeLayout(false);
			this.groupBoxSearch.PerformLayout();
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
	}
}

