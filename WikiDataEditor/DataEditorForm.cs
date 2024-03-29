namespace WikiDataEditor;

// Author: 30048254
// Date: 19/03/2024
// Assessment Task 1 - Portfolio : Wiki Data Editor
// Program for editing wiki entries, using a 2d record data structure
public partial class DataEditorForm : Form
{

	// Pseudo-Enum just so I don't have to use magic numbers
	private static class Column
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

	private static int ptr; // represents the next empty cell, starts 0

	public DataEditorForm()
	{
		InitializeComponent();
		InitializeRecords();
	}

	private void OnFormLoad(object sender, EventArgs e)
	{
		RefreshList(false, false);
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
				if (string.Compare(Records[col, Column.Name], Records[col + 1, Column.Name], StringComparison.Ordinal) > 0)
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
		int right = ptr - 1;
		
		// Continue the search as long as the left boundary does not exceed the right one, if it's not, then it wasn't found.
		while (left <= right)
		{
			int mid = left + (right - left) / 2;

			// Check if the query is present at mid
			int comparison = string.Compare(Records[mid, Column.Name], query, StringComparison.Ordinal);

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
				case > 0:
					right = mid - 1;
					break;
			}
		}

		return -1; // not found
	}

	// SEARCH EVENTS
	private void SearchTextBoxOnKeyPress(object sender, KeyPressEventArgs e)
	{
		// Redirect it to act as if the search button was pressed if the enter key is.
		if (e.KeyChar == (char)Keys.Enter)
		{
			e.Handled = true;
			SearchButtonOnClick(sender, e);
		}
	}

	// 9.7 - searching
	private void SearchButtonOnClick(object sender, EventArgs e)
	{
		string query = searchTextBox.Text;

		searchTextBox.Clear();
		searchTextBox.Focus();

		// If the query is empty or just a tilde, show an error message and return.
		if (string.IsNullOrWhiteSpace(query) || query == "~")
		{
			ShowError(@"Please enter a valid search query.");
			feedbackStatusStrip.Text = @"Last search failed. No valid query.";
			return;
		}

		// Perform the search.
		int index = BinarySearchForName(query);

		if (index == -1) // Wasn't found
		{
			ShowError(@$"Search failed, couldn't find ""{query}"" in the records.");
			feedbackStatusStrip.Text = @$"Search failed, couldn't find ""{query}"" in the records.";
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
		ptr = 0;
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
		if (ptr >= Rows)
			return (false, "Insufficient space left in collection.");

		return (true, null);
	}

	/// <summary>
	/// Sets a record at a specified index in the 2D array 'Records'. If the index is null, it adds the record at the next empty cell. 9.2 9.3
	/// </summary>
	private void SetRecordAt(int? index, string name, string? category, string? structure, string? definition)
	{
		// If the index is null then we are adding,
		// so set it to the next empty cell (ptr) and increment ptr
		if (index == null)
		{
			index = ptr;
			ptr++;
		}
		
		Records[index.Value, Column.Name] = name;
		Records[index.Value, Column.Category] = TildeIfEmptyOrNull(category);
		Records[index.Value, Column.Structure] = TildeIfEmptyOrNull(structure);
		Records[index.Value, Column.Definition] = TildeIfEmptyOrNull(definition);

        RefreshList(); // Refresh the list to reflect the changes
	}

	// Event handler for add button, checks if it can add first. 9.2
	private void AddButtonOnClick(object sender, EventArgs e)
	{
		// Check if we can add the record
		var check = CanAddRecord(nameTextBox.Text);
		if (!check.isValid)
		{
			ShowError($@"Unable to add to index {ptr} because: {check.reason ?? "of an unknown error"}.");
			nameTextBox.Focus();
			return;
		}

		// Set the record at the next ptr to this new one.
		SetRecordAt(null, nameTextBox.Text, txtCategory.Text, structureTextBox.Text, definitionTextBox.Text);
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
		ptr--;

		RefreshList();

		feedbackStatusStrip.Text = @"Object deleted successfully.";
	}

	// Event handler for edit button, checks if it can edit first. 9.3
	private void EditButtonOnClick(object sender, EventArgs e)
	{
		if (recordsListView.SelectedItems.Count == 0)
		{
			ShowError(@"No Record was selected...");
			feedbackStatusStrip.Text = @"No record was selected to edit.";
			return;
		}

		int idx = recordsListView.SelectedItems[0].Index;
		SetRecordAt(idx, nameTextBox.Text, txtCategory.Text, structureTextBox.Text, definitionTextBox.Text);
		feedbackStatusStrip.Text = @"Edited record successfully.";
	}

	// BUtton Event handler, checks the selection too - 9.4
	private void DeleteButtonOnClick(object sender, EventArgs e)
	{
		if (recordsListView.SelectedItems.Count < 1)
		{
			ShowError(@"No record selected");
			return;
		}

		int idx = recordsListView.SelectedItems[0].Index;

		if (MessageBox.Show($@"Are you sure you want to delete record {Records[idx, Column.Name]}?", null,
			    MessageBoxButtons.YesNo) != DialogResult.Yes)
		{
			feedbackStatusStrip.Text = @"Deletion aborted..";
			return;
		}

		DeleteRecord(idx);
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
		using var openFile = new OpenFileDialog();
		openFile.InitialDirectory = Application.StartupPath;
		openFile.FileName = DefaultDataFileName;
		openFile.Filter = @"data files (*.dat)|*.dat|All files (*.*)|*.*";
		
		if (openFile.ShowDialog() == DialogResult.OK)
			LoadFromFile(openFile.FileName);
		else
			feedbackStatusStrip.Text = @"Loading cancelled...";
	}

	/// <summary>
	/// Loads data from a file into the Records 2D array. 9.11
	/// </summary>
	private void LoadFromFile(string filePath)
	{
		try
		{
			using var reader = new BinaryReader(File.OpenRead(filePath));

			var newRecords = new string[Rows, Columns];
			int newPtr = -1;

			for (int row = 0; row < Rows; row++)
			{
				for (int col = 0; col < Columns; col++)
				{
					newRecords[row, col] = reader.ReadString();
				}

				if (newPtr == -1 && newRecords[row, 0] == "~")
					newPtr = row;
			}

			Records = newRecords;
			ptr = newPtr == -1 ? Rows : newPtr; // If it was never set, it's full.

			RefreshList();
			feedbackStatusStrip.Text = $@"Loaded data from ""{filePath}""";
		}
		catch (UnauthorizedAccessException ex)
		{
			ShowError($@"Access to the file was denied: {ex.Message}");
			feedbackStatusStrip.Text = $@"Loading failed ({ex.Message})";
		}
		catch (IOException ex)
		{
			ShowError($@"An I/O error occurred: {ex.Message}");
			feedbackStatusStrip.Text = $@"Loading failed ({ex.Message})";
		}
		catch (Exception ex)
		{
			ShowError($@"An error occurred while loading the file: {ex}");
			feedbackStatusStrip.Text = $@"Loading failed ({ex.Message})";
		}
	}

	// Event handler for open from file button - 9.11
	private void ToolStripOpenButtonClick(object sender, EventArgs e)
	{
		if (ptr > 0)
		{
			var result = MessageBox.Show(@"Be warned that opening a file will erase all current records, are you sure?",
				@"Open File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result != DialogResult.Yes)
				return;
		}
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

		if (ptr == 0)
		{
			MessageBox.Show(@"No records to save.", @"Unable to save",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}

		if (saveFileDialog.ShowDialog() == DialogResult.OK)
			SaveToFile(saveFileDialog.FileName);
		else
			feedbackStatusStrip.Text = @"Saving cancelled...";
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

			feedbackStatusStrip.Text = $@"Saved data to ""{filePath}""";
		}
		catch (Exception ex)
		{
			ShowError($@"An unknown error occurred while saving the file:\n {ex}");
			feedbackStatusStrip.Text = $@"Saving failed ({ex.Message})";
		}
	}

	// Event to handle the save button - 9.10
	private void ToolStripSaveButtonClick(object sender, EventArgs e) => PromptFileSave();

	#endregion
	
	#region ListView Management

	// Select a record at the specified index and display it on the textboxes, 9.9 - 2
	private void SelectRecord(int index)
	{
		// used to put nothing instead of the tilde for an empty value.

		// Disconnect the event handler and reconnect it after so it doesn't crash from an infinite loop.
		recordsListView.SelectedIndexChanged -= RecordsListViewOnSelectedIndexChanged;
		recordsListView.SelectedIndices.Clear();
		recordsListView.Items[index].Selected = true;
		recordsListView.SelectedIndexChanged += RecordsListViewOnSelectedIndexChanged;

		nameTextBox.Text = Records[index, Column.Name];
		txtCategory.Text = EmptyIfTilde(Records[index, Column.Category]);
		structureTextBox.Text = EmptyIfTilde(Records[index, Column.Structure]);
		definitionTextBox.Text = EmptyIfTilde(Records[index, Column.Definition]);
	}

	/// <summary>
	/// Display the names and categories of the records to the listview. 9.8
	/// </summary>
	private void DisplayRecords()
	{
		recordsListView.Items.Clear();

		for (int row = 0; row < ptr; row++)
		{
			// Create an item for the name, and a sub item for the category to display.
			var listViewItem = new ListViewItem
			{
				Tag = row,
				Text = Records[row, Column.Name],
			};

			// Get the category to display, if there is no value, just use N/A as the display value
			string category = Records[row, Column.Category];
			category = category == "~" ? "N/A" : category;

			listViewItem.SubItems.Add(category);
			recordsListView.Items.Add(listViewItem);
		}

		recordsListView.Update();
	}

	// When the user selects a record from the list, 9.9 - 1
	private void RecordsListViewOnSelectedIndexChanged(object? sender, EventArgs e)
	{
		// If the user has unselected, clear the textboxes
		if (recordsListView.SelectedIndices.Count == 0)
		{
			ClearTextboxes();
		}
		else
		{
			int selectedIndex = recordsListView.SelectedIndices[0];
			SelectRecord(selectedIndex);
		}
	}
	
	#endregion

	#region Miscellaneous Events

	// When the name textbox is double-clicked, offer to clear the textboxes
	private void NameTextBoxOnClick(object sender, MouseEventArgs e)
	{
		var result = MessageBox.Show(@"Would you like to clear the values?", @"Clear Items",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (result == DialogResult.Yes)
			ClearTextboxes();
	}
	
	// When the user pressed the clear button, clear the textboxes
	private void ClearButtonOnClick(object sender, EventArgs e)
	{
		ClearTextboxes();
	}

	// File -> Clear, Clears all records
	private void ToolsStripNewButtonOnClick(object sender, EventArgs e)
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
		nameTextBox.Clear();
		txtCategory.Clear();
		structureTextBox.Clear();
		definitionTextBox.Clear();
	}
	
	/// <summary>
	/// Refreshes the list view, optionally clearing the textboxes and/or selection, and optionally sorting the array.
	/// </summary>
	/// <param name="clearTextboxes">Whether to clear all text boxes</param>
	/// <param name="sortArray">Whether to bubble sort the array automatically</param>
	/// <param name="clearSelection">Whether to also clear the selection; defaults to false</param>
	private void RefreshList(bool clearTextboxes = true, bool sortArray = true, bool clearSelection = false)
	{
		if (clearTextboxes)
			ClearTextboxes();
		if (clearSelection)
			recordsListView.SelectedIndices.Clear();
		if (sortArray)
			BubbleSortByNameAsc();
		
		DisplayRecords();
	}

	/// <summary>
	/// Shows an error message box containing the message parameter.
	/// </summary>
	private static void ShowError(string message) =>
		MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	
	#endregion
}