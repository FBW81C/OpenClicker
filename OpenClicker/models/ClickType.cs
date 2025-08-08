namespace OpenClicker.Models;

public class ClickType(ClickTypes type)
{
    public ClickTypes Type { get;} = type;
    public string DisplayName { get; } = type.ToString();
}