using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Spokesoft.Clobberfest.Data.Models.Game;

namespace Spokesoft.Clobberfest.Data.Contexts;

public partial class GameDbContext : DbContext
{
    public GameDbContext()
    {
    }

    public GameDbContext(DbContextOptions<GameDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Channel> Channels { get; set; }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Hero> Heros { get; set; }

    public virtual DbSet<Leaderboard> Leaderboards { get; set; }

    public virtual DbSet<Mob> Mobs { get; set; }

    public virtual DbSet<Npc> Npcs { get; set; }

    public virtual DbSet<Season> Seasons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=Clobberfest_Development;Integrated Security=sspi;Encrypt=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
