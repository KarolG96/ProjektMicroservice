using Microsoft.EntityFrameworkCore;
using Projekt.Services.CouponAPI.Models;

namespace Projekt.Services.CouponAPI.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
                {
                    CouponId = 1,
                    CouponCode = "10xddd",
                    DiscountAmount = 10,
                    MinAmount = 20
                });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "20xddd",
                DiscountAmount = 20,
                MinAmount = 40
            });
        }
    }
}
