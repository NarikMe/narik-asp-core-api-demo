using System;
using Microsoft.EntityFrameworkCore;

namespace NarikDemo.Data
{
    public partial class NarikDemoDbContext
    {

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        [DbFunction("ToPersianDate")]
        public static string ToPersianDate (DateTime? date)
        {
            throw new Exception(); // this code doesn't get executed; the call is passed through to the database function
        }
    }
}
