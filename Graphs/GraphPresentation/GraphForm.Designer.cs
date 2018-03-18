namespace GraphPresentation
{
	partial class GraphForm
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
			this.textBoxVertexName = new System.Windows.Forms.TextBox();
			this.buttonAddVertex = new System.Windows.Forms.Button();
			this.buttonAddEdge = new System.Windows.Forms.Button();
			this.textBoxVertexFrom = new System.Windows.Forms.TextBox();
			this.textBoxVertexTo = new System.Windows.Forms.TextBox();
			this.labelVertexName = new System.Windows.Forms.Label();
			this.labelVertexFrom = new System.Windows.Forms.Label();
			this.labelVertexTo = new System.Windows.Forms.Label();
			this.dataGridViewGraph = new System.Windows.Forms.DataGridView();
			this.labelWeight = new System.Windows.Forms.Label();
			this.textBoxWeight = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxVertexName
			// 
			this.textBoxVertexName.Location = new System.Drawing.Point(12, 26);
			this.textBoxVertexName.Name = "textBoxVertexName";
			this.textBoxVertexName.Size = new System.Drawing.Size(80, 20);
			this.textBoxVertexName.TabIndex = 0;
			// 
			// buttonAddVertex
			// 
			this.buttonAddVertex.Location = new System.Drawing.Point(98, 24);
			this.buttonAddVertex.Name = "buttonAddVertex";
			this.buttonAddVertex.Size = new System.Drawing.Size(75, 23);
			this.buttonAddVertex.TabIndex = 1;
			this.buttonAddVertex.Text = "Add Vertex";
			this.buttonAddVertex.UseVisualStyleBackColor = true;
			this.buttonAddVertex.Click += new System.EventHandler(this.buttonAddVertex_Click);
			// 
			// buttonAddEdge
			// 
			this.buttonAddEdge.Location = new System.Drawing.Point(407, 24);
			this.buttonAddEdge.Name = "buttonAddEdge";
			this.buttonAddEdge.Size = new System.Drawing.Size(75, 23);
			this.buttonAddEdge.TabIndex = 3;
			this.buttonAddEdge.Text = "Add Edge";
			this.buttonAddEdge.UseVisualStyleBackColor = true;
			this.buttonAddEdge.Click += new System.EventHandler(this.buttonAddEdge_Click);
			// 
			// textBoxVertexFrom
			// 
			this.textBoxVertexFrom.Location = new System.Drawing.Point(235, 26);
			this.textBoxVertexFrom.Name = "textBoxVertexFrom";
			this.textBoxVertexFrom.Size = new System.Drawing.Size(80, 20);
			this.textBoxVertexFrom.TabIndex = 2;
			// 
			// textBoxVertexTo
			// 
			this.textBoxVertexTo.Location = new System.Drawing.Point(321, 26);
			this.textBoxVertexTo.Name = "textBoxVertexTo";
			this.textBoxVertexTo.Size = new System.Drawing.Size(80, 20);
			this.textBoxVertexTo.TabIndex = 4;
			// 
			// labelVertexName
			// 
			this.labelVertexName.AutoSize = true;
			this.labelVertexName.Location = new System.Drawing.Point(12, 9);
			this.labelVertexName.Name = "labelVertexName";
			this.labelVertexName.Size = new System.Drawing.Size(68, 13);
			this.labelVertexName.TabIndex = 5;
			this.labelVertexName.Text = "Vertex Name";
			// 
			// labelVertexFrom
			// 
			this.labelVertexFrom.AutoSize = true;
			this.labelVertexFrom.Location = new System.Drawing.Point(235, 7);
			this.labelVertexFrom.Name = "labelVertexFrom";
			this.labelVertexFrom.Size = new System.Drawing.Size(63, 13);
			this.labelVertexFrom.TabIndex = 6;
			this.labelVertexFrom.Text = "Vertex From";
			// 
			// labelVertexTo
			// 
			this.labelVertexTo.AutoSize = true;
			this.labelVertexTo.Location = new System.Drawing.Point(321, 7);
			this.labelVertexTo.Name = "labelVertexTo";
			this.labelVertexTo.Size = new System.Drawing.Size(53, 13);
			this.labelVertexTo.TabIndex = 7;
			this.labelVertexTo.Text = "Vertex To";
			// 
			// dataGridViewGraph
			// 
			this.dataGridViewGraph.AllowUserToAddRows = false;
			this.dataGridViewGraph.AllowUserToDeleteRows = false;
			this.dataGridViewGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGraph.Location = new System.Drawing.Point(12, 67);
			this.dataGridViewGraph.Name = "dataGridViewGraph";
			this.dataGridViewGraph.ReadOnly = true;
			this.dataGridViewGraph.Size = new System.Drawing.Size(760, 482);
			this.dataGridViewGraph.TabIndex = 8;
			// 
			// labelWeight
			// 
			this.labelWeight.AutoSize = true;
			this.labelWeight.Location = new System.Drawing.Point(188, 7);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new System.Drawing.Size(41, 13);
			this.labelWeight.TabIndex = 10;
			this.labelWeight.Text = "Weight";
			// 
			// textBoxWeight
			// 
			this.textBoxWeight.Location = new System.Drawing.Point(188, 26);
			this.textBoxWeight.Name = "textBoxWeight";
			this.textBoxWeight.Size = new System.Drawing.Size(41, 20);
			this.textBoxWeight.TabIndex = 9;
			// 
			// GraphForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.labelWeight);
			this.Controls.Add(this.textBoxWeight);
			this.Controls.Add(this.dataGridViewGraph);
			this.Controls.Add(this.labelVertexTo);
			this.Controls.Add(this.labelVertexFrom);
			this.Controls.Add(this.labelVertexName);
			this.Controls.Add(this.textBoxVertexTo);
			this.Controls.Add(this.buttonAddEdge);
			this.Controls.Add(this.textBoxVertexFrom);
			this.Controls.Add(this.buttonAddVertex);
			this.Controls.Add(this.textBoxVertexName);
			this.Name = "GraphForm";
			this.Text = "Graph Form";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraph)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxVertexName;
		private System.Windows.Forms.Button buttonAddVertex;
		private System.Windows.Forms.Button buttonAddEdge;
		private System.Windows.Forms.TextBox textBoxVertexFrom;
		private System.Windows.Forms.TextBox textBoxVertexTo;
		private System.Windows.Forms.Label labelVertexName;
		private System.Windows.Forms.Label labelVertexFrom;
		private System.Windows.Forms.Label labelVertexTo;
		private System.Windows.Forms.DataGridView dataGridViewGraph;
		private System.Windows.Forms.Label labelWeight;
		private System.Windows.Forms.TextBox textBoxWeight;
	}
}