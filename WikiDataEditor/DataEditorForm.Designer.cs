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
			textBoxName = new TextBox();
			statusStrip = new StatusStrip();
			menuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator = new ToolStripSeparator();
			saveToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			groupBoxRecordValues = new GroupBox();
			labelDefinition = new Label();
			textBoxDefinition = new TextBox();
			labelStructure = new Label();
			textBoxStructure = new TextBox();
			labelCategory = new Label();
			textBoxCategory = new TextBox();
			labelName = new Label();
			groupBoxControls = new GroupBox();
			buttonEdit = new Button();
			buttonClear = new Button();
			buttonDelete = new Button();
			buttonAdd = new Button();
			groupBoxSearch = new GroupBox();
			buttonSearch = new Button();
			textBoxSearch = new TextBox();
			toolTips = new ToolTip(components);
			menuStrip.SuspendLayout();
			groupBoxRecordValues.SuspendLayout();
			groupBoxControls.SuspendLayout();
			groupBoxSearch.SuspendLayout();
			SuspendLayout();
			// 
			// listViewRecords
			// 
			listViewRecords.BackColor = Color.Gainsboro;
			listViewRecords.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderCategory });
			listViewRecords.Font = new Font("Tahoma", 9F);
			listViewRecords.ForeColor = SystemColors.MenuText;
			listViewRecords.FullRowSelect = true;
			listViewRecords.GridLines = true;
			listViewRecords.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			listViewRecords.Location = new Point(232, 37);
			listViewRecords.MultiSelect = false;
			listViewRecords.Name = "listViewRecords";
			listViewRecords.Size = new Size(320, 434);
			listViewRecords.TabIndex = 0;
			listViewRecords.UseCompatibleStateImageBehavior = false;
			listViewRecords.View = View.Details;
			listViewRecords.SelectedIndexChanged += listViewRecords_SelectedIndexChanged;
			// 
			// columnHeaderName
			// 
			columnHeaderName.Text = "Name";
			columnHeaderName.Width = 220;
			// 
			// columnHeaderCategory
			// 
			columnHeaderCategory.Text = "Category";
			columnHeaderCategory.Width = 100;
			// 
			// textBoxName
			// 
			textBoxName.Font = new Font("Tahoma", 9F);
			textBoxName.Location = new Point(6, 42);
			textBoxName.Name = "textBoxName";
			textBoxName.PlaceholderText = "NO OBJECT SELECTED";
			textBoxName.Size = new Size(209, 22);
			textBoxName.TabIndex = 1;
			textBoxName.MouseDoubleClick += textBoxName_MouseDoubleClick;
			// 
			// statusStrip
			// 
			statusStrip.BackColor = SystemColors.Control;
			statusStrip.Location = new Point(0, 474);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(562, 22);
			statusStrip.TabIndex = 6;
			statusStrip.Text = "statusStrip1";
			// 
			// menuStrip
			// 
			menuStrip.BackColor = SystemColors.ScrollBar;
			menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.RenderMode = ToolStripRenderMode.System;
			menuStrip.Size = new Size(562, 24);
			menuStrip.TabIndex = 7;
			menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
			fileToolStripMenuItem.Font = new Font("Tahoma", 9F);
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(36, 20);
			fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Font = new Font("Tahoma", 9F);
			newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
			newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.Size = new Size(200, 22);
			newToolStripMenuItem.Text = "Clear";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Font = new Font("Tahoma", 9F);
			openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
			openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			openToolStripMenuItem.Size = new Size(200, 22);
			openToolStripMenuItem.Text = "&Open from File";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// toolStripSeparator
			// 
			toolStripSeparator.Name = "toolStripSeparator";
			toolStripSeparator.Size = new Size(197, 6);
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Font = new Font("Tahoma", 9F);
			saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
			saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
			saveToolStripMenuItem.Size = new Size(200, 22);
			saveToolStripMenuItem.Text = "&Save to File";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(197, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Font = new Font("Tahoma", 9F);
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(200, 22);
			exitToolStripMenuItem.Text = "E&xit";
			// 
			// groupBoxRecordValues
			// 
			groupBoxRecordValues.BackColor = SystemColors.Control;
			groupBoxRecordValues.Controls.Add(labelDefinition);
			groupBoxRecordValues.Controls.Add(textBoxDefinition);
			groupBoxRecordValues.Controls.Add(labelStructure);
			groupBoxRecordValues.Controls.Add(textBoxStructure);
			groupBoxRecordValues.Controls.Add(labelCategory);
			groupBoxRecordValues.Controls.Add(textBoxCategory);
			groupBoxRecordValues.Controls.Add(labelName);
			groupBoxRecordValues.Controls.Add(textBoxName);
			groupBoxRecordValues.Font = new Font("Tahoma", 9F);
			groupBoxRecordValues.Location = new Point(5, 37);
			groupBoxRecordValues.Name = "groupBoxRecordValues";
			groupBoxRecordValues.Size = new Size(221, 221);
			groupBoxRecordValues.TabIndex = 8;
			groupBoxRecordValues.TabStop = false;
			groupBoxRecordValues.Text = "Values";
			// 
			// labelDefinition
			// 
			labelDefinition.AutoSize = true;
			labelDefinition.Font = new Font("Tahoma", 9F);
			labelDefinition.Location = new Point(6, 171);
			labelDefinition.Name = "labelDefinition";
			labelDefinition.Size = new Size(58, 14);
			labelDefinition.TabIndex = 8;
			labelDefinition.Text = "Definition";
			// 
			// textBoxDefinition
			// 
			textBoxDefinition.Font = new Font("Tahoma", 9F);
			textBoxDefinition.Location = new Point(6, 189);
			textBoxDefinition.Name = "textBoxDefinition";
			textBoxDefinition.PlaceholderText = "Empty...";
			textBoxDefinition.Size = new Size(209, 22);
			textBoxDefinition.TabIndex = 7;
			// 
			// labelStructure
			// 
			labelStructure.AutoSize = true;
			labelStructure.Font = new Font("Tahoma", 9F);
			labelStructure.Location = new Point(6, 123);
			labelStructure.Name = "labelStructure";
			labelStructure.Size = new Size(59, 14);
			labelStructure.TabIndex = 6;
			labelStructure.Text = "Structure";
			// 
			// textBoxStructure
			// 
			textBoxStructure.Font = new Font("Tahoma", 9F);
			textBoxStructure.Location = new Point(6, 141);
			textBoxStructure.Name = "textBoxStructure";
			textBoxStructure.PlaceholderText = "Empty...";
			textBoxStructure.Size = new Size(209, 22);
			textBoxStructure.TabIndex = 5;
			// 
			// labelCategory
			// 
			labelCategory.AutoSize = true;
			labelCategory.Font = new Font("Tahoma", 9F);
			labelCategory.Location = new Point(6, 73);
			labelCategory.Name = "labelCategory";
			labelCategory.Size = new Size(56, 14);
			labelCategory.TabIndex = 4;
			labelCategory.Text = "Category";
			// 
			// textBoxCategory
			// 
			textBoxCategory.Font = new Font("Tahoma", 9F);
			textBoxCategory.Location = new Point(6, 91);
			textBoxCategory.Name = "textBoxCategory";
			textBoxCategory.PlaceholderText = "Empty...";
			textBoxCategory.Size = new Size(209, 22);
			textBoxCategory.TabIndex = 3;
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Font = new Font("Tahoma", 9F);
			labelName.Location = new Point(6, 24);
			labelName.Name = "labelName";
			labelName.Size = new Size(38, 14);
			labelName.TabIndex = 2;
			labelName.Text = "Name";
			// 
			// groupBoxControls
			// 
			groupBoxControls.Controls.Add(buttonEdit);
			groupBoxControls.Controls.Add(buttonClear);
			groupBoxControls.Controls.Add(buttonDelete);
			groupBoxControls.Controls.Add(buttonAdd);
			groupBoxControls.Font = new Font("Tahoma", 9F);
			groupBoxControls.Location = new Point(5, 254);
			groupBoxControls.Name = "groupBoxControls";
			groupBoxControls.Size = new Size(221, 102);
			groupBoxControls.TabIndex = 9;
			groupBoxControls.TabStop = false;
			groupBoxControls.Text = "Controls";
			// 
			// buttonEdit
			// 
			buttonEdit.Font = new Font("Tahoma", 9F);
			buttonEdit.Location = new Point(112, 59);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(97, 33);
			buttonEdit.TabIndex = 3;
			buttonEdit.Text = "EDIT";
			buttonEdit.UseVisualStyleBackColor = true;
			// 
			// buttonClear
			// 
			buttonClear.Font = new Font("Tahoma", 9F);
			buttonClear.Location = new Point(9, 59);
			buttonClear.Name = "buttonClear";
			buttonClear.Size = new Size(97, 33);
			buttonClear.TabIndex = 2;
			buttonClear.Text = "CLEAR";
			buttonClear.UseVisualStyleBackColor = true;
			buttonClear.Click += buttonClear_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.Font = new Font("Tahoma", 9F);
			buttonDelete.Location = new Point(112, 20);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(97, 33);
			buttonDelete.TabIndex = 1;
			buttonDelete.Text = "DELETE";
			buttonDelete.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			buttonAdd.Font = new Font("Tahoma", 9F);
			buttonAdd.Location = new Point(9, 20);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(97, 33);
			buttonAdd.TabIndex = 0;
			buttonAdd.Text = "ADD";
			buttonAdd.UseVisualStyleBackColor = true;
			// 
			// groupBoxSearch
			// 
			groupBoxSearch.Controls.Add(buttonSearch);
			groupBoxSearch.Controls.Add(textBoxSearch);
			groupBoxSearch.Font = new Font("Tahoma", 9F);
			groupBoxSearch.Location = new Point(5, 362);
			groupBoxSearch.Name = "groupBoxSearch";
			groupBoxSearch.Size = new Size(221, 109);
			groupBoxSearch.TabIndex = 10;
			groupBoxSearch.TabStop = false;
			groupBoxSearch.Text = "Search";
			// 
			// buttonSearch
			// 
			buttonSearch.Location = new Point(6, 52);
			buttonSearch.Name = "buttonSearch";
			buttonSearch.Size = new Size(203, 23);
			buttonSearch.TabIndex = 1;
			buttonSearch.Text = "SEARCH";
			buttonSearch.UseVisualStyleBackColor = true;
			buttonSearch.Click += buttonSearch_Click;
			// 
			// textBoxSearch
			// 
			textBoxSearch.Location = new Point(6, 23);
			textBoxSearch.Name = "textBoxSearch";
			textBoxSearch.PlaceholderText = "Enter Search Query";
			textBoxSearch.Size = new Size(203, 22);
			textBoxSearch.TabIndex = 0;
			textBoxSearch.KeyPress += textBoxSearch_KeyPress;
			// 
			// DataEditorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(562, 496);
			Controls.Add(groupBoxSearch);
			Controls.Add(groupBoxControls);
			Controls.Add(groupBoxRecordValues);
			Controls.Add(statusStrip);
			Controls.Add(menuStrip);
			Controls.Add(listViewRecords);
			MainMenuStrip = menuStrip;
			Name = "DataEditorForm";
			Text = "Wiki Data Editor";
			Load += DataEditorForm_Load;
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
		private StatusStrip statusStrip;
		private MenuStrip menuStrip;
		private ColumnHeader columnHeaderName;
		private ColumnHeader columnHeaderCategory;
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
		private TextBox textBoxSearch;
		private ToolTip toolTips;
	}
}
