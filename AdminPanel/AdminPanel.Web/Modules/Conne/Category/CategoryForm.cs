using Serenity.ComponentModel;

namespace AdminPanel.Conne.Forms;

[FormScript("Conne.Category")]
[BasedOnRow(typeof(CategoryRow), CheckNames = true)]
public class CategoryForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
}