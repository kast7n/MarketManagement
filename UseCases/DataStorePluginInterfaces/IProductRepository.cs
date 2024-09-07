﻿using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(int productId, Product product);
        Product? GetProductById(int productId, bool loadCategory = false);
        IEnumerable<Product> GetProducts(bool loadCategory = false);
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    }
}