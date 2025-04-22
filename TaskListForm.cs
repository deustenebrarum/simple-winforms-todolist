using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace TaskList;

public partial class TaskListForm : Form
{
    private readonly BindingList<Task> _tasks;
    private string _filepath;

    public TaskListForm(string filepath)
    {
        InitializeComponent();

        _filepath = filepath;
        _tasks = JsonSerializer.Deserialize<BindingList<Task>>(LoadJson(_filepath)) ??
            throw new ArgumentNullException($"File {_filepath} is not valid");

        _tasksGridView.DataSource = _tasks;
        _tasks.ListChanged += OnTasksListChanged;
    }

    private static string LoadJson(string filepath)
    {
        if (!File.Exists(filepath))
            return "[]";

        string content = File.ReadAllText(filepath);

        if (string.IsNullOrEmpty(content.Trim()))
            return "[]";

        return content;
    }

    private void OnTaskAdd(object sender, EventArgs e)
    {
        Task? task = TaskAddForm.CreateTaskShowDialog();

        if (task == null)
            return;

        _tasks.Add(task);
    }

    private void OnTasksListChanged(object? sender, ListChangedEventArgs e)
    {
        SaveToJSONFile(_filepath, _tasks);
    }

    private static void SaveToJSONFile(string path, IList<Task> tasks)
    {
        using FileStream file = File.OpenWrite(path);

        using StreamWriter writer = new(file);

        writer.Write(JsonSerializer.Serialize(tasks));
    }
}
