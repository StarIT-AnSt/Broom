namespace Broom.Core.Models;

using System.Text.Json;

public class Items
{
    private readonly List<Item> _items;

    public Items(List<Item> items) => this._items = items;

    public Items()
    {
        _items = new List<Item>();
    }

    public static Items FromJson(string json) => JsonSerializer.Deserialize<Items>(json); //TODO !!!
}
