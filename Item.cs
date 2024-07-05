namespace BlazorSortableServer;


public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    public int Order { get; set; } = 0;

    public bool Disabled { get; set; } = false;
}