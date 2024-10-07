using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using lab2prog2;

namespace CodeFirst
{
    public class JobContext : DbContext
    {
        // Контекст настроен для использования строки подключения "GameCS" из файла конфигурации  
        // приложения (App.config).
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "GameCS" 
        // в файле конфигурации приложения.
        public JobContext() : base("JobCS") { }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
