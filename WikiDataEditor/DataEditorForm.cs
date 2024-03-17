namespace WikiDataEditor;

// Author: 30048254
// Date: 15/03/2024
// Assessment Task 1 - Portfolio : Wiki Data Editor
// Program for editing wiki entries, using a 2d record data structure
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

	private const string DefaultDataFileName = "definitions.dat";

	// 9.1 - 2d Array and Column Indexes
	public const int Rows = 12;
	public const int Columns = 4;
	public static string[,] Records = new string[Rows, Columns];

	private static int _ptr; // represents the next empty cell, starts 0

	public DataEditorForm()
	{
		InitializeComponent();
		InitializeRecords();

		// Fill records with dummy data, for testing stuff.
		for (int row = 0; row < Rows - 4; row++)
		{
			_ptr++;
			Records[row, ColumnsIndex.Name] = $"Row_{row + 1}";

			for (int col = 1; col < Columns; col++)
			{
				if (Random.Shared.Next(0, 2) == 1)
					Records[row, col] = "~";
				else
					Records[row, col] = $"{col}_{row + 1}";
			}
		}

		BubbleSortByNameAsc();
	}

	private void OnFormLoad(object sender, EventArgs e)
	{
		DisplayRecords();
	}

	#region Sorting and Searching

	/// <summary>
	/// Sort the records by name in ascending order - 9.6
	/// </summary>
	private static void BubbleSortByNameAsc()
	{
		for (int row = 0; row < Rows - 1; row++)
		{
			// Flag to check if any swapping occurred in this pass
			bool swapped = false;

			// Loop over the records up to the part unsorted so far
			for (int col = 0; col < Rows - row - 1; col++)
			{
				// Compare the names of the current and next record..
				if (string.Compare(Records[col, ColumnsIndex.Name], Records[col + 1, ColumnsIndex.Name], StringComparison.Ordinal) > 0)
				{
					// ..and if the current record's name is greater than the next one's, swap them
					Swap(col, col + 1);
					swapped = true;
				}
			}

			// If no two elements were swapped, then the list is sorted
			if (!swapped)
				break;
		}
	}
	
	/// <summary>
	/// Binary search for a record by name - 9.7
	/// </summary>
	/// <remarks>Make sure the records are sorted by name beforehand</remarks>
	/// <returns>The index of the row if it's found; -1 if it's not found.</returns>
	private static int BinarySearchForName(string query)
	{
		int left = 0;
		int right = _ptr - 1;
		
		// Continue the search as long as the left boundary does not exceed the right one, if it's not, then it wasn't found.
		while (left <= right)
		{
			int mid = left + (right - left) / 2;

			// Check if the query is present at mid
			int comparison = string.Compare(Records[mid, ColumnsIndex.Name], query, StringComparison.Ordinal);

			switch (comparison)
			{
				// If the names are equal, the record is found
				case 0:
					return mid;
				// query is greater, ignore left half
				case < 0:
					left = mid + 1;
					break;
				// query is smaller, ignore right half
				default:
					right = mid - 1;
					break;
			}
		}

		return -1; // not found
	}

	// SEARCH EVENTS
	private void TxtSearchOnKeyPress(object sender, KeyPressEventArgs e)
	{
		// Redirect it to act as if the search button was pressed if the enter key is.
		if (e.KeyChar == (char)Keys.Enter)
		{
			e.Handled = true;
			BtnSearchOnClick(sender, e);
		}
	}

	// 9.7 - searching
	private void BtnSearchOnClick(object sender, EventArgs e)
	{
		string query = txtSearch.Text;

		txtSearch.Clear();
		txtSearch.Focus();

		// If the query is empty or just a tilde, show an error message and return.
		if (string.IsNullOrWhiteSpace(query) || query == "~")
		{
			MessageBox.Show(@"Please enter a valid search query.", @"Invalid Query",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			statusStripFeedbackLabel.Text = @"Last search failed. No valid query.";
			return;
		}

		// Perform the search.
		int index = BinarySearchForName(query);

		if (index == -1) // Wasn't found
		{
			MessageBox.Show(@$"Search failed, couldn't find ""{query}"" in the records.", @"Search query not found",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			statusStripFeedbackLabel.Text = @$"Search failed, couldn't find ""{query}"" in the records.";
			return;
		}

		// Select the found record
		SelectRecord(index);
	}

	#endregion

	#region Record Array Management
	
	/// <summary>
	/// Set each record to a default value
	/// </summary>
	private static void InitializeRecords()
	{
		_ptr = 0;
		for (int row = 0; row < Rows; row++)
		{
			for (int col = 0; col < Columns; col++)
			{
				Records[row, col] = "~";
			}
		}
	}

	/// <summary>
	/// Checks if a record can be added to the data editor. 9.2
	/// </summary>
	/// <returns>A tuple indicating whether the record can be added and the reason if it cannot be added.</returns>
	private (bool isValid, string? reason) CanAddRecord(string name)
	{
		if (string.IsNullOrWhiteSpace(name) || name == "~")
			return (false, "Name is empty");
		if (_ptr >= Rows)
			return (false, "Insufficient space left in collection.");

		return (true, null);
	}

	/// <summary>
	/// Add a new record to the data editor. 9.2
	/// </summary>
	private void AddRecord(string name, string? category, string? structure, string? definition)
	{
		Records[_ptr, ColumnsIndex.Name] = name;
		Records[_ptr, ColumnsIndex.Category] = category ?? "~";
		Records[_ptr, ColumnsIndex.Structure] = structure ?? "~";
		Records[_ptr, ColumnsIndex.Definition] = definition ?? "~";
		_ptr++;

		ClearTextboxes();
		BubbleSortByNameAsc();
		DisplayRecords();
	}

	// Event handler for add button, checks if it can add first. 9.2
	private void BtnAddClick(object sender, EventArgs e)
	{
		var check = CanAddRecord(txtName.Text);
		if (!check.isValid)
		{
			MessageBox.Show($@"Unable to add because: {check.reason ?? "unknown"}", $@"Unable to add record {txtName.Text} to index {_ptr}",
				MessageBoxButtons.OK, MessageBoxIcon.Error);

			txtName.Focus();
			return;
		}

		AddRecord(txtName.Text, txtCategory.Text, txtStructure.Text, txtDefinition.Text);
	}

	/// <summary>
	/// Delete a record from the data editor - 9.4
	/// </summary>
	private void DeleteRecord(int index)
	{
		for (int col = 0; col < Columns; col++)
		{
			Records[index, col] = "~";
		}
		_ptr--;

		ClearTextboxes();
		BubbleSortByNameAsc();
		DisplayRecords();

		statusStripFeedbackLabel.Text = @"Object deleted successfully.";
	}

	// Event handler for edit button, checks if it can edit first. 9.3
	private void BtnEditOnClick(object sender, EventArgs e)
	{
		if (listViewRecords.SelectedItems.Count == 0)
		{
			MessageBox.Show(@"No Record was selected...", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			statusStripFeedbackLabel.Text = @"No record was selected to edit.";
			return;
		}

		int idx = listViewRecords.SelectedItems[0].Index;
		EditRecord(idx, txtName.Text, txtCategory.Text, txtStructure.Text, txtDefinition.Text);
	}

	/// <summary>
	/// Edit a record at the specificed index - 9.3
	/// </summary>
	private void EditRecord(int index, string name, string? category, string? structure, string? definition)
	{
		Records[index, ColumnsIndex.Name] = name;
		Records[index, ColumnsIndex.Category] = TildeIfEmptyOrNull(category);
		Records[index, ColumnsIndex.Structure] = TildeIfEmptyOrNull(structure);
		Records[index, ColumnsIndex.Definition] = TildeIfEmptyOrNull(definition);

		ClearTextboxes();
		BubbleSortByNameAsc();
		DisplayRecords();

		statusStripFeedbackLabel.Text = @"Edited record successfully.";
	}

	// BUtton Event handler, checks the selection too - 9.4
	private void BtnDeleteOnClick(object sender, EventArgs e)
	{
		if (listViewRecords.SelectedItems.Count < 1)
		{
			MessageBox.Show(@"No record selected", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		int idx = listViewRecords.SelectedItems[0].Index;
		var dialogResult = MessageBox.Show($@"Are you sure you want to delete record {Records[idx, ColumnsIndex.Name]}?",
			null, MessageBoxButtons.YesNo);

		if (dialogResult == DialogResult.Yes)
			DeleteRecord(idx);
		else
			statusStripFeedbackLabel.Text = @"Deletion aborted..";
	}
	
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

	#endregion

	#region File IO

	/// <summary>
	/// Prompt the user to save the file. 9.11
	/// </summary>
	private void PromptFileLoad()
	{
		using var openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = Application.StartupPath;
		openFileDialog.FileName = DefaultDataFileName;
		openFileDialog.Filter = @"data files (*.dat)|*.dat|All files (*.*)|*.*";
		
		if (openFileDialog.ShowDialog() == DialogResult.OK)
			LoadFromFile(openFileDialog.FileName);
		else
			statusStripFeedbackLabel.Text = @"Loading cancelled...";
	}

	/// <summary>
	/// Load the records from a file. 9.11
	/// </summary>
	private void LoadFromFile(string filePath)
	{
		try
		{
			// Open the file for reading
			using var file = new FileStream(filePath, FileMode.Open);
			using var reader = new BinaryReader(file);

			int newPtr = -1;
			string[,] newArray = new string[Rows, Columns];

			// Read data from the file into the newArray
			for (int row = 0; row < Rows; row++)
			{
				for (int col = 0; col < Columns; col++)
				{
					try
					{
						newArray[row, col] = reader.ReadString();

						// If the newPtr has not been set and the current cell is empty, set newPtr to the current row
						if (newPtr == -1 && col == 0 && newArray[row, col] == "~")
							newPtr = row;
					}
					catch (Exception)
					{
						// If an exception occurs while reading, show a message and rethrow the exception
						MessageBox.Show(@$"An Exception occurred while reading at ({row}, {col})");
						throw; // send it up
					}
				}
			}

			// If newPtr was not set, it means the array is probably full, so set it to Rows + 1
			newPtr = newPtr == -1 ? Rows + 1 : newPtr;

			// Assign the newly filled array to Records and update _ptr
			Records = newArray;
			_ptr = newPtr;
			
			DisplayRecords();
			statusStripFeedbackLabel.Text = $@"Loaded data from ""{filePath}""";
		}
		catch (Exception ex)
		{
			MessageBox.Show($@"An unknown error occurred while saving the file: {ex.Message}", @"Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			statusStripFeedbackLabel.Text = $@"Loading failed ({ex.Message})";
		}
	}

	// Event handler for open from file button - 9.11
	private void openToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var result = MessageBox.Show(@"Be warned that opening a file will erase all current records, are you sure?",
			@"Open File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (result == DialogResult.Yes)
			PromptFileLoad();
	}


	/// <summary>
	/// Prompt the user to save the file. 9.10
	/// </summary>
	private void PromptFileSave()
	{
		using var saveFileDialog = new SaveFileDialog();
		saveFileDialog.InitialDirectory = Application.StartupPath;
		saveFileDialog.FileName = DefaultDataFileName;
		saveFileDialog.Filter = @"data files (*.dat)|*.dat|All files (*.*)|*.*";
		saveFileDialog.AddExtension = true;
		saveFileDialog.CheckWriteAccess = true;
		saveFileDialog.DefaultExt = "dat";

		if (_ptr == 0)
		{
			MessageBox.Show(@"No records to save.", @"Unable to save",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}

		if (saveFileDialog.ShowDialog() == DialogResult.OK)
			SaveToFile(saveFileDialog.FileName);
		else
			statusStripFeedbackLabel.Text = @"Saving cancelled...";
	}

	/// <summary>
	/// Save the records to a file. 9.10
	/// </summary>
	private void SaveToFile(string filePath)
	{
		try
		{
			BubbleSortByNameAsc(); // make sure records are sorted

			using (var file = new FileStream(filePath, FileMode.Create))
			using (var writer = new BinaryWriter(file))
			{
				for (int row = 0; row < Rows; row++)
				{
					for (int col = 0; col < Columns; col++)
					{
						writer.Write(Records[row, col]);
					}
				}
			}

			statusStripFeedbackLabel.Text = $@"Saved data to ""{filePath}""";
		}
		catch (Exception ex)
		{
			MessageBox.Show($@"An unknown error occurred while saving the file: {ex.Message}", @"Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			statusStripFeedbackLabel.Text = $@"Saving failed ({ex.Message})";
		}
	}

	// Event to handle the save button - 9.10
	private void saveToolStripMenuItem_Click(object sender, EventArgs e) => PromptFileSave();

	#endregion
	
	#region ListView Management

	// Select a record at the specified index and display it on the textboxes, 9.9 - 2
	private void SelectRecord(int index)
	{
		// used to put nothing instead of the tilde for an empty value.

		// Disconnect the event handler and reconnect it after so it doesn't crash from an infinite loop.
		listViewRecords.SelectedIndexChanged -= ListViewRecordsOnSelectedIndexChanged;
		listViewRecords.SelectedIndices.Clear();
		listViewRecords.Items[index].Selected = true;
		listViewRecords.SelectedIndexChanged += ListViewRecordsOnSelectedIndexChanged;

		txtName.Text = Records[index, ColumnsIndex.Name];
		txtCategory.Text = EmptyIfTilde(Records[index, ColumnsIndex.Category]);
		txtStructure.Text = EmptyIfTilde(Records[index, ColumnsIndex.Structure]);
		txtDefinition.Text = EmptyIfTilde(Records[index, ColumnsIndex.Definition]);
	}

	/// <summary>
	/// Display the names and categories of the records to the listview. 9.8
	/// </summary>
	private void DisplayRecords()
	{
		listViewRecords.Items.Clear();

		for (int row = 0; row < _ptr; row++)
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
	private void ListViewRecordsOnSelectedIndexChanged(object? sender, EventArgs e)
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
	
	#endregion

	#region Miscellaneous Events

	// When the name textbox is double-clicked, offer to clear the textboxes
	private void TxtNameOnClick(object sender, MouseEventArgs e)
	{
		var result = MessageBox.Show(@"Would you like to clear the values?", @"Clear Items",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (result == DialogResult.Yes)
			ClearTextboxes();
	}
	
	// When the user pressed the clear button, clear the textboxes
	private void BtnClearOnClick(object sender, EventArgs e)
	{
		ClearTextboxes();
	}

	// File -> Clear, Clears all records
	private void NewToolStripMenuItemOnClick(object sender, EventArgs e)
	{
		if (MessageBox.Show(@"This will erase ALL data, do you want to continue?", @"Clear",
			    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
		{
			InitializeRecords();
			DisplayRecords();
		}
	}

	#endregion

	#region Utilities

	/// <summary>
	/// Utility method to change a Tilde to an empty string.
	/// </summary>
	private static string EmptyIfTilde(string s) => s == "~" ? "" : s;

	/// <summary>
	/// Utility method to change a string to a tilde if it's empty or null.
	/// </summary>
	private static string TildeIfEmptyOrNull(string? s) => string.IsNullOrEmpty(s) ? "~" : s;
	
	// Clears the currently selected textboxes - 9.5
	private void ClearTextboxes()
	{
		txtName.Clear();
		txtCategory.Clear();
		txtStructure.Clear();
		txtDefinition.Clear();
	}
	
	#endregion
}