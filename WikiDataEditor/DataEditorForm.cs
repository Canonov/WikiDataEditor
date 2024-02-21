namespace WikiDataEditor;

public partial class DataEditorForm : Form
{

	// 9.1 - 2d Array and Column Indexes
	public enum ColumnIndex
	{
		Name = 0,
		Category = 1,
		Structure = 2,
		Definition = 3,
	}

	public const int Rows = 12;
	public const int Columns = 4;
	public static string[,] Records = new string[Rows, Columns];

	private static int ptr = 0;

	public DataEditorForm()
	{
		InitializeComponent();
	}
}