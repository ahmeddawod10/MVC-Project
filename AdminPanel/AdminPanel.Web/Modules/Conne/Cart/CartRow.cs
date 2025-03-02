using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanel.Conne;

[ConnectionKey("Conne"), Module("Conne"), TableName("Cart")]
[DisplayName("Cart"), InstanceName("Cart")]
[ReadPermission("Cart")]
[ModifyPermission("Cart")]
[ServiceLookupPermission("Cart")]
public sealed class CartRow : Row<CartRow.RowFields>, IIdRow, INameRow
{
    const string jProductid = nameof(jProductid);

    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Userid"), Column("userid"), Size(50), NotNull, QuickSearch, NameProperty]
    public string Userid { get => fields.Userid[this]; set => fields.Userid[this] = value; }

    [DisplayName("Productid"), Column("productid"), NotNull, ForeignKey(typeof(ProductRow)), LeftJoin(jProductid)]
    [TextualField(nameof(ProductidName)), ServiceLookupEditor(typeof(ProductRow))]
    public int? Productid { get => fields.Productid[this]; set => fields.Productid[this] = value; }

    [DisplayName("Count"), Column("count"), NotNull]
    public int? Count { get => fields.Count[this]; set => fields.Count[this] = value; }

    [DisplayName("Price"), Column("price")]
    public int? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("Productid Name"), Origin(jProductid, nameof(ProductRow.Name))]
    public string ProductidName { get => fields.ProductidName[this]; set => fields.ProductidName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Userid;
        public Int32Field Productid;
        public Int32Field Count;
        public Int32Field Price;

        public StringField ProductidName;
    }
}