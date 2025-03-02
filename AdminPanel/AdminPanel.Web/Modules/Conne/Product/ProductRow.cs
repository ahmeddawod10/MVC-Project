using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanel.Conne;

[ConnectionKey("Conne"), Module("Conne"), TableName("Product")]
[DisplayName("Product"), InstanceName("Product")]
[ReadPermission("Product")]
[ModifyPermission("Product")]
[ServiceLookupPermission("Product")]
public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
{
    const string jCatid = nameof(jCatid);

    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Column("name"), Size(255), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description"), Column("description"), Size(2147483647)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Price"), Column("price"), Size(10), Scale(2), NotNull]
    public decimal? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("Catid"), Column("catid"), ForeignKey(typeof(CategoryRow)), LeftJoin(jCatid), TextualField(nameof(CatidName))]
    [ServiceLookupEditor(typeof(CategoryRow))]
    public int? Catid { get => fields.Catid[this]; set => fields.Catid[this] = value; }

    [DisplayName("Photo"), Column("photo")]
    public string Photo { get => fields.Photo[this]; set => fields.Photo[this] = value; }

    [DisplayName("Catid Name"), Origin(jCatid, nameof(CategoryRow.Name))]
    public string CatidName { get => fields.CatidName[this]; set => fields.CatidName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public DecimalField Price;
        public Int32Field Catid;
        public StringField Photo;

        public StringField CatidName;
    }
}