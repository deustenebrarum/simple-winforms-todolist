namespace TaskList;

public partial class TaskAddForm : Form
{
    Task? _createdTask = null;

    private TaskAddForm()
    {
        InitializeComponent();
    }

    private void OnCancel(object sender, EventArgs e) => Close();

    private void OnCreate(object sender, EventArgs e)
    {
        _createdTask = new Task(
            _descriptionBox.Text.Trim(),
            _endTimePicker.Value
        );
        Close();
    }

    public static Task? CreateTaskShowDialog()
    {
        TaskAddForm form = new();

        form.ShowDialog();

        return form._createdTask;
    }
}

