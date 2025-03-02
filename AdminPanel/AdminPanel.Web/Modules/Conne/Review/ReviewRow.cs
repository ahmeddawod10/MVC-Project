using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanel.Conne;

[ConnectionKey("Conne"), Module("Conne"), TableName("Review")]
[DisplayName("Review"), InstanceName("Review")]
[ReadPermission("Review")]
[ModifyPermission("Review")]
[ServiceLookupPermission("Review")]
public sealed class ReviewRow : Row<ReviewRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Column("name"), Size(255), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Email"), Column("email"), Size(50), NotNull]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Subject"), Column("subject"), Size(255)]
    public string Subject { get => fields.Subject[this]; set => fields.Subject[this] = value; }

    [DisplayName("Description"), Column("description"), Size(2147483647)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Email;
        public StringField Subject;
        public StringField Description;

    }
}