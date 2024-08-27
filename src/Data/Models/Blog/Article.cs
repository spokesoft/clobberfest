using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Spokesoft.Clobberfest.Data.Models.Blog;

[Keyless]
[Table("Articles", Schema = "Blog")]
public partial class Article : BlogEntity
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Content { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public long? CreatedById { get; set; }

    public long? UpdatedById { get; set; }

    public long? DeletedById { get; set; }
}
