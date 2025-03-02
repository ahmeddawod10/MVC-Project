using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel.Conne.Columns;

[ColumnsScript("Conne.Cart")]
[BasedOnRow(typeof(CartRow), CheckNames = true)]
public class CartColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Userid { get; set; }
    public string ProductidName { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
}