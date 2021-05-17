using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Модернизация
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Автор> Автор { get; set; }
        public virtual DbSet<Выдача_книг> Выдача_книг { get; set; }
        public virtual DbSet<Журналы> Журналы { get; set; }
        public virtual DbSet<Издательство> Издательство { get; set; }
        public virtual DbSet<Книги> Книги { get; set; }
        public virtual DbSet<Личные_данные_о_читателях> Личные_данные_о_читателях { get; set; }
        public virtual DbSet<Темы> Темы { get; set; }
        public virtual DbSet<Читатели> Читатели { get; set; }
        public virtual DbSet<Корзина_заказов> Корзина_заказов { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
