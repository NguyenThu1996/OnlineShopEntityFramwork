namespace ShopOline.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
            : base("name=OnlineShopDbContext")
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentTag> ContentTags { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }
        public virtual DbSet<SystemCongig> SystemCongigs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .Property(e => e.CreareBy)
                .IsFixedLength();

            modelBuilder.Entity<About>()
                .Property(e => e.MetaKeyWords)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.MetaTile)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.CreareBy)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.MetaKeyWords)
                .IsFixedLength();

            modelBuilder.Entity<Content>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.CreareBy)
                .IsFixedLength();

            modelBuilder.Entity<Content>()
                .Property(e => e.MetaKeyWords)
                .IsFixedLength();

            modelBuilder.Entity<ContentTag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.CreareBy)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.MetaKeyWords)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.MetaTile)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.CreareBy)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.MetaKeyWords)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.CreareBy)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.CreareBy)
                .IsFixedLength();
        }
    }
}
