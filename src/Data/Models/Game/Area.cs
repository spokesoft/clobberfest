using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Spokesoft.Clobberfest.Data.Models.Game;

[Keyless]
[Table("Areas", Schema = "Game")]
public partial class Area : GameEntity
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public long CreatedById { get; set; }

    public long UpdatedById { get; set; }

    public DateTime? DeletedById { get; set; }
}
