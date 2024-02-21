namespace WikiDataEditor
{
	partial class DataEditorForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEditorForm));
			listViewRecords = new ListView();
			columnHeaderName = new ColumnHeader();
			columnHeaderCategory = new ColumnHeader();
			columnHeaderStructure = new ColumnHeader();
			columnHeaderDefinition = new ColumnHeader();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			statusStrip1 = new StatusStrip();
			menuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator = new ToolStripSeparator();
			saveToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			groupBoxRecordValues = new GroupBox();
			menuStrip.SuspendLayout();
			groupBoxRecordValues.SuspendLayout();
			SuspendLayout();
			// 
			// listViewRecords
			// 
			listViewRecords.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderCategory, columnHeaderStructure, columnHeaderDefinition });
			listViewRecords.GridLines = true;
			listViewRecords.Location = new Point(391, 45);
			listViewRecords.Name = "listViewRecords";
			listViewRecords.Size = new Size(320, 426);
			listViewRecords.TabIndex = 0;
			listViewRecords.UseCompatibleStateImageBehavior = false;
			listViewRecords.View = View.Details;
			// 
			// columnHeaderName
			// 
			columnHeaderName.Text = "Name";
			// 
			// columnHeaderCategory
			// 
			columnHeaderCategory.Text = "Category";
			// 
			// columnHeaderStructure
			// 
			columnHeaderStructure.Text = "Structure";
			// 
			// columnHeaderDefinition
			// 
			columnHeaderDefinition.Text = "Definition";
			columnHeaderDefinition.Width = 140;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(10, 22);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(200, 23);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(10, 51);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(200, 23);
			textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(10, 80);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(200, 23);
			textBox3.TabIndex = 3;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(10, 109);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(200, 23);
			textBox4.TabIndex = 4;
			// 
			// statusStrip1
			// 
			statusStrip1.Location = new Point(0, 474);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(721, 22);
			statusStrip1.TabIndex = 6;
			statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip
			// 
			menuStrip.BackColor = SystemColors.ControlDark;
			menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(721, 24);
			menuStrip.TabIndex = 7;
			menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
			newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			newToolStripMenuItem.Size = new Size(196, 22);
			newToolStripMenuItem.Text = "&New File";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
			openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			openToolStripMenuItem.Size = new Size(196, 22);
			openToolStripMenuItem.Text = "&Open from File";
			// 
			// toolStripSeparator
			// 
			toolStripSeparator.Name = "toolStripSeparator";
			toolStripSeparator.Size = new Size(193, 6);
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
			saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(196, 22);
			saveToolStripMenuItem.Text = "Save to File";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(193, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(196, 22);
			exitToolStripMenuItem.Text = "E&xit";
			// 
			// groupBoxRecordValues
			// 
			groupBoxRecordValues.Controls.Add(textBox1);
			groupBoxRecordValues.Controls.Add(textBox4);
			groupBoxRecordValues.Controls.Add(textBox3);
			groupBoxRecordValues.Controls.Add(textBox2);
			groupBoxRecordValues.Location = new Point(12, 37);
			groupBoxRecordValues.Name = "groupBoxRecordValues";
			groupBoxRecordValues.Size = new Size(373, 140);
			groupBoxRecordValues.TabIndex = 8;
			groupBoxRecordValues.TabStop = false;
			groupBoxRecordValues.Text = "Values";
			// 
			// DataEditorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(721, 496);
			Controls.Add(groupBoxRecordValues);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip);
			Controls.Add(listViewRecords);
			MainMenuStrip = menuStrip;
			Name = "DataEditorForm";
			Text = "Form1";
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			groupBoxRecordValues.ResumeLayout(false);
			groupBoxRecordValues.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView listViewRecords;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private StatusStrip statusStrip1;
		private MenuStrip menuStrip;
		private ColumnHeader columnHeaderName;
		private ColumnHeader columnHeaderCategory;
		private ColumnHeader columnHeaderStructure;
		private ColumnHeader columnHeaderDefinition;
		private GroupBox groupBoxRecordValues;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem exitToolStripMenuItem;
	}
}
