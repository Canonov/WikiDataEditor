namespace WikiDataEditor;

// 30048254
// Program for editing wiki entries, using a 2d record data structure.

public partial class DataEditorForm : Form
{

	// Pseudo-Enum just so I don't have to use magic numbers
	private static class ColumnsIndex
	{
		public const int Name = 0,
						 Category = 1,
						 Structure = 2,
						 Definition = 3;
	}

	// 9.1 - 2d Array and Column Indexes
	public const int Rows = 12;
	public const int Columns = 4;
	public static string[,] Records = new string[Rows, Columns];

	private static int ptr = 0; // represents the next empty cell

	public DataEditorForm()
	{
		InitializeComponent();
		InitializeRecords();

		// Fill records with dummy data, for testing stuff.
		for (int row = 0; row < Rows - 4; row++)
		{
			ptr++;
			Records[row, ColumnsIndex.Name] = $"Row_{row + 1}";

			for (int col = 1; col < Columns; col++)
			{
				if (Random.Shared.Next(0, 2) == 1)
					Records[row, col] = "~";
				else
					Records[row, col] = $"{col}_{row + 1}";
			}
		}
	}

	private void DataEditorForm_Load(object sender, EventArgs e)
	{
		ListViewDisplayRecords();
	}

	/// <summary>
	/// Set each record to a default value
	/// </summary>
	private static void InitializeRecords()
	{
		for (int row = 0; row < Rows; row++)
		{
			for (int col = 0; col < Columns; col++)
			{
				Records[row, col] = "~";
			}
		}
	}

	#region Sorting and Searching

	/// <summary>
	/// Swap the records at the specified indices in the 2d array - 9.6
	/// </summary>
	private static void Swap(int rowA, int rowB)
	{
		// Deconstruction swap for every value in both rows
		for (int i = 0; i < Columns; i++)
		{
			(Records[rowA, i], Records[rowB, i]) = (Records[rowB, i], Records[rowA, i]);
		}
	}

	/// <summary>
	/// Sort the records by name in ascending order - 9.6
	/// </summary>
	private static void BubbleSortByNameAsc()
	{
		int i, j;
		bool swapped;

		for (i = 0; i < Rows - 1; i++)
		{
			swapped = false;
			for (j = 0; j < Rows - i - 1; j++)
			{
				if (string.Compare(Records[j, ColumnsIndex.Name], Records[j + 1, ColumnsIndex.Name], StringComparison.Ordinal) > 0)
				{
					// Swap row [j] and row [j+1]
					Swap(j, j + 1);
					swapped = true;
				}
			}

			if (!swapped)
				break;
		}

	}

	#endregion

	#region Record Array Management

	private (bool valid, string? reason) CanAddRecord(string name, string? category, string? structure, string? definition)
	{
		if (string.IsNullOrWhiteSpace(name) || name == "~")
			return (false, "Name is empty");
		if (ptr >= Rows)
			return (false, "Insufficient space left in collection.");

		return (true, null);
	}

	private void AddRecord(string name, string? category, string? structure, string? definition)
	{
		Records[ptr, ColumnsIndex.Name] = name;
		Records[ptr, ColumnsIndex.Category] = category ?? "~";
		Records[ptr, ColumnsIndex.Structure] = structure ?? "~";
		Records[ptr, ColumnsIndex.Definition] = definition ?? "~";
		ptr++;
	}

	#endregion

	// Clears the currently selected textboxes - 9.5
	private void ClearTextboxes()
	{
		textBoxName.Clear();
		textBoxCategory.Clear();
		textBoxStructure.Clear();
		textBoxDefinition.Clear();
	}

	// Select a record at the specified index and display it on the textboxes, 9.9 - 2
	private void SelectRecord(int index)
	{
		// used to put nothing instead of the tilde for an empty value.
		static string EmptyIfTilde(string s)
		{
			return s == "~" ? "" : s;
		}

		textBoxName.Text = Records[index, ColumnsIndex.Name];
		textBoxCategory.Text = EmptyIfTilde(Records[index, ColumnsIndex.Category]);
		textBoxStructure.Text = EmptyIfTilde(Records[index, ColumnsIndex.Structure]);
		textBoxDefinition.Text = EmptyIfTilde(Records[index, ColumnsIndex.Definition]);
	}

	/// <summary>
	/// Display the names and categories of the records to the listview. 9.8
	/// </summary>
	private void ListViewDisplayRecords()
	{
		BubbleSortByNameAsc();
		listViewRecords.Items.Clear();

		for (int row = 0; row < ptr; row++)
		{
			// Create an item for the name, and a sub item for the category to display.
			var listViewItem = new ListViewItem
			{
				Tag = row,
				Text = Records[row, ColumnsIndex.Name],
			};

			// Get the category to display, if there is no value, just use N/A as the display value
			string category = Records[row, ColumnsIndex.Category];
			category = category == "~" ? "N/A" : category;

			listViewItem.SubItems.Add(category);
			listViewRecords.Items.Add(listViewItem);
		}

		listViewRecords.Update();
	}

	// When the user selects a record from the list, 9.9 - 1
	private void listViewRecords_SelectedIndexChanged(object sender, EventArgs e)
	{
		// If the user has unselected, clear the textboxes
		if (listViewRecords.SelectedIndices.Count == 0)
		{
			ClearTextboxes();
		}
		else
		{
			int selectedIndex = listViewRecords.SelectedIndices[0];
			SelectRecord(selectedIndex);
		}
	}

	// When the user pressed the clear button, clear the textboxes
	private void buttonClear_Click(object sender, EventArgs e)
	{
		ClearTextboxes();
	}

	// When the name textbox is double-clicked, offer to clear the textboxes
	private void textBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		var result = MessageBox.Show(@"Would you like to clear the values?", @"Clear Items",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (result == DialogResult.Yes)
			ClearTextboxes();
	}
}