using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.About;
using EntityLayer.Concrete.Contact;
using EntityLayer.Concrete.Destination;
using EntityLayer.Concrete.Home;
using EntityLayer.Concrete.Idendity;
using EntityLayer.Concrete.Layout;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMET-PC;Database=TraversalCoreDB;Trusted_Connection=True;TrustServerCertificate =true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<About>().HasKey(a => a.AboutID);
            modelBuilder.Entity<About2>().HasKey(a => a.About2ID);
            modelBuilder.Entity<Contact>().HasKey(h => h.ContactID);
            modelBuilder.Entity<Destination>().HasKey(d => d.DestinationID);
            modelBuilder.Entity<Feature>().HasKey(f => f.FeatureID);
            modelBuilder.Entity<Guide>().HasKey(h => h.GuideID);
            modelBuilder.Entity<Newsletter>().HasKey(h => h.NewsletterID);
            modelBuilder.Entity<SubAbout>().HasKey(h => h.SubAboutID);
            modelBuilder.Entity<Testimonial>().HasKey(h => h.TestimonialID);

            modelBuilder.Entity<Comment>().HasKey(c => c.CommentID);
            modelBuilder.Entity<Comment>()
                .HasOne(i => i.Destination)
                .WithMany(i => i.Comments)
                .HasForeignKey(i => i.DestinationID);
        }
    }
}
