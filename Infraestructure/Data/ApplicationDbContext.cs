namespace Places.Infrastructure.Data;

[ExcludeFromCodeCoverage]
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Continent> Continents { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Translate> Translates { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<Screen> Screens { get; set; }

    public virtual DbSet<Label> Labels { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<DataFile> DataFiles { get; set; }

    public virtual DbSet<Site> Sites { get; set; }
    public virtual DbSet<Comment> Comments { get; set; }
    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Amenity> Amenities { get; set; }

    public virtual DbSet<AmenityBySite> AmenityBySites { get; set; }
    public DbSet<TemporaryImage> TemporaryImages { get; set; }
    public DbSet<TransportOption> TransportOptions { get; set; }
    public DbSet<SelectedTransportOption> SelectedTransportOptions { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<SelectedDate> SelectedDates { get; set; }
    public DbSet<ChatConversation> ChatConversations { get; set; }

    public DbSet<UserChatMessage> UserChatMessages { get; set; }

    public DbSet<ChatMessage> ChatMessages { get; set; }

    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Incident> Incidents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<AdditionalCost>()
        .Property(a => a.Price)
        .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Site>()
            .Property(s => s.AdultPrice)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Site>()
            .Property(s => s.ChildPrice)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Site>()
            .Property(s => s.TotalPrice)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<SelectedTransportOption>()
            .HasOne(sto => sto.Site)
            .WithMany(site => site.SelectedTransportOptions)
            .HasForeignKey(sto => sto.SiteId);

        modelBuilder.Entity<SelectedTransportOption>()
            .HasOne(sto => sto.TransportOption)
            .WithMany(to => to.SelectedTransportOptions)
            .HasForeignKey(sto => sto.TransportOptionId);

        modelBuilder.Entity<Comment>()
          .HasOne(c => c.Site)
          .WithMany(s => s.Comments)
          .HasForeignKey(c => c.SiteId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Comment>()
         .HasOne(c => c.User)
         .WithMany()
         .HasForeignKey(c => c.UserId)
         .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Rating>()
           .HasOne(r => r.Site)
           .WithMany(s => s.Ratings)
           .HasForeignKey(r => r.SiteId)
           .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Rating>()
            .HasOne(r => r.User)
            .WithMany() 
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación uno-a-muchos: ChatConversation <-> ChatMessage
        modelBuilder.Entity<ChatConversation>()
            .HasMany(cc => cc.Messages)
            .WithOne(m => m.Conversation!)
            .HasForeignKey(m => m.ChatConversationId);

        // Relación uno-a-uno  con UserOne
        modelBuilder.Entity<ChatConversation>()
            .HasOne<User>(cc => cc.UserOne!)
            .WithMany()
            .HasForeignKey(cc => cc.UserOneId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación uno-a-uno con UserTwo
        modelBuilder.Entity<ChatConversation>()
            .HasOne<User>(cc => cc.UserTwo!)
            .WithMany()
            .HasForeignKey(cc => cc.UserTwoId)
            .OnDelete(DeleteBehavior.Restrict);

        // Mensaje -> Usuario que envía
        modelBuilder.Entity<ChatMessage>()
            .HasOne(m => m.Sender!)
            .WithMany()
            .HasForeignKey(m => m.SenderUserId);

        modelBuilder.Entity<UserChatMessage>()
           .HasOne(ucm => ucm.ChatMessage)
           .WithMany()
           .HasForeignKey(ucm => ucm.ChatMessageId)
           .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<UserChatMessage>()
            .HasOne(ucm => ucm.User)
            .WithMany()
            .HasForeignKey(ucm => ucm.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Incident>()
          .HasOne(i => i.User)
          .WithMany()
          .HasForeignKey(i => i.UserId)
          .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<Incident>()
            .HasOne(i => i.Site)
            .WithMany(s => s.Incidents)
            .HasForeignKey(i => i.SiteId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Country>()
            .HasOne(c => c.Currency)
            .WithMany() 
            .HasForeignKey(c => c.CurrencyId)
            .IsRequired(false);

        modelBuilder.Entity<Country>()
            .HasOne(c => c.Continent)
            .WithMany(c => c.Countries)
            .HasForeignKey(c => c.ContinentId)
            .IsRequired(false);

        modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly());
    }
}