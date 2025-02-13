using System.ComponentModel.DataAnnotations;


namespace andon_ng.Core.Entities
{
    public class TestEntity
    {
        [Key] public Guid Id_entity { get; set; } = Guid.NewGuid();
    }
}

