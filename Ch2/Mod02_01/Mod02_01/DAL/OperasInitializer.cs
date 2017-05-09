using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod02_01.Models;
using System.Data.Entity;

namespace Mod02_01.DAL
{
    public class OperasInitializer : DropCreateDatabaseAlways<OperaContext> //每次執行程式都重建測試資料庫
    //public class OperasInitializer : DropCreateDatabaseIfModelChanges<OperaContext> //如果Model改變才需要重建測試資料庫
    {
        protected override void Seed(OperaContext context)
        {
            base.Seed(context);
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.Operas.Add(new Opera()
            {
                Title = "Cosi Fan Tutte",
                Year = 1790,
                Composer = "Mozart",
            });
            context.SaveChanges();
        }
    }
}
