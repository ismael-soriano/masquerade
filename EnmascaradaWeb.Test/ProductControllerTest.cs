using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EnmascaradaWeb.Models;
using EnmascaradaWeb.Controllers;
using System.Linq;
using System.Web.Mvc;

namespace EnmascaradaWeb.Test
{
    [TestClass]
    public class ProductControllerTest
    {
        private const int PRODUCT_COUNT = 1;
        private ProductController _productController;

        [TestInitialize]
        public void Setup()
        {
            using (var ctx = new UsersContext())
            {
                if (ctx.Database.Exists())
                {
                    ctx.Database.Delete();
                }
                ctx.Database.Create();
            }
            _productController = new ProductController();
        }

        [TestMethod]
        public void CountOfProducts()
        {
            var ctx = new UsersContext();
            ctx.Products.Add(new Product() { Name = "pepe"});
            ctx.SaveChanges();
            var result = _productController.Index() as ViewResult;
            var products = result.Model as IQueryable<Product>;
            Assert.AreEqual(PRODUCT_COUNT, products.ToList().Count);
            //Assert.AreEqual(product);
        }
    }
}
