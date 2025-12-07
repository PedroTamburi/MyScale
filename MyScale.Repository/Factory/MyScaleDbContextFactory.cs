using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MyScale.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyScale.Repository.Factory
{
    public class MyScaleDbContextFactory : IDesignTimeDbContextFactory<MyScaleDbContext>
    {
        public MyScaleDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyScaleDbContext>();

            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=MyScaleDB;User ID=developer;Password=123456789");

            return new MyScaleDbContext(optionsBuilder.Options);
        }
    }
}
