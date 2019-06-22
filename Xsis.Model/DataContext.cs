using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Name=NgxsisConn")
        {
            //Database.SetInitializer(new Initializer());
            Database.SetInitializer<DataContext>(null);
        }

        public virtual DbSet<AddrBook> AddrBook { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Biodata> Biodata { get; set; }
        public virtual DbSet<Biodata_Attachment> Biodata_Attachment { get; set; }
        public virtual DbSet<Catatan> Catatan { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Educational_Level> Educational_Level { get; set; }
        public virtual DbSet<Family_Relation> Family_Relation { get; set; }
        public virtual DbSet<Family_Tree_Type> Family_Tree_Type { get; set; }
        public virtual DbSet<Identity_Type> Identity_Type { get; set; }
        public virtual DbSet<Keahlian> Keahlian { get; set; }
        public virtual DbSet<Keluarga> Keluarga { get; set; }
        public virtual DbSet<Keterangan_Tambahan> Keterangan_Tambahan { get; set; }
        public virtual DbSet<Marital_Status> Marital_Status { get; set; }
        public virtual DbSet<Menu_Access> Menu_Access { get; set; }
        public virtual DbSet<MenuTree> MenuTree { get; set; }
        public virtual DbSet<Note_Type> Note_Type { get; set; }
        public virtual DbSet<Online_Test> Online_Test { get; set; }
        public virtual DbSet<Online_Test_Detail> Online_Test_Detail { get; set; }
        public virtual DbSet<Organisasi> Organisasi { get; set; }
        public virtual DbSet<Pe_Referensi> Pe_Referensi { get; set; }
        public virtual DbSet<Religion> Religion { get; set; }
        public virtual DbSet<Rencana_Jadwal> Rencana_Jadwal { get; set; }
        public virtual DbSet<Rencana_Jadwal_Detail> Rencana_Jadwal_Detail { get; set; }
        public virtual DbSet<Riwayat_Pekerjaan> Riwayat_Pekerjaan { get; set; }
        public virtual DbSet<Riwayat_Pelatihan> Riwayat_Pelatihan { get; set; }
        public virtual DbSet<Riwayat_Pendidikan> Riwayat_Pendidikan { get; set; }
        public virtual DbSet<Riwayat_Proyek> Riwayat_Proyek { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Schedule_Type> Schedule_Type { get; set; }
        public virtual DbSet<Sertifikasi> Sertifikasi { get; set; }
        public virtual DbSet<Skill_Level> Skill_Level { get; set; }
        public virtual DbSet<Sumber_Loker> Sumber_Loker { get; set; }
        public virtual DbSet<Test_Type> Test_Type { get; set; }
        public virtual DbSet<Time_Period> Time_Period { get; set; }
        public virtual DbSet<Undangan> Undangan { get; set; }
        public virtual DbSet<Undangan_Detail> Undangan_Detail { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
