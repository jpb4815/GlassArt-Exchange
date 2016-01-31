namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GlassPipesModel : DbContext
    {
        public GlassPipesModel()
            : base("name=GlassPipesExchangeModel")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Blog_Comment> Blog_Comment { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.Address_Line_1)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Address_Line_2)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Zip_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Telephone_2)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.Style)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.Bio)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.Stores)
                .WithRequired(e => e.Artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .HasMany(e => e.Blog_Comment)
                .WithRequired(e => e.Blog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blog_Comment>()
                .Property(e => e.Comment_Body)
                .IsUnicode(false);

            modelBuilder.Entity<Blog_Comment>()
                .Property(e => e.Comment_Author)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Tracking_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.PayPay_Info)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.ShoppingCarts)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ShoppingCarts)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session>()
                .Property(e => e.Cookie)
                .IsUnicode(false);

            modelBuilder.Entity<ShoppingCart>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Products)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Artists)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Sessions)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Stores)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.Comment_Body)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.Comment_Date)
                .IsUnicode(false);
        }
    }
}
