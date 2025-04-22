namespace TaskList;

[Serializable]
public class Task(string description, DateTime endDate)
{
    public string Description { get; set; } = description;
    public DateTime EndDate { get; set; } = endDate;
}
