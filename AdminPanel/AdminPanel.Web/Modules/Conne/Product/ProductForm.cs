using Serenity.ComponentModel;

namespace AdminPanel.Conne.Forms;

[FormScript("Conne.Product")]
[BasedOnRow(typeof(ProductRow), CheckNames = true)]
public class ProductForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Catid { get; set; }
    public string Photo { get; set; }
}