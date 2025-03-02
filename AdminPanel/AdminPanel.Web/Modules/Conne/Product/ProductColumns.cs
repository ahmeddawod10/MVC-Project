using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel.Conne.Columns;

[ColumnsScript("Conne.Product")]
[BasedOnRow(typeof(ProductRow), CheckNames = true)]
public class ProductColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string CatidName { get; set; }
    public string Photo { get; set; }
}