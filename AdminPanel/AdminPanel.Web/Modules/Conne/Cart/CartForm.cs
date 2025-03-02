using Serenity.ComponentModel;

namespace AdminPanel.Conne.Forms;

[FormScript("Conne.Cart")]
[BasedOnRow(typeof(CartRow), CheckNames = true)]
public class CartForm
{
    public string Userid { get; set; }
    public int Productid { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
}