﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Spokesoft.Clobberfest.Data.Models.Auth;

[Keyless]
[Table("UserLogins", Schema = "Auth")]
public partial class UserLogin : AuthEntity
{
    public long Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public long CreatedById { get; set; }

    public long UpdatedById { get; set; }

    public DateTime? DeletedById { get; set; }
}
