﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceEntities;
using Specification;
using ECommerceDALLib;

namespace ECommerceServices.DBServices
{
    public class ProductService:IProductService
    {
        public bool Delete(int id)
        {
            DBManager.Delete(id);

            return false;
        }

        public Product Get(int id)
        {
            Product foundProduct = DBManager.GetById(id);

            return foundProduct;
        }

        public List<Product> GetAll()
        {
            List<Product> products = DBManager.GetAll();
            return products;
        }

        public bool Insert(Product product)
        {
            List<Product> allProducts = GetAll();

            return false;
        }

        public bool Update(Product productTobeUpdated)
        {
            Product theProduct = Get(productTobeUpdated.ProductId);

            return false;
        }
    }
}