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
			recordsListView = new ListView();
			nameColumnHeader = new ColumnHeader();
			categoryColumnHeader = new ColumnHeader();
			nameTextBox = new TextBox();
			statusStrip = new StatusStrip();
			feedbackStatusStrip = new ToolStripStatusLabel();
			topMenuStrip = new MenuStrip();
			toolStripFileMenuItem = new ToolStripMenuItem();
			toolsStripNewButton = new ToolStripMenuItem();
			toolStripOpenButton = new ToolStripMenuItem();
			toolStripSeparator = new ToolStripSeparator();
			toolStripSaveButton = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripExitButton = new ToolStripMenuItem();
			recordValuesGroupBox = new GroupBox();
			definitionLabel = new Label();
			definitionTextBox = new TextBox();
			structureLabel = new Label();
			structureTextBox = new TextBox();
			labelCategory = new Label();
			txtCategory = new TextBox();
			nameLabel = new Label();
			groupBoxControls = new GroupBox();
			editButton = new Button();
			clearButton = new Button();
			deleteButton = new Button();
			addButton = new Button();
			searchGroupBox = new GroupBox();
			searchButton = new Button();
			searchTextBox = new TextBox();
			toolTips = new ToolTip(components);
			statusStrip.SuspendLayout();
			topMenuStrip.SuspendLayout();
			recordValuesGroupBox.SuspendLayout();
			groupBoxControls.SuspendLayout();
			searchGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// listViewRecords
			// 
			recordsListView.BackColor = Color.Gainsboro;
			recordsListView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, categoryColumnHeader });
			recordsListView.Font = new Font("Tahoma", 9F);
			recordsListView.ForeColor = SystemColors.MenuText;
			recordsListView.FullRowSelect = true;
			recordsListView.GridLines = true;
			recordsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			recordsListView.ImeMode = ImeMode.On;
			recordsListView.Location = new Point(232, 35);
			recordsListView.MultiSelect = false;
			recordsListView.Name = "recordsListView";
			recordsListView.Size = new Size(320, 405);
			recordsListView.TabIndex = 0;
			recordsListView.UseCompatibleStateImageBehavior = false;
			recordsListView.View = View.Details;
			recordsListView.SelectedIndexChanged += RecordsListViewOnSelectedIndexChanged;
			// 
			// columnHeaderName
			// 
			nameColumnHeader.Text = "Name";
			nameColumnHeader.Width = 217;
			// 
			// columnHeaderCategory
			// 
			categoryColumnHeader.Text = "Category";
			categoryColumnHeader.Width = 97;
			// 
			// txtName
			// 
			nameTextBox.Font = new Font("Tahoma", 9F);
			nameTextBox.Location = new Point(6, 39);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.PlaceholderText = "NO OBJECT SELECTED";
			nameTextBox.Size = new Size(209, 22);
			nameTextBox.TabIndex = 1;
			nameTextBox.MouseDoubleClick += NameTextBoxOnClick;
			// 
			// statusStrip
			// 
			statusStrip.BackColor = SystemColors.Control;
			statusStrip.Items.AddRange(new ToolStripItem[] { feedbackStatusStrip });
			statusStrip.Location = new Point(0, 441);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(562, 22);
			statusStrip.TabIndex = 6;
			statusStrip.Text = "statusStrip1";
			// 
			// statusStripFeedbackLabel
			// 
			feedbackStatusStrip.AutoSize = false;
			feedbackStatusStrip.Font = new Font("Tahoma", 9F);
			feedbackStatusStrip.Name = "feedbackStatusStrip";
			feedbackStatusStrip.Size = new Size(281, 17);
			feedbackStatusStrip.Text = "Ready...";
			feedbackStatusStrip.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// menuStrip
			// 
			topMenuStrip.BackColor = SystemColors.ScrollBar;
			topMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripFileMenuItem });
			topMenuStrip.Location = new Point(0, 0);
			topMenuStrip.Name = "topMenuStrip";
			topMenuStrip.RenderMode = ToolStripRenderMode.System;
			topMenuStrip.Size = new Size(562, 24);
			topMenuStrip.TabIndex = 7;
			topMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			toolStripFileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolsStripNewButton, toolStripOpenButton, toolStripSeparator, toolStripSaveButton, toolStripSeparator1, toolStripExitButton });
			toolStripFileMenuItem.Font = new Font("Tahoma", 9F);
			toolStripFileMenuItem.Name = "toolStripFileMenuItem";
			toolStripFileMenuItem.Size = new Size(36, 20);
			toolStripFileMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			toolsStripNewButton.Font = new Font("Tahoma", 9F);
			toolsStripNewButton.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
			toolsStripNewButton.ImageTransparentColor = Color.Magenta;
			toolsStripNewButton.Name = "toolsStripNewButton";
			toolsStripNewButton.Size = new Size(200, 22);
			toolsStripNewButton.Text = "Clear all Records";
			toolsStripNewButton.Click += ToolsStripNewButtonOnClick;
			// 
			// openToolStripMenuItem
			// 
			toolStripOpenButton.Font = new Font("Tahoma", 9F);
			toolStripOpenButton.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
			toolStripOpenButton.ImageTransparentColor = Color.Magenta;
			toolStripOpenButton.Name = "toolStripOpenButton";
			toolStripOpenButton.ShortcutKeys = Keys.Control | Keys.O;
			toolStripOpenButton.Size = new Size(200, 22);
			toolStripOpenButton.Text = "&Open from File";
			toolStripOpenButton.Click += ToolStripOpenButtonClick;
			// 
			// toolStripSeparator
			// 
			toolStripSeparator.Name = "toolStripSeparator";
			toolStripSeparator.Size = new Size(197, 6);
			// 
			// saveToolStripMenuItem
			// 
			toolStripSaveButton.Font = new Font("Tahoma", 9F);
			toolStripSaveButton.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
			toolStripSaveButton.ImageTransparentColor = Color.Magenta;
			toolStripSaveButton.Name = "toolStripSaveButton";
			toolStripSaveButton.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
			toolStripSaveButton.Size = new Size(200, 22);
			toolStripSaveButton.Text = "&Save to File";
			toolStripSaveButton.Click += ToolStripSaveButtonClick;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(197, 6);
			// 
			// exitToolStripMenuItem
			// 
			toolStripExitButton.Font = new Font("Tahoma", 9F);
			toolStripExitButton.Name = "toolStripExitButton";
			toolStripExitButton.Size = new Size(200, 22);
			toolStripExitButton.Text = "E&xit";
			// 
			// groupBoxRecordValues
			// 
			recordValuesGroupBox.BackColor = SystemColors.Control;
			recordValuesGroupBox.Controls.Add(definitionLabel);
			recordValuesGroupBox.Controls.Add(definitionTextBox);
			recordValuesGroupBox.Controls.Add(structureLabel);
			recordValuesGroupBox.Controls.Add(structureTextBox);
			recordValuesGroupBox.Controls.Add(labelCategory);
			recordValuesGroupBox.Controls.Add(txtCategory);
			recordValuesGroupBox.Controls.Add(nameLabel);
			recordValuesGroupBox.Controls.Add(nameTextBox);
			recordValuesGroupBox.Font = new Font("Tahoma", 9F);
			recordValuesGroupBox.Location = new Point(5, 35);
			recordValuesGroupBox.Name = "recordValuesGroupBox";
			recordValuesGroupBox.Size = new Size(221, 206);
			recordValuesGroupBox.TabIndex = 8;
			recordValuesGroupBox.TabStop = false;
			recordValuesGroupBox.Text = "Values";
			// 
			// labelDefinition
			// 
			definitionLabel.AutoSize = true;
			definitionLabel.Font = new Font("Tahoma", 9F);
			definitionLabel.Location = new Point(6, 160);
			definitionLabel.Name = "definitionLabel";
			definitionLabel.Size = new Size(58, 14);
			definitionLabel.TabIndex = 8;
			definitionLabel.Text = "Definition";
			// 
			// txtDefinition
			// 
			definitionTextBox.Font = new Font("Tahoma", 9F);
			definitionTextBox.Location = new Point(6, 176);
			definitionTextBox.Name = "definitionTextBox";
			definitionTextBox.PlaceholderText = "Empty...";
			definitionTextBox.Size = new Size(209, 22);
			definitionTextBox.TabIndex = 7;
			// 
			// labelStructure
			// 
			structureLabel.AutoSize = true;
			structureLabel.Font = new Font("Tahoma", 9F);
			structureLabel.Location = new Point(6, 115);
			structureLabel.Name = "structureLabel";
			structureLabel.Size = new Size(59, 14);
			structureLabel.TabIndex = 6;
			structureLabel.Text = "Structure";
			// 
			// txtStructure
			// 
			structureTextBox.Font = new Font("Tahoma", 9F);
			structureTextBox.Location = new Point(6, 132);
			structureTextBox.Name = "structureTextBox";
			structureTextBox.PlaceholderText = "Empty...";
			structureTextBox.Size = new Size(209, 22);
			structureTextBox.TabIndex = 5;
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
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Tahoma", 9F);
			nameLabel.Location = new Point(6, 22);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(38, 14);
			nameLabel.TabIndex = 2;
			nameLabel.Text = "Name";
			// 
			// groupBoxControls
			// 
			groupBoxControls.Controls.Add(editButton);
			groupBoxControls.Controls.Add(clearButton);
			groupBoxControls.Controls.Add(deleteButton);
			groupBoxControls.Controls.Add(addButton);
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
			editButton.Font = new Font("Tahoma", 9F);
			editButton.Location = new Point(112, 55);
			editButton.Name = "editButton";
			editButton.Size = new Size(97, 31);
			editButton.TabIndex = 3;
			editButton.Text = "EDIT";
			editButton.UseVisualStyleBackColor = true;
			editButton.Click += EditButtonOnClick;
			// 
			// btnClear
			// 
			clearButton.Font = new Font("Tahoma", 9F);
			clearButton.Location = new Point(9, 55);
			clearButton.Name = "clearButton";
			clearButton.Size = new Size(97, 31);
			clearButton.TabIndex = 2;
			clearButton.Text = "CLEAR";
			clearButton.UseVisualStyleBackColor = true;
			clearButton.Click += ClearButtonOnClick;
			// 
			// btnDelete
			// 
			deleteButton.Font = new Font("Tahoma", 9F);
			deleteButton.Location = new Point(112, 19);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(97, 31);
			deleteButton.TabIndex = 1;
			deleteButton.Text = "DELETE";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += DeleteButtonOnClick;
			// 
			// btnAdd
			// 
			addButton.Font = new Font("Tahoma", 9F);
			addButton.Location = new Point(9, 19);
			addButton.Name = "addButton";
			addButton.Size = new Size(97, 31);
			addButton.TabIndex = 0;
			addButton.Text = "ADD";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += AddButtonClick;
			// 
			// groupBoxSearch
			// 
			searchGroupBox.Controls.Add(searchButton);
			searchGroupBox.Controls.Add(searchTextBox);
			searchGroupBox.Font = new Font("Tahoma", 9F);
			searchGroupBox.Location = new Point(5, 338);
			searchGroupBox.Name = "searchGroupBox";
			searchGroupBox.Size = new Size(221, 102);
			searchGroupBox.TabIndex = 10;
			searchGroupBox.TabStop = false;
			searchGroupBox.Text = "Search";
			// 
			// btnSearch
			// 
			searchButton.Location = new Point(6, 49);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(203, 21);
			searchButton.TabIndex = 1;
			searchButton.Text = "SEARCH";
			searchButton.UseVisualStyleBackColor = true;
			searchButton.Click += SearchButtonOnClick;
			// 
			// txtSearch
			// 
			searchTextBox.Location = new Point(6, 21);
			searchTextBox.Name = "searchTextBox";
			searchTextBox.PlaceholderText = "Enter Search Query";
			searchTextBox.Size = new Size(203, 22);
			searchTextBox.TabIndex = 0;
			searchTextBox.KeyPress += SearchTextBoxOnKeyPress;
			// 
			// DataEditorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(562, 463);
			Controls.Add(searchGroupBox);
			Controls.Add(groupBoxControls);
			Controls.Add(recordValuesGroupBox);
			Controls.Add(statusStrip);
			Controls.Add(topMenuStrip);
			Controls.Add(recordsListView);
			Font = new Font("Tahoma", 9F);
			MainMenuStrip = topMenuStrip;
			Name = "DataEditorForm";
			Text = "Wiki Data Editor";
			Load += OnFormLoad;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			topMenuStrip.ResumeLayout(false);
			topMenuStrip.PerformLayout();
			recordValuesGroupBox.ResumeLayout(false);
			recordValuesGroupBox.PerformLayout();
			groupBoxControls.ResumeLayout(false);
			searchGroupBox.ResumeLayout(false);
			searchGroupBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView recordsListView;
		private TextBox nameTextBox;
		private StatusStrip statusStrip;
		private MenuStrip topMenuStrip;
		private ColumnHeader nameColumnHeader;
		private ColumnHeader categoryColumnHeader;
		private GroupBox recordValuesGroupBox;
		private ToolStripMenuItem toolStripFileMenuItem;
		private ToolStripMenuItem toolsStripNewButton;
		private ToolStripMenuItem toolStripOpenButton;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripMenuItem toolStripSaveButton;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem toolStripExitButton;
		private Label definitionLabel;
		private TextBox definitionTextBox;
		private Label structureLabel;
		private TextBox structureTextBox;
		private Label labelCategory;
		private TextBox txtCategory;
		private Label nameLabel;
		private GroupBox groupBoxControls;
		private Button editButton;
		private Button clearButton;
		private Button deleteButton;
		private Button addButton;
		private GroupBox searchGroupBox;
		private Button searchButton;
		private TextBox searchTextBox;
		private ToolTip toolTips;
		private ToolStripStatusLabel feedbackStatusStrip;
	}
}
