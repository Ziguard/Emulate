using ClassLibrary2.Entities.Generator;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emulate.entities;
using Emulate.json;

namespace Emulate.database
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MySQLFullDB : DbContext
    {

        public DbSet<Items> ItemsTable { get; set; }

        //public DbSet<Anneau> AnneauTable { get; set; }
        //public DbSet<Casque> CasqueTable { get; set; }
        //public DbSet<Cou> CouTable { get; set; }
        //public DbSet<Dos> DosTable { get; set; }
        //public DbSet<Epauliere> EpauliereTable { get; set; }
        //public DbSet<Mains> MainsTable { get; set; }
        //public DbSet<Torse> TorseTable { get; set; }

        public MySQLFullDB()
            : base(JsonManager.Instance.ReadFile<ConnectionString>(@"..\..\..\jsonconfig\", @"MysqlConfig.json").ToString())
        {
            InitLocalMySQL();
        }

        public void InitLocalMySQL()
        {
            if (this.Database.CreateIfNotExists())
            {
                EntityGenerator<Items> generatorAnneau = new EntityGenerator<Items>();
                for (int i = 0; i < 10; i++)
                {
                    ItemsTable.Add(generatorAnneau.GenerateItem());
                }



                //EntityGenerator<Anneau> generatorAnneau = new EntityGenerator<Anneau>();
                //for (int i = 0; i < 10; i++)
                //{
                //    AnneauTable.Add(generatorAnneau.GenerateItem());
                //}

                //EntityGenerator<Casque> generatorCasque = new EntityGenerator<Casque>();
                //for (int i = 0; i < 20; i++)
                //{
                //    CasqueTable.Add(generatorCasque.GenerateItem());
                //}

                //EntityGenerator<Cou> generatorCou = new EntityGenerator<Cou>();
                //for (int i = 0; i < 10; i++)
                //{
                //    CouTable.Add(generatorCou.GenerateItem());

                //}

                //EntityGenerator<Dos> generatorDos = new EntityGenerator<Dos>();
                //for (int i = 0; i < 10; i++)
                //{
                //    DosTable.Add(generatorDos.GenerateItem());
                //}

                //EntityGenerator<Epauliere> generatorEpauliere = new EntityGenerator<Epauliere>();
                //for (int i = 0; i < 10; i++)
                //{
                //    EpauliereTable.Add(generatorEpauliere.GenerateItem());
                //}

                //EntityGenerator<Mains> generatorMains = new EntityGenerator<Mains>();
                //for (int i = 0; i < 10; i++)
                //{
                //    MainsTable.Add(generatorMains.GenerateItem());
                //}


                //EntityGenerator<Torse> generatorTorse = new EntityGenerator<Torse>();
                //for (int i = 0; i < 10; i++)
                //{
                //    TorseTable.Add(generatorTorse.GenerateItem());
                //}

                this.SaveChangesAsync();


                //AddressTable.Find(1).StreetNumber = StreetNumberTable.Find(1);
                //this.SaveChangesAsync();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
