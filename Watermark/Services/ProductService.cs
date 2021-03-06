﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Watermark.Models.Products;
using Watermark.Repository.Contracts;
using Watermark.Services.Contracts;

namespace Watermark.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository ProductRepository { get; set; }

        public ProductService(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return ProductRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return ProductRepository.GetProductById(id);
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            return await ProductRepository.AddProductAsync(product);
        }
    }
}