using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentSys.Models.Payments;
using RentSys.Models.Property;
using RentSys.Models.Screening;
using RentSys.Models.UserManagement;

namespace RentSys.Data
{
  public class RentSysContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
  {
    public RentSysContext(DbContextOptions<RentSysContext> options)
        : base(options)
    {
    }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<PaymentMethod> PaymentMethods { get; set; }
    // Add DbSets for other entities here
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<PaymentMethod>(entity =>
      {
        entity.HasKey(e => e.PaymentMethodId);
        entity.Property(e => e.MethodName).IsRequired().HasMaxLength(50);
      });

      modelBuilder.Entity<Transaction>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.TransactionId).IsRequired().HasMaxLength(50);
        entity.Property(e => e.CustomerId).IsRequired().HasMaxLength(50);
        entity.Property(e => e.TransactionDate).IsRequired();
        entity.Property(e => e.DueDate).IsRequired();
        entity.Property(e => e.Amount).HasColumnType("decimal(18,2)").IsRequired();
        entity.Property(e => e.Status).IsRequired().HasMaxLength(20);

        // Foreign key relationship
        entity.HasOne(e => e.PaymentMethod)
              .WithMany(p => p.Transactions)
              .HasForeignKey(e => e.PaymentMethodId);

        // Card Payment Details
        entity.Property(e => e.LastFourDigitsOfCard).HasMaxLength(4);
        entity.Property(e => e.CardType).HasMaxLength(20);

        // Mobile Money Payment Details
        entity.Property(e => e.MobileMoneyProvider).HasMaxLength(50);
        entity.Property(e => e.MobileMoneyPhoneNumber).HasMaxLength(15);

        // Bank Transfer Details
        entity.Property(e => e.BankName).HasMaxLength(100);
        entity.Property(e => e.AccountNumber).HasMaxLength(20); // Ensure this is masked
        entity.Property(e => e.TransactionReference).HasMaxLength(100);
      });
      modelBuilder.Entity<Tenant>()
               .HasIndex(t => t.TenantCode)
               .IsUnique();
      modelBuilder.Entity<RentSysUser>()
               .HasIndex(u => u.Email)
               .IsUnique();
      modelBuilder.Entity<RentSysUserRole>()
               .HasOne<RentSysUser>()
               .WithMany() // Define the collection property on RentSysUser if applicable
               .HasForeignKey(ur => ur.UserId);
      modelBuilder.Entity<RentSysUserLogin>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId });
      // Optionally, configure relationships if you have related entities
      modelBuilder.Entity<RentSysUserLogin>()
          .HasOne<RentSysUser>() // Assuming a RentSysUser entity exists
          .WithMany() // Define the collection property on RentSysUser if applicable
          .HasForeignKey(l => l.UserId);
      modelBuilder.Entity<RentSysUserClaim>()
              .HasKey(c => c.Id);

      modelBuilder.Entity<RentSysUserClaim>()
          .HasOne<RentSysUser>() // Assuming RentSysUser entity exists
          .WithMany() // Define the collection property on RentSysUser if applicable
          .HasForeignKey(c => c.UserId)
          .OnDelete(DeleteBehavior.Cascade);

      modelBuilder.Entity<RentSysUserClaim>()
          .HasOne<Tenant>() // Assuming Tenant entity exists
          .WithMany() // Define the collection property on Tenant if applicable
          .HasForeignKey(c => c.TenantId);
      modelBuilder.Entity<RentSysRole>()
                .HasKey(r => r.Id);

      modelBuilder.Entity<RentSysRole>()
          .HasOne<Tenant>() // Assuming Tenant entity exists
          .WithMany() // Define the collection property on Tenant if applicable
          .HasForeignKey(r => r.TenantId)
          .OnDelete(DeleteBehavior.Cascade);
      modelBuilder.Entity<RentSysRoleClaim>()
                .HasKey(rc => rc.Id);

      modelBuilder.Entity<RentSysRoleClaim>()
          .HasOne<RentSysRole>() // Assuming RentSysRole entity exists
          .WithMany() // Define the collection property on RentSysRole if applicable
          .HasForeignKey(rc => rc.RoleId);

      modelBuilder.Entity<RentSysRoleClaim>()
          .HasOne<Tenant>() // Assuming Tenant entity exists
          .WithMany() // Define the collection property on Tenant if applicable
          .HasForeignKey(rc => rc.TenantId);
      modelBuilder.Entity<RentSysUserToken>()
                .HasKey(ut => new { ut.UserId, ut.LoginProvider, ut.Name });

      modelBuilder.Entity<RentSysUserToken>()
          .HasOne<RentSysUser>() // Assuming RentSysUser entity exists
          .WithMany() // Define the collection property on RentSysUser if applicable
          .HasForeignKey(ut => ut.UserId)
          .OnDelete(DeleteBehavior.Cascade);

      modelBuilder.Entity<RentSysUserToken>()
          .HasOne<Tenant>() // Assuming Tenant entity exists
          .WithMany() // Define the collection property on Tenant if applicable
          .HasForeignKey(ut => ut.TenantId);

      modelBuilder.Entity<Room>()
               .HasKey(r => r.RoomID);

      modelBuilder.Entity<Room>()
          .HasOne<Unit>() // Assuming Unit entity exists
          .WithMany() // Define the collection property on Unit if applicable
          .HasForeignKey(r => r.UnitID);
      modelBuilder.Entity<Unit>()
               .HasKey(u => u.UnitID);

      modelBuilder.Entity<Unit>()
          .HasOne<Building>() // Assuming Building entity exists
          .WithMany() // Define the collection property on Building if applicable
          .HasForeignKey(u => u.BuildingID);
      modelBuilder.Entity<Referral>()
               .HasKey(r => r.ReferralID);

      modelBuilder.Entity<Referral>()
          .HasOne<Tenant>() // Assuming Tenant entity exists
          .WithMany() // Define the collection property on Tenant if applicable
          .HasForeignKey(r => r.TenantID);
      modelBuilder.Entity<Property>()
                .HasKey(p => p.PropertyID);
      modelBuilder.Entity<CreditInfo>()
               .HasKey(ci => ci.CreditInfoID);

      modelBuilder.Entity<CreditInfo>()
          .HasOne(ci => ci.Tenant)
          .WithMany() // Define the collection property on Tenant if applicable
          .HasForeignKey(ci => ci.TenantID);
      modelBuilder.Entity<Building>()
               .HasKey(b => b.BuildingID);

      modelBuilder.Entity<Building>()
          .HasOne(b => b.Property)
          .WithMany(p => p.Buildings) // Assuming Property has a collection of Buildings
          .HasForeignKey(b => b.PropertyID);
      modelBuilder.Entity<BackgroundCheck>()
            .HasKey(bc => bc.BackgroundCheckID);

      modelBuilder.Entity<BackgroundCheck>()
          .HasOne(bc => bc.Tenant)
          .WithMany(t => t.BackgroundChecks) // Assuming Tenant has a collection of BackgroundChecks
          .HasForeignKey(bc => bc.TenantID);
    }
  }


}
