﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Product
    {
        /// <summary>  
        /// Gets or sets the identifier.  
        /// </summary>  
        /// <value>The identifier.</value>  
        public int Id
        {
            get;
            set;
        }

        /// <summary>  
        /// Gets or sets the name.  
        /// </summary>  
        /// <value>The name.</value>  
        public string Name
        {
            get;
            set;
        }

        /// <summary>  
        /// Gets or sets the price.  
        /// </summary>  
        /// <value>The price.</value>  
        public decimal Price
        {
            get;
            set;
        }

        /// <summary>  
        /// Gets or sets the description.  
        /// </summary>  
        /// <value>The description.</value>  
        public int Description
        {
            get;
            set;
        }
    }
}
