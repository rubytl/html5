using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MSMClientAPIService.Data.Models
{
    public partial class MultisiteDBEntitiesContext : DbContext
    {
        public MultisiteDBEntitiesContext(DbContextOptions<MultisiteDBEntitiesContext> options)
            : base(options)
        { }

        public virtual DbSet<AlarmHistory> AlarmHistory { get; set; }
        public virtual DbSet<AlarmStatistics> AlarmStatistics { get; set; }
        public virtual DbSet<BatteryMaintenance> BatteryMaintenance { get; set; }
        public virtual DbSet<BatteryPerformance> BatteryPerformance { get; set; }
        public virtual DbSet<ControllerType> ControllerType { get; set; }
        public virtual DbSet<CoolingSystemPerformance> CoolingSystemPerformance { get; set; }
        public virtual DbSet<EmailAddressBook> EmailAddressBook { get; set; }
        public virtual DbSet<EnergyCostPerformance> EnergyCostPerformance { get; set; }
        public virtual DbSet<EnergyPerformance> EnergyPerformance { get; set; }
        public virtual DbSet<ENexusConfigPoints> ENexusConfigPoints { get; set; }
        public virtual DbSet<ENexusConfiguration> ENexusConfiguration { get; set; }
        public virtual DbSet<ENexusDataLog> ENexusDataLog { get; set; }
        public virtual DbSet<EventLog> EventLog { get; set; }
        public virtual DbSet<FileFolderConfiguration> FileFolderConfiguration { get; set; }
        public virtual DbSet<FileStreamProperty> FileStreamProperty { get; set; }
        public virtual DbSet<GeneratorPerformance> GeneratorPerformance { get; set; }
        public virtual DbSet<GlobalKpi> GlobalKpi { get; set; }
        public virtual DbSet<LogInt> LogInt { get; set; }
        public virtual DbSet<LogString> LogString { get; set; }
        public virtual DbSet<LogVarChar> LogVarChar { get; set; }
        public virtual DbSet<MibUploadPackageProperty> MibUploadPackageProperty { get; set; }
        public virtual DbSet<MsmalarmsLog> MsmalarmsLog { get; set; }
        public virtual DbSet<Msmdictionary> Msmdictionary { get; set; }
        public virtual DbSet<Msmsettings> Msmsettings { get; set; }
        public virtual DbSet<Msmuser> Msmuser { get; set; }
        public virtual DbSet<NetworkDevice> NetworkDevice { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<NotifyHistory> NotifyHistory { get; set; }
        public virtual DbSet<OccasionalNotification> OccasionalNotification { get; set; }
        public virtual DbSet<ProtocolDefinition> ProtocolDefinition { get; set; }
        public virtual DbSet<ReportServer> ReportServer { get; set; }
        public virtual DbSet<RestrictedGroup> RestrictedGroup { get; set; }
        public virtual DbSet<RestrictedGroupConfig> RestrictedGroupConfig { get; set; }
        public virtual DbSet<RptEnergyReport> RptEnergyReport { get; set; }
        public virtual DbSet<RptNotifyNow> RptNotifyNow { get; set; }
        public virtual DbSet<RptRunHourReport> RptRunHourReport { get; set; }
        public virtual DbSet<RptSiteSummary> RptSiteSummary { get; set; }
        public virtual DbSet<RptUnderPerforming> RptUnderPerforming { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<SiteConnectivityQuality> SiteConnectivityQuality { get; set; }
        public virtual DbSet<SiteEventLog> SiteEventLog { get; set; }
        public virtual DbSet<SiteEventQueue> SiteEventQueue { get; set; }
        public virtual DbSet<SiteExtention> SiteExtention { get; set; }
        public virtual DbSet<SiteInventory> SiteInventory { get; set; }
        public virtual DbSet<SiteNotification> SiteNotification { get; set; }
        public virtual DbSet<SiteTemplate> SiteTemplate { get; set; }
        public virtual DbSet<SiteWebCamera> SiteWebCamera { get; set; }
        public virtual DbSet<SnmpconfigTemplate> SnmpconfigTemplate { get; set; }
        public virtual DbSet<SnmpDataTemplate> SnmpDataTemplate { get; set; }
        public virtual DbSet<SnmpDataTemplateConfig> SnmpDataTemplateConfig { get; set; }
        public virtual DbSet<SnmpgeneralReceiver> SnmpgeneralReceiver { get; set; }
        public virtual DbSet<Snmpreceiver> Snmpreceiver { get; set; }
        public virtual DbSet<SnmpreceiverHistory> SnmpreceiverHistory { get; set; }
        public virtual DbSet<UserLoginConfiguration> UserLoginConfiguration { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlarmHistory>(entity =>
            {
                entity.HasKey(e => e.AlarmId);

                entity.HasIndex(e => e.AlarmOnTime)
                    .HasName("NonClusteredIndex-alarmOnTime");

                entity.HasIndex(e => e.SiteId)
                    .HasName("NonClusteredIndex-SiteID");

                entity.Property(e => e.AlarmId).HasColumnName("AlarmID");

                entity.Property(e => e.AlarmDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AlarmOffTime).HasColumnType("datetime");

                entity.Property(e => e.AlarmOnTime).HasColumnType("datetime");

                entity.Property(e => e.LastNotifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastNotifiedTo).HasMaxLength(50);

                entity.Property(e => e.SiteDescription).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TrapOid)
                    .IsRequired()
                    .HasColumnName("TrapOID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AlarmStatistics>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MonitoredSince).HasColumnType("datetime");

                entity.Property(e => e.PresentAlarmDate).HasColumnType("datetime");

                entity.Property(e => e.PresentOfflineDate).HasColumnType("datetime");

                entity.Property(e => e.PresentWarningDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAlarmHours).HasMaxLength(50);

                entity.Property(e => e.TotalOffLineHours).HasMaxLength(50);

                entity.Property(e => e.TotalWarningHours).HasMaxLength(50);
            });

            modelBuilder.Entity<BatteryMaintenance>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InstalledBatteryBackupStatusTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.LoadCurrentAvg).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.LoadCurrentPeak).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Upflag).HasColumnName("UPFlag");

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.BatteryMaintenance)
                    .HasForeignKey<BatteryMaintenance>(d => d.SiteId)
                    .HasConstraintName("FK_BatteryMaintenance_BatteryMaintenance");
            });

            modelBuilder.Entity<BatteryPerformance>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.StatusTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Upflag).HasColumnName("UPFlag");

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.BatteryPerformance)
                    .HasForeignKey<BatteryPerformance>(d => d.SiteId)
                    .HasConstraintName("FK_BatteryPerformance_Site");
            });

            modelBuilder.Entity<ControllerType>(entity =>
            {
                entity.Property(e => e.ControllerTypeId).HasColumnName("ControllerTypeID");

                entity.Property(e => e.ControllerTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MibFilesPackageId)
                    .HasColumnName("MibFilesPackageID")
                    .HasMaxLength(50);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.MibFilesPackage)
                    .WithMany(p => p.ControllerType)
                    .HasForeignKey(d => d.MibFilesPackageId)
                    .HasConstraintName("FK_ControllerType_MibUploadPackageProperty");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ControllerType)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ControllerType_Vendor");
            });

            modelBuilder.Entity<CoolingSystemPerformance>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EcbrunTime).HasColumnName("ECBRunTime");

                entity.Property(e => e.EcbrunTimeStatus).HasColumnName("ECBRunTimeStatus");

                entity.Property(e => e.EcbrunTimeTarget).HasColumnName("ECBRunTimeTarget");

                entity.Property(e => e.StatusTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Upflag).HasColumnName("UPFlag");

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.CoolingSystemPerformance)
                    .HasForeignKey<CoolingSystemPerformance>(d => d.SiteId)
                    .HasConstraintName("FK_CoolingSystemPerformance_Site");
            });

            modelBuilder.Entity<EmailAddressBook>(entity =>
            {
                entity.HasKey(e => e.DuserId);

                entity.Property(e => e.DuserId).HasColumnName("DUserID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EnergyCostPerformance>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DieselPrice).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.GridPrice).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.SolarPrice).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.StatusTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Upflag).HasColumnName("UPFlag");

                entity.Property(e => e.WindPrice).HasColumnType("decimal(10, 4)");

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.EnergyCostPerformance)
                    .HasForeignKey<EnergyCostPerformance>(d => d.SiteId)
                    .HasConstraintName("FK_EnergyCostPerformance_Site");
            });

            modelBuilder.Entity<EnergyPerformance>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcenergyTotal).HasColumnName("ACEnergyTotal");

                entity.Property(e => e.AcmonitorEnergyTotal).HasColumnName("ACMonitorEnergyTotal");

                entity.Property(e => e.DailyTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Upflag).HasColumnName("UPFlag");

                entity.Property(e => e.WeeklyTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.EnergyPerformance)
                    .HasForeignKey<EnergyPerformance>(d => d.SiteId)
                    .HasConstraintName("FK_EnergyPerformance_Site");
            });

            modelBuilder.Entity<ENexusConfigPoints>(entity =>
            {
                entity.ToTable("eNexusConfigPoints");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data).HasMaxLength(100);

                entity.Property(e => e.Descrition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ENexusConfigId).HasColumnName("eNexusConfigID");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.HasOne(d => d.ENexusConfig)
                    .WithMany(p => p.ENexusConfigPoints)
                    .HasForeignKey(d => d.ENexusConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eNexusConfigPoints_eNexusConfiguration");
            });

            modelBuilder.Entity<ENexusConfiguration>(entity =>
            {
                entity.HasKey(e => e.ENexusConfigId);

                entity.ToTable("eNexusConfiguration");

                entity.Property(e => e.ENexusConfigId)
                    .HasColumnName("eNexusConfigID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ENexusDataLog>(entity =>
            {
                entity.ToTable("eNexusDataLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.InitialValue).HasMaxLength(100);

                entity.Property(e => e.Response).HasMaxLength(100);

                entity.Property(e => e.ResultValue).HasMaxLength(100);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.WriteValue).HasMaxLength(100);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ENexusDataLog)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_eNexusDataLog_Site");
            });

            modelBuilder.Entity<EventLog>(entity =>
            {
                entity.HasIndex(e => new { e.EventType, e.SiteId })
                    .HasName("NonClusteredIndex-SiteID-EventType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2).HasMaxLength(50);

                entity.Property(e => e.Description3).HasMaxLength(50);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventSourceId).HasColumnName("EventSourceID");

                entity.Property(e => e.Sender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileFolderConfiguration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<FileStreamProperty>(entity =>
            {
                entity.HasKey(e => e.RefId);

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(260);

                entity.Property(e => e.LastWriteBy).HasMaxLength(50);

                entity.Property(e => e.LastWriteDate).HasColumnType("datetime");

                entity.Property(e => e.Property2).HasMaxLength(50);

                entity.Property(e => e.Property3).HasMaxLength(50);
            });

            modelBuilder.Entity<GeneratorPerformance>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.StatusTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Upflag).HasColumnName("UPFlag");

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.GeneratorPerformance)
                    .HasForeignKey<GeneratorPerformance>(d => d.SiteId)
                    .HasConstraintName("FK_GeneratorPerformance_Site");
            });

            modelBuilder.Entity<GlobalKpi>(entity =>
            {
                entity.ToTable("GlobalKPI");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Catalog)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KpivalStatus).HasColumnName("KPIValStatus");

                entity.Property(e => e.Kpivalue).HasColumnName("KPIvalue");

                entity.Property(e => e.NumUpsite).HasColumnName("NumUPSite");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogInt>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.ProtocolId, e.TimeStamp });

                entity.HasIndex(e => new { e.SiteId, e.ProtocolId })
                    .HasName("LogIntUniqlog")
                    .IsUnique()
                    .HasFilter("([protocolid]<>(1))");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.ProtocolId).HasColumnName("ProtocolID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.LogInt)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_LogInt_Site");
            });

            modelBuilder.Entity<LogString>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.ProtocolId, e.TimeStamp });

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.ProtocolId).HasColumnName("ProtocolID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(1000);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.LogString)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_LogString_Site");
            });

            modelBuilder.Entity<LogVarChar>(entity =>
            {
                entity.HasIndex(e => new { e.ProtocolId, e.SiteId })
                    .HasName("NonClusteredIndex-SiteID-ProtocolID");

                entity.HasIndex(e => new { e.SiteId, e.ProtocolId })
                    .HasName("LogVarCharUniqlog")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProtocolId).HasColumnName("ProtocolID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SptimeStamp)
                    .HasColumnName("SPTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.LogVarChar)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_LogVarChar_Site");
            });

            modelBuilder.Entity<MibUploadPackageProperty>(entity =>
            {
                entity.HasKey(e => e.MibFilesPackageId);

                entity.Property(e => e.MibFilesPackageId)
                    .HasColumnName("MibFilesPackageID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(260);
            });

            modelBuilder.Entity<MsmalarmsLog>(entity =>
            {
                entity.HasKey(e => e.AlarmIdentifier);

                entity.ToTable("MSMAlarmsLog");

                entity.HasIndex(e => new { e.AlarmCatalogId, e.AlarmStatusId, e.AlarmOffTime })
                    .HasName("NonClusteredIndex-AlarmCatalog-Status-Offtime");

                entity.Property(e => e.AlarmIdentifier).ValueGeneratedNever();

                entity.Property(e => e.AlarmCatalogId).HasColumnName("AlarmCatalogID");

                entity.Property(e => e.AlarmDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AlarmOffTime).HasColumnType("datetime");

                entity.Property(e => e.AlarmOnTime).HasColumnType("datetime");

                entity.Property(e => e.AlarmStatusId).HasColumnName("AlarmStatusID");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.MajorAlarmLevel).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinorAlarmLevel).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OriginalOid)
                    .HasColumnName("OriginalOID")
                    .HasMaxLength(50);

                entity.Property(e => e.SenderIdentifier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SiteDescription).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Msmdictionary>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("MSMDictionary");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasColumnType("char(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithOne(p => p.InverseItem)
                    .HasForeignKey<Msmdictionary>(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MSMDictionary_MSMDictionary");
            });

            modelBuilder.Entity<Msmsettings>(entity =>
            {
                entity.HasKey(e => e.Property);

                entity.ToTable("MSMSettings");

                entity.Property(e => e.Property)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Msmuser>(entity =>
            {
                entity.ToTable("MSMUser");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Username).IsRequired();
            });

            modelBuilder.Entity<NetworkDevice>(entity =>
            {
                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeviceType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Macaddress)
                    .IsRequired()
                    .HasColumnName("MACAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Swdate)
                    .HasColumnName("SWDate")
                    .HasColumnType("date");

                entity.Property(e => e.Swversion)
                    .IsRequired()
                    .HasColumnName("SWVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseTls12).HasColumnName("UseTLS12");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.Property(e => e.NotificationId)
                    .HasColumnName("NotificationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExpectedNextNotifyTime).HasColumnType("datetime");

                entity.Property(e => e.Receiver).HasMaxLength(50);

                entity.Property(e => e.ReportFormat).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<NotifyHistory>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.NotificationId, e.AlarmId });

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.AlarmId).HasColumnName("AlarmID");

                entity.Property(e => e.AlarmDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AlarmOffTime).HasColumnType("datetime");

                entity.Property(e => e.AlarmOnTime).HasColumnType("datetime");

                entity.Property(e => e.AlarmSiteId).HasColumnName("AlarmSiteID");

                entity.Property(e => e.AllReceiver).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EmailList).HasMaxLength(500);

                entity.Property(e => e.ExpectedNextNotifyTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.MonitoredSince).HasColumnType("datetime");

                entity.Property(e => e.SiteDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<OccasionalNotification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportFormat).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sender)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.OccasionalNotification)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_OccasionalNotification_Site");
            });

            modelBuilder.Entity<ProtocolDefinition>(entity =>
            {
                entity.HasKey(e => e.ProtocolId);

                entity.Property(e => e.ProtocolId)
                    .HasColumnName("ProtocolID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportServer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmailServiceAccount).HasMaxLength(50);

                entity.Property(e => e.Psw)
                    .HasColumnName("PSW")
                    .HasMaxLength(50);

                entity.Property(e => e.Smtpport).HasColumnName("SMTPport");

                entity.Property(e => e.SmtpserverIp)
                    .HasColumnName("SMTPServerIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<RestrictedGroup>(entity =>
            {
                entity.Property(e => e.RestrictedGroupId)
                    .HasColumnName("RestrictedGroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RestrictedGroupName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<RestrictedGroupConfig>(entity =>
            {
                entity.HasKey(e => new { e.RestrictedGroupId, e.SiteId });

                entity.Property(e => e.RestrictedGroupId).HasColumnName("RestrictedGroupID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.RestrictedGroup)
                    .WithMany(p => p.RestrictedGroupConfig)
                    .HasForeignKey(d => d.RestrictedGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RestrictedGroupConfig_RestrictedGroup");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.RestrictedGroupConfig)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_RestrictedRoleSite_Site");
            });

            modelBuilder.Entity<RptEnergyReport>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.Id });

                entity.ToTable("rptEnergyReport");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acinput).HasColumnName("ACinput");

                entity.Property(e => e.Generator).HasColumnName("generator");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(500);

                entity.Property(e => e.Solar).HasColumnName("solar");

                entity.Property(e => e.TimeFrame)
                    .HasColumnName("timeFrame")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wind).HasColumnName("wind");
            });

            modelBuilder.Entity<RptNotifyNow>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("rptNotifyNow");

                entity.Property(e => e.AllReceiver).HasMaxLength(100);

                entity.Property(e => e.DataLogType).HasColumnType("char(1)");

                entity.Property(e => e.EmailList).HasMaxLength(500);

                entity.Property(e => e.ExpectedNextNotifyTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.NotificationDescription).HasMaxLength(50);

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Sender).HasMaxLength(50);

                entity.Property(e => e.SiteDescription).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");
            });

            modelBuilder.Entity<RptRunHourReport>(entity =>
            {
                entity.HasKey(e => new { e.DataSiteId, e.Idx });

                entity.ToTable("rptRunHourReport");

                entity.Property(e => e.DataSiteId).HasColumnName("DataSiteID");

                entity.Property(e => e.DataSiteDescription).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.TimeFrame).HasColumnType("datetime");
            });

            modelBuilder.Entity<RptSiteSummary>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("rptSiteSummary");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveAlarm).HasColumnType("datetime");

                entity.Property(e => e.HistoricalAlarm).HasColumnType("datetime");

                entity.Property(e => e.LossNumUpstatus).HasColumnName("LossNumUPStatus");

                entity.Property(e => e.ParentDescription).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SiteDescription).HasMaxLength(50);

                entity.Property(e => e.UpTimeUpstatus).HasColumnName("UpTimeUPStatus");
            });

            modelBuilder.Entity<RptUnderPerforming>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("rptUnderPerforming");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcinputRate).HasColumnName("ACInputRate");

                entity.Property(e => e.Eofrate).HasColumnName("EOFrate");

                entity.Property(e => e.LossNumUpstatus).HasColumnName("LossNumUPStatus");

                entity.Property(e => e.MainsMonitorDcrate).HasColumnName("MainsMonitorDCRate");

                entity.Property(e => e.SiteDescription).HasMaxLength(50);

                entity.Property(e => e.UpTimeUpstatus).HasColumnName("UpTimeUPStatus");
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasIndex(e => e.ParentId)
                    .HasName("NonClusteredIndex-ParentID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.JsonPassword)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.JsonUserName)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.NotificationName).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SnmpDataTemplateId)
                    .HasColumnName("SnmpDataTemplateID")
                    .HasMaxLength(50);

                entity.Property(e => e.SnmpTemplateId).HasColumnName("SnmpTemplateID");

                entity.Property(e => e.Ssl).HasColumnName("SSL");

                entity.Property(e => e.TemplateId)
                    .IsRequired()
                    .HasColumnName("TemplateID")
                    .HasColumnType("char(4)");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_SiteCollection_SiteCollection");

                entity.HasOne(d => d.SnmpTemplate)
                    .WithMany(p => p.Site)
                    .HasForeignKey(d => d.SnmpTemplateId)
                    .HasConstraintName("FK_Site_SNMPConfigTemplate");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.Site)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Site_SiteTemplate");
            });

            modelBuilder.Entity<SiteConnectivityQuality>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LogTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.LossNumDailyLog).HasMaxLength(500);

                entity.Property(e => e.LossNumUpstatus).HasColumnName("LossNumUPStatus");

                entity.Property(e => e.LossTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpTimeDailyLog).HasMaxLength(500);

                entity.Property(e => e.UpTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpTimeUpstatus).HasColumnName("UpTimeUPStatus");

                entity.Property(e => e.Upflag).HasColumnName("UPFlag");

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.SiteConnectivityQuality)
                    .HasForeignKey<SiteConnectivityQuality>(d => d.SiteId)
                    .HasConstraintName("FK_SiteConnectivityQuality_Site");
            });

            modelBuilder.Entity<SiteEventLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ENexusConfigId).HasColumnName("eNexusConfigID");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.QueueTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceDocId).HasColumnName("ReferenceDocID");

                entity.Property(e => e.ReportDocId).HasColumnName("ReportDocID");

                entity.Property(e => e.ReportTime).HasColumnType("datetime");

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ENexusConfig)
                    .WithMany(p => p.SiteEventLog)
                    .HasForeignKey(d => d.ENexusConfigId)
                    .HasConstraintName("FK_eNexusConfiguration_SiteEventLog");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteEventLog)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SiteEventLog_Site");
            });

            modelBuilder.Entity<SiteEventQueue>(entity =>
            {
                entity.HasKey(e => e.QueueId);

                entity.Property(e => e.QueueId).HasColumnName("QueueID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ENexusConfigId).HasColumnName("eNexusConfigID");

                entity.Property(e => e.QueueTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceDocId).HasColumnName("ReferenceDocID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.StatusTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ENexusConfig)
                    .WithMany(p => p.SiteEventQueue)
                    .HasForeignKey(d => d.ENexusConfigId)
                    .HasConstraintName("FK_eNexusConfiguration_SiteEventQueue");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteEventQueue)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SiteEventQueue_Site");
            });

            modelBuilder.Entity<SiteExtention>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InventoryDate).HasColumnType("datetime");

                entity.Property(e => e.LoadCurrentAvePeakReset)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Site)
                    .WithOne(p => p.SiteExtention)
                    .HasForeignKey<SiteExtention>(d => d.SiteId)
                    .HasConstraintName("FK_SiteExtention_Site");
            });

            modelBuilder.Entity<SiteInventory>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.ModuleId });

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.DeliveredDate).HasColumnType("datetime");

                entity.Property(e => e.Manufactor).HasMaxLength(100);

                entity.Property(e => e.ModuleType).HasMaxLength(50);

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PartVersion)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.SwpartNumber)
                    .IsRequired()
                    .HasColumnName("SWPartNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.Swversion)
                    .IsRequired()
                    .HasColumnName("SWVersion")
                    .HasMaxLength(10);

                entity.Property(e => e.Warranty).HasDefaultValueSql("((12))");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteInventory)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SiteInventory_Site");
            });

            modelBuilder.Entity<SiteNotification>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.NotificationId });

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.DefaultReceiver).HasMaxLength(50);

                entity.Property(e => e.ExpectedNextNotifyTime).HasColumnType("datetime");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.SiteNotification)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SiteNotification_Notifications");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteNotification)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SiteNotification_Site");
            });

            modelBuilder.Entity<SiteTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TemplateID")
                    .HasColumnType("char(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AveLoadResetInterval).HasDefaultValueSql("((1))");

                entity.Property(e => e.AverageLoadRange).HasColumnType("char(4)");

                entity.Property(e => e.BatteryConfig).HasColumnType("char(4)");

                entity.Property(e => e.BatteryTechnology).HasColumnType("char(4)");

                entity.Property(e => e.ControllerType).HasColumnType("char(4)");

                entity.Property(e => e.Cooling).HasColumnType("char(4)");

                entity.Property(e => e.EcbrunTimeTarget).HasColumnName("ECBRunTimeTarget");

                entity.Property(e => e.GenCostTarget).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.GeneratorBrand).HasMaxLength(20);

                entity.Property(e => e.GeneratorConfig).HasColumnType("char(4)");

                entity.Property(e => e.GridCostTarget).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InstalledBatteryBackupTarget).HasDefaultValueSql("((120))");

                entity.Property(e => e.IoUnitWithEcbonSystem).HasColumnName("ioUnitWithECBOnSystem");

                entity.Property(e => e.LoadType).HasColumnType("char(4)");

                entity.Property(e => e.Monitor1).HasColumnType("char(4)");

                entity.Property(e => e.Monitor2).HasColumnType("char(4)");

                entity.Property(e => e.Monitor3).HasColumnType("char(4)");

                entity.Property(e => e.Monitor4).HasColumnType("char(4)");

                entity.Property(e => e.Monitor5).HasColumnType("char(4)");

                entity.Property(e => e.Monitor6).HasColumnType("char(4)");

                entity.Property(e => e.PeakLoadRange).HasColumnType("char(4)");

                entity.Property(e => e.SolarCostTarget).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SolarInstallCost).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SolarInstallDate).HasColumnType("datetime");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.WindCostTarget).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.WindInstallCost).HasColumnType("datetime");

                entity.Property(e => e.WindInstallDate).HasColumnType("datetime");

                entity.HasOne(d => d.AverageLoadRangeNavigation)
                    .WithMany(p => p.SiteTemplateAverageLoadRangeNavigation)
                    .HasForeignKey(d => d.AverageLoadRange)
                    .HasConstraintName("FK_AverageLoadRange");

                entity.HasOne(d => d.BatteryConfigNavigation)
                    .WithMany(p => p.SiteTemplateBatteryConfigNavigation)
                    .HasForeignKey(d => d.BatteryConfig)
                    .HasConstraintName("FK_BatteryConfig");

                entity.HasOne(d => d.BatteryTechnologyNavigation)
                    .WithMany(p => p.SiteTemplateBatteryTechnologyNavigation)
                    .HasForeignKey(d => d.BatteryTechnology)
                    .HasConstraintName("FK_BatteryTechnology");

                entity.HasOne(d => d.ControllerTypeNavigation)
                    .WithMany(p => p.SiteTemplateControllerTypeNavigation)
                    .HasForeignKey(d => d.ControllerType)
                    .HasConstraintName("FK_ControllerType");

                entity.HasOne(d => d.CoolingNavigation)
                    .WithMany(p => p.SiteTemplateCoolingNavigation)
                    .HasForeignKey(d => d.Cooling)
                    .HasConstraintName("FK_Cooling");

                entity.HasOne(d => d.GeneratorConfigNavigation)
                    .WithMany(p => p.SiteTemplateGeneratorConfigNavigation)
                    .HasForeignKey(d => d.GeneratorConfig)
                    .HasConstraintName("FK_GeneratorConfig");

                entity.HasOne(d => d.LoadTypeNavigation)
                    .WithMany(p => p.SiteTemplateLoadTypeNavigation)
                    .HasForeignKey(d => d.LoadType)
                    .HasConstraintName("FK_LoadType");

                entity.HasOne(d => d.Monitor1Navigation)
                    .WithMany(p => p.SiteTemplateMonitor1Navigation)
                    .HasForeignKey(d => d.Monitor1)
                    .HasConstraintName("FK_Monitor1");

                entity.HasOne(d => d.Monitor2Navigation)
                    .WithMany(p => p.SiteTemplateMonitor2Navigation)
                    .HasForeignKey(d => d.Monitor2)
                    .HasConstraintName("FK_Monitor2");

                entity.HasOne(d => d.Monitor3Navigation)
                    .WithMany(p => p.SiteTemplateMonitor3Navigation)
                    .HasForeignKey(d => d.Monitor3)
                    .HasConstraintName("FK_Monitor3");

                entity.HasOne(d => d.Monitor4Navigation)
                    .WithMany(p => p.SiteTemplateMonitor4Navigation)
                    .HasForeignKey(d => d.Monitor4)
                    .HasConstraintName("FK_Monitor4");

                entity.HasOne(d => d.Monitor5Navigation)
                    .WithMany(p => p.SiteTemplateMonitor5Navigation)
                    .HasForeignKey(d => d.Monitor5)
                    .HasConstraintName("FK_Monitor5");

                entity.HasOne(d => d.Monitor6Navigation)
                    .WithMany(p => p.SiteTemplateMonitor6Navigation)
                    .HasForeignKey(d => d.Monitor6)
                    .HasConstraintName("FK_Monitor6");

                entity.HasOne(d => d.PeakLoadRangeNavigation)
                    .WithMany(p => p.SiteTemplatePeakLoadRangeNavigation)
                    .HasForeignKey(d => d.PeakLoadRange)
                    .HasConstraintName("FK_PeakLoadRange");
            });

            modelBuilder.Entity<SiteWebCamera>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CameraDescription).HasMaxLength(50);

                entity.Property(e => e.CameraType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Axis')");

                entity.Property(e => e.Protocol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('rtsp')");

                entity.Property(e => e.QueryString)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.WebCameraIp)
                    .IsRequired()
                    .HasColumnName("WebCameraIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebCameraPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebCameraUid)
                    .IsRequired()
                    .HasColumnName("WebCameraUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.SiteWebCamera)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_SiteWebCamera_Site");
            });

            modelBuilder.Entity<SnmpconfigTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("SNMPConfigTemplate");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.AuthKey).HasMaxLength(50);

                entity.Property(e => e.PrivKey).HasMaxLength(50);

                entity.Property(e => e.ReadCommunityString).HasMaxLength(20);

                entity.Property(e => e.SecurityName).HasMaxLength(50);

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SnmpDataTemplate>(entity =>
            {
                entity.Property(e => e.SnmpDataTemplateId)
                    .HasColumnName("SnmpDataTemplateID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.MibFilesPackageId)
                    .HasColumnName("MibFilesPackageID")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SnmpDataTemplateConfig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ProtocolId).HasColumnName("ProtocolID");

                entity.Property(e => e.SchdulerId)
                    .IsRequired()
                    .HasColumnName("SchdulerID")
                    .HasMaxLength(50);

                entity.Property(e => e.SnmpDataTemplateId)
                    .IsRequired()
                    .HasColumnName("SnmpDataTemplateID")
                    .HasMaxLength(50);

                entity.Property(e => e.SnmpOid)
                    .IsRequired()
                    .HasColumnName("SnmpOID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SnmpgeneralReceiver>(entity =>
            {
                entity.HasKey(e => e.SnmptrapId);

                entity.ToTable("SNMPGeneralReceiver");

                entity.Property(e => e.SnmptrapId).HasColumnName("SNMPTrapID");

                entity.Property(e => e.FullMessageText)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.Snmpversion).HasColumnName("SNMPVersion");

                entity.Property(e => e.TrapCommunity)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.TrapOid)
                    .IsRequired()
                    .HasColumnName("TrapOID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Snmpreceiver>(entity =>
            {
                entity.HasKey(e => e.SnmptrapId);

                entity.ToTable("SNMPReceiver");

                entity.Property(e => e.SnmptrapId).HasColumnName("SNMPTrapID");

                entity.Property(e => e.AlarmDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.MibreferenceStatus)
                    .IsRequired()
                    .HasColumnName("MIBReferenceStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.MibreferenceValue)
                    .IsRequired()
                    .HasColumnName("MIBReferenceValue")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.Snmpversion).HasColumnName("SNMPVersion");

                entity.Property(e => e.TrapOid)
                    .IsRequired()
                    .HasColumnName("TrapOID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SnmpreceiverHistory>(entity =>
            {
                entity.HasKey(e => e.SnmptrapId);

                entity.ToTable("SNMPReceiverHistory");

                entity.HasIndex(e => new { e.Ipaddress, e.EventType, e.ReceiveTime })
                    .HasName("NonClusteredIndex-RollingAlarm");

                entity.Property(e => e.SnmptrapId)
                    .HasColumnName("SNMPTrapID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlarmDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.MibreferenceStatus)
                    .IsRequired()
                    .HasColumnName("MIBReferenceStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.MibreferenceValue)
                    .IsRequired()
                    .HasColumnName("MIBReferenceValue")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.Snmpversion).HasColumnName("SNMPVersion");

                entity.Property(e => e.TrapOid)
                    .IsRequired()
                    .HasColumnName("TrapOID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserLoginConfiguration>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("IX_UserLoginConfiguration_UserName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RestrictedGroupId).HasColumnName("RestrictedGroupID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.RestrictedGroup)
                    .WithMany(p => p.UserLoginConfiguration)
                    .HasForeignKey(d => d.RestrictedGroupId)
                    .HasConstraintName("FK_UserLoginConfiguration_RestrictedGroup");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorName).HasMaxLength(50);
            });
        }
    }
}
