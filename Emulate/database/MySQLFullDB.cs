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
using Emulate.views;

namespace Emulate.database
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MySQLFullDB : DbContext
    {

        public DbSet<Items> ItemsTable { get; set; }
        public DbSet<Party> PartyTable { get; set; }
        public DbSet<Character> CharacterTable { get; set; }
        public DbSet<Boss> BossTable { get; set; }
        public DbSet<Donjon> DonjonTable { get; set; }
        public DbSet<Loot> BagTable { get; set; }


        public MySQLFullDB()
            : base(JsonManager.Instance.ReadFile<ConnectionString>(@"..\..\..\jsonconfig\", @"MysqlConfig.json").ToString())
        {
            InitLocalMySQL();
        }

        public void InitLocalMySQL()
        {
            if (this.Database.CreateIfNotExists())
            {
                EntityGenerator<Items> generatorItems = new EntityGenerator<Items>();
                for (int i = 0; i < 60; i++)
                {
                    ItemsTable.Add(generatorItems.GenerateItem());
                }

                EntityGenerator<Party> generatorParty = new EntityGenerator<Party>();
                for (int i = 0; i < 3; i++)
                {
                    PartyTable.Add(generatorParty.GenerateItem());
                }

                EntityGenerator<Character> generatorPersonnage = new EntityGenerator<Character>();
                for (int i = 0; i < 15; i++)
                {
                    CharacterTable.Add(generatorPersonnage.GenerateItem());
                }

                EntityGenerator<Boss> generatorBoss = new EntityGenerator<Boss>();
                for (int i = 0; i < 20; i++)
                {
                    BossTable.Add(generatorBoss.GenerateItem());
                }

                EntityGenerator<Donjon> generatorDonjon = new EntityGenerator<Donjon>();
                for (int i = 0; i < 5; i++)
                {
                    DonjonTable.Add(generatorDonjon.GenerateItem());
                }

                this.SaveChangesAsync();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
