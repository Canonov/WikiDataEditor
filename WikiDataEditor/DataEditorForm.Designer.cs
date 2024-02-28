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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEditorForm));
			listViewRecords = new ListView();
			columnHeaderName = new ColumnHeader();
			columnHeaderCategory = new ColumnHeader();
			columnHeaderStructure = new ColumnHeader();
			columnHeaderDefinition = new ColumnHeader();
			textBoxName = new TextBox();
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
			labelName = new Label();
			labelCategory = new Label();
			textBoxCategory = new TextBox();
			labelStructure = new Label();
			textBoxStructure = new TextBox();
			labelDefinition = new Label();
			textBoxDefinition = new TextBox();
			groupBoxControls = new GroupBox();
			buttonAdd = new Button();
			buttonDelete = new Button();
			buttonEdit = new Button();
			buttonClear = new Button();
			groupBoxSearch = new GroupBox();
			textBox1 = new TextBox();
			buttonSearch = new Button();
			toolTip1 = new ToolTip(components);
			menuStrip.SuspendLayout();
			groupBoxRecordValues.SuspendLayout();
			groupBoxControls.SuspendLayout();
			groupBoxSearch.SuspendLayout();
			SuspendLayout();
			// 
			// listViewRecords
			// 
			listViewRecords.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderCategory, columnHeaderStructure, columnHeaderDefinition });
			listViewRecords.GridLines = true;
			listViewRecords.Location = new Point(5, 37);
			listViewRecords.Name = "listViewRecords";
			listViewRecords.Size = new Size(320, 434);
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
			// textBoxName
			// 
			textBoxName.Location = new Point(6, 42);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(209, 23);
			textBoxName.TabIndex = 1;
			// 
			// statusStrip1
			// 
			statusStrip1.Location = new Point(0, 474);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(562, 22);
			statusStrip1.TabIndex = 6;
			statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip
			// 
			menuStrip.BackColor = SystemColors.ControlDark;
			menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(562, 24);
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
			groupBoxRecordValues.Controls.Add(labelDefinition);
			groupBoxRecordValues.Controls.Add(textBoxDefinition);
			groupBoxRecordValues.Controls.Add(labelStructure);
			groupBoxRecordValues.Controls.Add(textBoxStructure);
			groupBoxRecordValues.Controls.Add(labelCategory);
			groupBoxRecordValues.Controls.Add(textBoxCategory);
			groupBoxRecordValues.Controls.Add(labelName);
			groupBoxRecordValues.Controls.Add(textBoxName);
			groupBoxRecordValues.Location = new Point(333, 37);
			groupBoxRecordValues.Name = "groupBoxRecordValues";
			groupBoxRecordValues.Size = new Size(221, 221);
			groupBoxRecordValues.TabIndex = 8;
			groupBoxRecordValues.TabStop = false;
			groupBoxRecordValues.Text = "Values";
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Location = new Point(6, 24);
			labelName.Name = "labelName";
			labelName.Size = new Size(39, 15);
			labelName.TabIndex = 2;
			labelName.Text = "Name";
			// 
			// labelCategory
			// 
			labelCategory.AutoSize = true;
			labelCategory.Location = new Point(6, 73);
			labelCategory.Name = "labelCategory";
			labelCategory.Size = new Size(55, 15);
			labelCategory.TabIndex = 4;
			labelCategory.Text = "Category";
			// 
			// textBoxCategory
			// 
			textBoxCategory.Location = new Point(6, 91);
			textBoxCategory.Name = "textBoxCategory";
			textBoxCategory.Size = new Size(209, 23);
			textBoxCategory.TabIndex = 3;
			// 
			// labelStructure
			// 
			labelStructure.AutoSize = true;
			labelStructure.Location = new Point(6, 123);
			labelStructure.Name = "labelStructure";
			labelStructure.Size = new Size(55, 15);
			labelStructure.TabIndex = 6;
			labelStructure.Text = "Structure";
			// 
			// textBoxStructure
			// 
			textBoxStructure.Location = new Point(6, 141);
			textBoxStructure.Name = "textBoxStructure";
			textBoxStructure.Size = new Size(209, 23);
			textBoxStructure.TabIndex = 5;
			// 
			// labelDefinition
			// 
			labelDefinition.AutoSize = true;
			labelDefinition.Location = new Point(6, 171);
			labelDefinition.Name = "labelDefinition";
			labelDefinition.Size = new Size(59, 15);
			labelDefinition.TabIndex = 8;
			labelDefinition.Text = "Definition";
			// 
			// textBoxDefinition
			// 
			textBoxDefinition.Location = new Point(6, 189);
			textBoxDefinition.Name = "textBoxDefinition";
			textBoxDefinition.Size = new Size(209, 23);
			textBoxDefinition.TabIndex = 7;
			// 
			// groupBoxControls
			// 
			groupBoxControls.Controls.Add(buttonEdit);
			groupBoxControls.Controls.Add(buttonClear);
			groupBoxControls.Controls.Add(buttonDelete);
			groupBoxControls.Controls.Add(buttonAdd);
			groupBoxControls.Location = new Point(333, 264);
			groupBoxControls.Name = "groupBoxControls";
			groupBoxControls.Size = new Size(221, 102);
			groupBoxControls.TabIndex = 9;
			groupBoxControls.TabStop = false;
			groupBoxControls.Text = "Controls";
			// 
			// buttonAdd
			// 
			buttonAdd.Location = new Point(9, 20);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(97, 33);
			buttonAdd.TabIndex = 0;
			buttonAdd.Text = "ADD";
			buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonDelete
			// 
			buttonDelete.Location = new Point(112, 20);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(97, 33);
			buttonDelete.TabIndex = 1;
			buttonDelete.Text = "DELETE";
			buttonDelete.UseVisualStyleBackColor = true;
			// 
			// buttonEdit
			// 
			buttonEdit.Location = new Point(112, 59);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(97, 33);
			buttonEdit.TabIndex = 3;
			buttonEdit.Text = "EDIT";
			buttonEdit.UseVisualStyleBackColor = true;
			// 
			// buttonClear
			// 
			buttonClear.Location = new Point(9, 59);
			buttonClear.Name = "buttonClear";
			buttonClear.Size = new Size(97, 33);
			buttonClear.TabIndex = 2;
			buttonClear.Text = "CLEAR";
			buttonClear.UseVisualStyleBackColor = true;
			// 
			// groupBoxSearch
			// 
			groupBoxSearch.Controls.Add(buttonSearch);
			groupBoxSearch.Controls.Add(textBox1);
			groupBoxSearch.Location = new Point(333, 372);
			groupBoxSearch.Name = "groupBoxSearch";
			groupBoxSearch.Size = new Size(221, 99);
			groupBoxSearch.TabIndex = 10;
			groupBoxSearch.TabStop = false;
			groupBoxSearch.Text = "Search";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(6, 30);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(203, 23);
			textBox1.TabIndex = 0;
			// 
			// buttonSearch
			// 
			buttonSearch.Location = new Point(6, 59);
			buttonSearch.Name = "buttonSearch";
			buttonSearch.Size = new Size(203, 23);
			buttonSearch.TabIndex = 1;
			buttonSearch.Text = "SEARCH";
			buttonSearch.UseVisualStyleBackColor = true;
			// 
			// DataEditorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(562, 496);
			Controls.Add(groupBoxSearch);
			Controls.Add(groupBoxControls);
			Controls.Add(groupBoxRecordValues);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip);
			Controls.Add(listViewRecords);
			MainMenuStrip = menuStrip;
			Name = "DataEditorForm";
			Text = "Wiki Data Editor";
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			groupBoxRecordValues.ResumeLayout(false);
			groupBoxRecordValues.PerformLayout();
			groupBoxControls.ResumeLayout(false);
			groupBoxSearch.ResumeLayout(false);
			groupBoxSearch.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView listViewRecords;
		private TextBox textBoxName;
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
		private Label labelDefinition;
		private TextBox textBoxDefinition;
		private Label labelStructure;
		private TextBox textBoxStructure;
		private Label labelCategory;
		private TextBox textBoxCategory;
		private Label labelName;
		private GroupBox groupBoxControls;
		private Button buttonEdit;
		private Button buttonClear;
		private Button buttonDelete;
		private Button buttonAdd;
		private GroupBox groupBoxSearch;
		private Button buttonSearch;
		private TextBox textBox1;
		private ToolTip toolTip1;
	}
}
