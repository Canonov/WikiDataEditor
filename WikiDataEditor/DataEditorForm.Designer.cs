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
			txtName = new TextBox();
			statusStrip = new StatusStrip();
			statusStripFeedbackLabel = new ToolStripStatusLabel();
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
			txtDefinition = new TextBox();
			labelStructure = new Label();
			txtStructure = new TextBox();
			labelCategory = new Label();
			txtCategory = new TextBox();
			labelName = new Label();
			groupBoxControls = new GroupBox();
			btnEdit = new Button();
			btnClear = new Button();
			btnDelete = new Button();
			btnAdd = new Button();
			groupBoxSearch = new GroupBox();
			btnSearch = new Button();
			txtSearch = new TextBox();
			toolTips = new ToolTip(components);
			statusStrip.SuspendLayout();
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
			listViewRecords.ImeMode = ImeMode.On;
			listViewRecords.Location = new Point(232, 35);
			listViewRecords.MultiSelect = false;
			listViewRecords.Name = "listViewRecords";
			listViewRecords.Size = new Size(320, 405);
			listViewRecords.TabIndex = 0;
			listViewRecords.UseCompatibleStateImageBehavior = false;
			listViewRecords.View = View.Details;
			listViewRecords.SelectedIndexChanged += ListViewRecordsOnSelectedIndexChanged;
			// 
			// columnHeaderName
			// 
			columnHeaderName.Text = "Name";
			columnHeaderName.Width = 217;
			// 
			// columnHeaderCategory
			// 
			columnHeaderCategory.Text = "Category";
			columnHeaderCategory.Width = 97;
			// 
			// txtName
			// 
			txtName.Font = new Font("Tahoma", 9F);
			txtName.Location = new Point(6, 39);
			txtName.Name = "txtName";
			txtName.PlaceholderText = "NO OBJECT SELECTED";
			txtName.Size = new Size(209, 22);
			txtName.TabIndex = 1;
			txtName.MouseDoubleClick += TxtNameOnClick;
			// 
			// statusStrip
			// 
			statusStrip.BackColor = SystemColors.Control;
			statusStrip.Items.AddRange(new ToolStripItem[] { statusStripFeedbackLabel });
			statusStrip.Location = new Point(0, 441);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(562, 22);
			statusStrip.TabIndex = 6;
			statusStrip.Text = "statusStrip1";
			// 
			// statusStripFeedbackLabel
			// 
			statusStripFeedbackLabel.AutoSize = false;
			statusStripFeedbackLabel.Font = new Font("Tahoma", 9F);
			statusStripFeedbackLabel.Name = "statusStripFeedbackLabel";
			statusStripFeedbackLabel.Size = new Size(281, 17);
			statusStripFeedbackLabel.Text = "Ready...";
			statusStripFeedbackLabel.TextAlign = ContentAlignment.MiddleLeft;
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
			newToolStripMenuItem.Text = "Clear all Records";
			newToolStripMenuItem.Click += NewToolStripMenuItemOnClick;
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
			groupBoxRecordValues.Controls.Add(txtDefinition);
			groupBoxRecordValues.Controls.Add(labelStructure);
			groupBoxRecordValues.Controls.Add(txtStructure);
			groupBoxRecordValues.Controls.Add(labelCategory);
			groupBoxRecordValues.Controls.Add(txtCategory);
			groupBoxRecordValues.Controls.Add(labelName);
			groupBoxRecordValues.Controls.Add(txtName);
			groupBoxRecordValues.Font = new Font("Tahoma", 9F);
			groupBoxRecordValues.Location = new Point(5, 35);
			groupBoxRecordValues.Name = "groupBoxRecordValues";
			groupBoxRecordValues.Size = new Size(221, 206);
			groupBoxRecordValues.TabIndex = 8;
			groupBoxRecordValues.TabStop = false;
			groupBoxRecordValues.Text = "Values";
			// 
			// labelDefinition
			// 
			labelDefinition.AutoSize = true;
			labelDefinition.Font = new Font("Tahoma", 9F);
			labelDefinition.Location = new Point(6, 160);
			labelDefinition.Name = "labelDefinition";
			labelDefinition.Size = new Size(58, 14);
			labelDefinition.TabIndex = 8;
			labelDefinition.Text = "Definition";
			// 
			// txtDefinition
			// 
			txtDefinition.Font = new Font("Tahoma", 9F);
			txtDefinition.Location = new Point(6, 176);
			txtDefinition.Name = "txtDefinition";
			txtDefinition.PlaceholderText = "Empty...";
			txtDefinition.Size = new Size(209, 22);
			txtDefinition.TabIndex = 7;
			// 
			// labelStructure
			// 
			labelStructure.AutoSize = true;
			labelStructure.Font = new Font("Tahoma", 9F);
			labelStructure.Location = new Point(6, 115);
			labelStructure.Name = "labelStructure";
			labelStructure.Size = new Size(59, 14);
			labelStructure.TabIndex = 6;
			labelStructure.Text = "Structure";
			// 
			// txtStructure
			// 
			txtStructure.Font = new Font("Tahoma", 9F);
			txtStructure.Location = new Point(6, 132);
			txtStructure.Name = "txtStructure";
			txtStructure.PlaceholderText = "Empty...";
			txtStructure.Size = new Size(209, 22);
			txtStructure.TabIndex = 5;
			// 
			// labelCategory
			// 
			labelCategory.AutoSize = true;
			labelCategory.Font = new Font("Tahoma", 9F);
			labelCategory.Location = new Point(6, 68);
			labelCategory.Name = "labelCategory";
			labelCategory.Size = new Size(56, 14);
			labelCategory.TabIndex = 4;
			labelCategory.Text = "Category";
			// 
			// txtCategory
			// 
			txtCategory.Font = new Font("Tahoma", 9F);
			txtCategory.Location = new Point(6, 85);
			txtCategory.Name = "txtCategory";
			txtCategory.PlaceholderText = "Empty...";
			txtCategory.Size = new Size(209, 22);
			txtCategory.TabIndex = 3;
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Font = new Font("Tahoma", 9F);
			labelName.Location = new Point(6, 22);
			labelName.Name = "labelName";
			labelName.Size = new Size(38, 14);
			labelName.TabIndex = 2;
			labelName.Text = "Name";
			// 
			// groupBoxControls
			// 
			groupBoxControls.Controls.Add(btnEdit);
			groupBoxControls.Controls.Add(btnClear);
			groupBoxControls.Controls.Add(btnDelete);
			groupBoxControls.Controls.Add(btnAdd);
			groupBoxControls.Font = new Font("Tahoma", 9F);
			groupBoxControls.Location = new Point(5, 237);
			groupBoxControls.Name = "groupBoxControls";
			groupBoxControls.Size = new Size(221, 95);
			groupBoxControls.TabIndex = 9;
			groupBoxControls.TabStop = false;
			groupBoxControls.Text = "Controls";
			// 
			// btnEdit
			// 
			btnEdit.Font = new Font("Tahoma", 9F);
			btnEdit.Location = new Point(112, 55);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(97, 31);
			btnEdit.TabIndex = 3;
			btnEdit.Text = "EDIT";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += BtnEditOnClick;
			// 
			// btnClear
			// 
			btnClear.Font = new Font("Tahoma", 9F);
			btnClear.Location = new Point(9, 55);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(97, 31);
			btnClear.TabIndex = 2;
			btnClear.Text = "CLEAR";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += BtnClearOnClick;
			// 
			// btnDelete
			// 
			btnDelete.Font = new Font("Tahoma", 9F);
			btnDelete.Location = new Point(112, 19);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(97, 31);
			btnDelete.TabIndex = 1;
			btnDelete.Text = "DELETE";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += BtnDeleteOnClick;
			// 
			// btnAdd
			// 
			btnAdd.Font = new Font("Tahoma", 9F);
			btnAdd.Location = new Point(9, 19);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(97, 31);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "ADD";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += BtnAddClick;
			// 
			// groupBoxSearch
			// 
			groupBoxSearch.Controls.Add(btnSearch);
			groupBoxSearch.Controls.Add(txtSearch);
			groupBoxSearch.Font = new Font("Tahoma", 9F);
			groupBoxSearch.Location = new Point(5, 338);
			groupBoxSearch.Name = "groupBoxSearch";
			groupBoxSearch.Size = new Size(221, 102);
			groupBoxSearch.TabIndex = 10;
			groupBoxSearch.TabStop = false;
			groupBoxSearch.Text = "Search";
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(6, 49);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(203, 21);
			btnSearch.TabIndex = 1;
			btnSearch.Text = "SEARCH";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += BtnSearchOnClick;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(6, 21);
			txtSearch.Name = "txtSearch";
			txtSearch.PlaceholderText = "Enter Search Query";
			txtSearch.Size = new Size(203, 22);
			txtSearch.TabIndex = 0;
			txtSearch.KeyPress += TxtSearchOnKeyPress;
			// 
			// DataEditorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(562, 463);
			Controls.Add(groupBoxSearch);
			Controls.Add(groupBoxControls);
			Controls.Add(groupBoxRecordValues);
			Controls.Add(statusStrip);
			Controls.Add(menuStrip);
			Controls.Add(listViewRecords);
			Font = new Font("Tahoma", 9F);
			MainMenuStrip = menuStrip;
			Name = "DataEditorForm";
			Text = "Wiki Data Editor";
			Load += OnFormLoad;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
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
		private TextBox txtName;
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
		private TextBox txtDefinition;
		private Label labelStructure;
		private TextBox txtStructure;
		private Label labelCategory;
		private TextBox txtCategory;
		private Label labelName;
		private GroupBox groupBoxControls;
		private Button btnEdit;
		private Button btnClear;
		private Button btnDelete;
		private Button btnAdd;
		private GroupBox groupBoxSearch;
		private Button btnSearch;
		private TextBox txtSearch;
		private ToolTip toolTips;
		private ToolStripStatusLabel statusStripFeedbackLabel;
	}
}
