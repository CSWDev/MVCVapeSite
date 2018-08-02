using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCVapeSite.Data;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace MVCVapeSite.Models
{
    public class seedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductsContext(
                serviceProvider.GetRequiredService<DbContextOptions<ProductsContext>>()))
            {
                if (context.Products.Any())
                {
                    return;
                }
            }
        }
    }
} 
