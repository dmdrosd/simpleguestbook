using System;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace SimpleGuestBook.Models
{
    public partial class GuestBookModel : DbContext
    {
        static GuestBookModel()
        {
            Database.SetInitializer<GuestBookModel>(new GuestBookModelInitializer());
        }

        public GuestBookModel()
            : base("name=GuestBookModel")
        {
        }

        public DbSet<GuestbookEntry> GuestbookEntries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }

    public class GuestBookModelInitializer : DropCreateDatabaseIfModelChanges<GuestBookModel>
    {
        protected override void Seed(GuestBookModel context)
        {
            context.GuestbookEntries.AddOrUpdate(
                        new GuestbookEntry
                        {
                            //Id = 1,
                            DateAdded = DateTime.Now,
                            Message = @"Находясь в Красной Армии, не позднее 1919 года , Рокоссовский стал указывать 1896 год как год рождения и писаться Константином Константиновичем вместо Константина Ксаверьевича, по некоторым сведениям, настоящее имя — Казимир. После присвоения звания дважды Героя Советского Союза местом рождения стал указывать Великие Луки, где и был установлен бюст Рокоссовского. Согласно краткой автобиографии, написанной 27 декабря 1945 года , родился в городе Великие Луки (согласно анкете от 22.04.1920, в городе Варшаве",
                            Name = "Иванов Иван Иванович"
                        }, new GuestbookEntry
                        {
                            //Id = 2,
                            DateAdded = DateTime.Now,
                            Message = @"Четырежды Герой Советского Союза, кавалер двух орденов «Победа», множества других советских и иностранных орденов и медалей. В ходе Великой Отечественной войны последовательно занимал должности начальника Генерального штабам члена Ставки Верховного Главнокомандования, заместителя Верховного Главнокомандующего. В послевоенное время был Главкомом сухопутных войск, командовал Одесским, затем Уральским военными округами. После смерти И. В. Сталина стал первым заместителем министра обороны СССР, а с 1955 по 1957 год — министромобороны СССР.",
                            Name = "Петров Петр Петрович"
                        });

            //context.SaveChanges();

            base.Seed(context);
        }
    }
}
