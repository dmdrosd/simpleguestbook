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
                            Message = @"�������� � ������� �����, �� ������� 1919 ���� , ������������ ���� ��������� 1896 ��� ��� ��� �������� � �������� ������������ ���������������� ������ ����������� ������������, �� ��������� ���������, ��������� ��� � �������. ����� ���������� ������ ������ ����� ���������� ����� ������ �������� ���� ��������� ������� ����, ��� � ��� ���������� ���� �������������. �������� ������� �������������, ���������� 27 ������� 1945 ���� , ������� � ������ ������� ���� (�������� ������ �� 22.04.1920, � ������ �������",
                            Name = "������ ���� ��������"
                        }, new GuestbookEntry
                        {
                            //Id = 2,
                            DateAdded = DateTime.Now,
                            Message = @"��������� ����� ���������� �����, ������� ���� ������� �������, ��������� ������ ��������� � ����������� ������� � �������. � ���� ������� ������������� ����� ��������������� ������� ��������� ���������� ������������ ������ ����� ������ ���������� ������������������, ����������� ���������� ������������������. � ������������ ����� ��� ��������� ���������� �����, ���������� ��������, ����� ��������� �������� ��������. ����� ������ �. �. ������� ���� ������ ������������ �������� ������� ����, � � 1955 �� 1957 ��� � ���������������� ����.",
                            Name = "������ ���� ��������"
                        });

            //context.SaveChanges();

            base.Seed(context);
        }
    }
}
