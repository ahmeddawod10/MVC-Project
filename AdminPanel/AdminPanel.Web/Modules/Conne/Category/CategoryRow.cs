using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanel.Conne;

[ConnectionKey("Conne"), Module("Conne"), TableName("Category")]
[DisplayName("Category"), InstanceName("Category")]
[ReadPermission("Category")]
[ModifyPermission("Category")]
[ServiceLookupPermission("Category")]
public sealed class CategoryRow : Row<CategoryRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Column("name"), Size(255), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description"), Column("description"), Size(2147483647)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Photo"), Column("photo")]
    public string Photo { get => fields.Photo[this]; set => fields.Photo[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public StringField Photo;

    }
}