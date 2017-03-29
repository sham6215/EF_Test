namespace Challenger.Domain.DB.british
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BritishPaper : DbContext
    {
        public BritishPaper()
            : base("name=BritishPaper")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<british_chart> british_chart { get; set; }
        public virtual DbSet<british_notice> british_notice { get; set; }
        public virtual DbSet<british_notice_graphic> british_notice_graphic { get; set; }
        public virtual DbSet<british_notice_type> british_notice_type { get; set; }
        public virtual DbSet<british_publication> british_publication { get; set; }
        public virtual DbSet<british_publication_notice> british_publication_notice { get; set; }
        public virtual DbSet<british_publication_type> british_publication_type { get; set; }
        public virtual DbSet<british_week_notice> british_week_notice { get; set; }
        public virtual DbSet<chart_panel> chart_panel { get; set; }
        public virtual DbSet<enp_notice> enp_notice { get; set; }
        public virtual DbSet<enp_week> enp_week { get; set; }
        public virtual DbSet<epublication_notice> epublication_notice { get; set; }
        public virtual DbSet<epublication_week> epublication_week { get; set; }
        public virtual DbSet<geographical_area> geographical_area { get; set; }
        public virtual DbSet<publication_folio> publication_folio { get; set; }
        public virtual DbSet<vessel_british_chart> vessel_british_chart { get; set; }
        public virtual DbSet<vessel_british_notice> vessel_british_notice { get; set; }
        public virtual DbSet<vessel_british_publication> vessel_british_publication { get; set; }
        public virtual DbSet<vessel_enp_notice> vessel_enp_notice { get; set; }
        public virtual DbSet<vessel_epublication> vessel_epublication { get; set; }
        public virtual DbSet<vessel_epublication_notice> vessel_epublication_notice { get; set; }
        public virtual DbSet<vessel_folio> vessel_folio { get; set; }
        public virtual DbSet<vessel_publication_notice> vessel_publication_notice { get; set; }
        public virtual DbSet<week_notice_data> week_notice_data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /// british_chart
            modelBuilder.Entity<british_chart>()
                .Property(e => e.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Properties<string>()
                .Where(p => p.GetType() == british_chart.GetType())
                .Configure(p => p.HasMaxLength(2000000000));
            modelBuilder.Properties<double?>()
                .Where(p => p.GetType() == british_chart.GetType())
                .Configure(p => p.HasColumnType("real"));
            modelBuilder.Entity<british_chart>()
                .Ignore(p => p.coordinates);

            /// british_notice
            modelBuilder.Entity<british_notice>()
                .Property(e => e.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Properties<string>()
                .Where(p => p.GetType() == british_notice.GetType())
                .Configure(p => p.HasMaxLength(2000000000));
            modelBuilder.Entity<british_notice>()
                .Ignore(p => p.data);


            modelBuilder.Entity<british_chart>()
                .HasMany(e => e.british_notice)
                .WithRequired(e => e.british_chart)
                .HasForeignKey(e => e.chart_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<british_chart>()
                .HasMany(e => e.chart_panel)
                .WithRequired(e => e.british_chart)
                .HasForeignKey(e => e.chart_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<british_chart>()
                .HasMany(e => e.vessel_british_chart)
                .WithRequired(e => e.british_chart)
                .HasForeignKey(e => e.chart_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<british_notice>()
                .HasMany(e => e.british_notice_graphic)
                .WithRequired(e => e.british_notice)
                .HasForeignKey(e => e.notice_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<british_notice>()
                .HasMany(e => e.vessel_british_notice)
                .WithRequired(e => e.british_notice)
                .HasForeignKey(e => e.notice_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<british_notice_type>()
                .HasMany(e => e.british_notice)
                .WithRequired(e => e.british_notice_type)
                .HasForeignKey(e => e.type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<british_publication>()
                .HasMany(e => e.british_publication_notice)
                .WithOptional(e => e.british_publication)
                .HasForeignKey(e => e.publication_id);

            modelBuilder.Entity<british_publication>()
                .HasMany(e => e.enp_notice)
                .WithOptional(e => e.british_publication)
                .HasForeignKey(e => e.publication_id);

            modelBuilder.Entity<british_publication>()
                .HasMany(e => e.epublication_notice)
                .WithOptional(e => e.british_publication)
                .HasForeignKey(e => e.publication_id);

            modelBuilder.Entity<british_publication>()
                .HasOptional(e => e.vessel_british_publication)
                .WithRequired(e => e.british_publication);

            modelBuilder.Entity<british_publication>()
                .HasOptional(e => e.vessel_epublication)
                .WithRequired(e => e.british_publication);

            modelBuilder.Entity<british_publication_notice>()
                .HasOptional(e => e.vessel_publication_notice)
                .WithRequired(e => e.british_publication_notice);

            modelBuilder.Entity<british_publication_type>()
                .HasMany(e => e.british_publication)
                .WithOptional(e => e.british_publication_type)
                .HasForeignKey(e => e.type);

            modelBuilder.Entity<british_week_notice>()
                .HasMany(e => e.british_notice)
                .WithRequired(e => e.british_week_notice)
                .HasForeignKey(e => e.week_notice_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<british_week_notice>()
                .HasMany(e => e.british_publication_notice)
                .WithRequired(e => e.british_week_notice)
                .HasForeignKey(e => e.weekly_notice_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<british_week_notice>()
                .HasOptional(e => e.week_notice_data)
                .WithRequired(e => e.british_week_notice);

            modelBuilder.Entity<enp_notice>()
                .HasOptional(e => e.vessel_enp_notice)
                .WithRequired(e => e.enp_notice);

            modelBuilder.Entity<enp_week>()
                .HasMany(e => e.enp_notice)
                .WithRequired(e => e.enp_week)
                .HasForeignKey(e => e.week_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<epublication_notice>()
                .HasOptional(e => e.vessel_epublication_notice)
                .WithRequired(e => e.epublication_notice);

            modelBuilder.Entity<epublication_week>()
                .HasMany(e => e.epublication_notice)
                .WithOptional(e => e.epublication_week)
                .HasForeignKey(e => e.week_id);

            modelBuilder.Entity<geographical_area>()
                .HasMany(e => e.british_notice)
                .WithOptional(e => e.geographical_area)
                .HasForeignKey(e => e.area_id);

            modelBuilder.Entity<publication_folio>()
                .HasMany(e => e.vessel_british_publication)
                .WithOptional(e => e.publication_folio)
                .HasForeignKey(e => e.folio_id);

            modelBuilder.Entity<vessel_british_chart>()
                .HasMany(e => e.vessel_british_notice)
                .WithRequired(e => e.vessel_british_chart)
                .HasForeignKey(e => e.vessel_chart_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vessel_folio>()
                .HasMany(e => e.vessel_british_chart)
                .WithOptional(e => e.vessel_folio)
                .HasForeignKey(e => e.vessel_folio_id);
        }
    }
}
