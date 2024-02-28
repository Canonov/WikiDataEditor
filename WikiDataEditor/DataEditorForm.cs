namespace WikiDataEditor;

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

	private static int _ptr = 0; // represents the next empty cell

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

	/// <summary>
	/// Display the names and categories of the records to the listview. 9.8
	/// </summary>
	private void ListViewDisplayRecords()
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
}