using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class EntityFrameworkSqlServerContext : DbContext
    {
        /// <summary>  
        /// Initializes a new instance of the <see cref="EntityFrameworkSqlServerContext"/> class.  
        /// </summary>  
        /// <param name="options">The options.</param>  
        public EntityFrameworkSqlServerContext(DbContextOptions<EntityFrameworkSqlServerContext> options) : base(options)
        {
            // Creates the database !! Just for DEMO !! in production code you have to handle it differently!  
            this.Database.EnsureCreated();
        }



            
        /// <summary>  
        /// Gets or sets the products.  
        /// </summary>  
        /// <value>The products.</value>  
        public DbSet<Product> Products
        {
            get;
            set;
        }
    }
}
