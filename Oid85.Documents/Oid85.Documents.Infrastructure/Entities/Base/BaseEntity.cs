using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oid85.Documents.Infrastructure.Entities.Base;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}