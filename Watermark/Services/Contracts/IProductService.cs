﻿using System.Collections.Generic;
using Watermark.Models.Products;

namespace Watermark.Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProductById(int id);
    }
}