// Written by Jonathan Carlton
// 1/22/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			// create instances of objects for each class
			Product product1 = new Product();
			Product product2 = new Product();
			Product product3 = new Product();
			Product product4 = new Product();
			Product product5 = new Product();

			Category category1 = new Category();
			Category category2 = new Category();
			Category category3 = new Category();
			Category category4 = new Category();
			Category category5 = new Category();

			Supplier supplier1 = new Supplier();
			Supplier supplier2 = new Supplier();
			Supplier supplier3 = new Supplier();
			Supplier supplier4 = new Supplier();
			Supplier supplier5 = new Supplier();

			// create lists for each object
			List<Product> listOfProducts = new List<Product>();
			List<Category> listOfCategories = new List<Category>();
			List<Supplier> listOfSuppliers = new List<Supplier>();

			// create data for each individual object

			// supplier data
			supplier1.SupplierId = 2001;
			supplier1.CompanyName = "Big Clothing Company";
			supplier1.ContactName = "Joe Stern";
			supplier1.ContactTitle = "Distribution Coordinator";
			supplier1.Address = "4 Lukken Trail";
			supplier1.City = "Evansville";
			supplier1.Region = "IN";
			supplier1.PostalCode = "47705";
			supplier1.Country = "United States";
			supplier1.Phone = "812-566-1416";
			supplier1.Fax = "812-910-0588";
			supplier1.HomePage = "www.bigclothingcompany.com";
			supplier1.Discontinued = false;

			supplier2.SupplierId = 2002;
			supplier2.CompanyName = "Healthy Choices";
			supplier2.ContactName = "Ronnie Rowes";
			supplier2.ContactTitle = "Head of Distribution";
			supplier2.Address = "109 Hanover Terrace";
			supplier2.City = "Alexandria";
			supplier2.Region = "VA";
			supplier2.PostalCode = "22333";
			supplier2.Country = "United States";
			supplier2.Phone = "571-889-7263";
			supplier2.Fax = "571-736-1371";
			supplier2.HomePage = "www.healthychoices.com";
			supplier2.Discontinued = false;

			supplier3.SupplierId = 2003;
			supplier3.CompanyName = "Bigest Pharma";
			supplier3.ContactName = "Helen Allpress";
			supplier3.ContactTitle = "Sales Director";
			supplier3.Address = "1927 Oxford Circle";
			supplier3.City = "Columbus";
			supplier3.Region = "GA";
			supplier3.PostalCode = "31904";
			supplier3.Country = "United States";
			supplier3.Phone = "706-202-8580";
			supplier3.Fax = "706-965-6365";
			supplier3.HomePage = "www.biggestpharma.com";
			supplier3.Discontinued = false;

			supplier4.SupplierId = 2004;
			supplier4.CompanyName = "Electronics Unlimited";
			supplier4.ContactName = "Rolph Brinklow";
			supplier4.ContactTitle = "Distribution Coordinator";
			supplier4.Address = "82 Wayridge Lane";
			supplier4.City = "Washington";
			supplier4.Region = "DC";
			supplier4.PostalCode = "20566";
			supplier4.Country = "United States";
			supplier4.Phone = "202-798-1505";
			supplier4.Fax = "202-132-2634";
			supplier4.HomePage = "www.electronicsunlimited.com";
			supplier4.Discontinued = false;

			supplier5.SupplierId = 2005;
			supplier5.CompanyName = "Furnish Your Life";
			supplier5.ContactName = "Wallace Petcher";
			supplier5.ContactTitle = "Head of Distribution";
			supplier5.Address = "55 Prairie Rose Way";
			supplier5.City = "Orlando";
			supplier5.Region = "FL";
			supplier5.PostalCode = "32819";
			supplier5.Country = "United States";
			supplier5.Phone = "941-185-7438";
			supplier5.Fax = "941-101-9917";
			supplier5.HomePage = "www.furnishyourlife.com";
			supplier5.Discontinued = false;

			// category data
			category1.CategoryId = 3001;
			category1.CategoryName = "Clothing";
			category1.Description = "Fasionable clothing options to accomodate any style.";
			category1.Active = true;

			category2.CategoryId = 3002;
			category2.CategoryName = "Electronics";
			category2.Description = "Technology such as TVs, video games, computers etc.";
			category2.Active = true;

			category3.CategoryId = 3003;
			category3.CategoryName = "Pharmacy";
			category3.Description = "Medicinal drugs and related products.";
			category3.Active = true;

			category4.CategoryId = 3004;
			category4.CategoryName = "Grocery";
			category4.Description = "Food and related products";
			category4.Active = true;

			category5.CategoryId = 3005;
			category5.CategoryName = "Home Goods";
			category5.Description = "Furniture and goods to decorate your home.";
			category5.Active = true;

			// product data
			product1.ProductId = 1001;
			product1.ProductName = "Black Sweatshirt";
			product1.SupplierId = 2001;
			product1.CategoryId = 3001;
			product1.QuantityPerUnit = "1";
			product1.UnitPrice = 29.99m;
			product1.UnitsInStock = 15;
			product1.UnitsOnOrder = 14;
			product1.ReorderLevel = 6;
			product1.Discontinued = false;
			product1.Active = true;

			product2.ProductId = 1002;
			product2.ProductName = "65inch 4k TV";
			product2.SupplierId = 2004;
			product2.CategoryId = 3002;
			product2.QuantityPerUnit = "1";
			product2.UnitPrice = 799.99m;
			product2.UnitsInStock = 8;
			product2.UnitsOnOrder = 8;
			product2.ReorderLevel = 2;
			product2.Discontinued = false;
			product2.Active = true;

			product3.ProductId = 1003;
			product3.ProductName = "Ibuprofen";
			product3.SupplierId = 2003;
			product3.CategoryId = 3003;
			product3.QuantityPerUnit = "50";
			product3.UnitPrice = 3.50m;
			product3.UnitsInStock = 35;
			product3.UnitsOnOrder = 50;
			product3.ReorderLevel = 15;
			product3.Discontinued = false;
			product3.Active = true;
		
			product4.ProductId = 1004;
			product4.ProductName = "Classico Pasta Sauce";
			product4.SupplierId = 2002;
			product4.CategoryId = 3004;
			product4.QuantityPerUnit = "1";
			product4.UnitPrice = 2.89m;
			product4.UnitsInStock = 20;
			product4.UnitsOnOrder = 25;
			product4.ReorderLevel = 6;
			product4.Discontinued = false;
			product4.Active = true;
		
			product5.ProductId = 1005;
			product5.ProductName = "Brown Leather Loveseat";
			product5.SupplierId = 2005;
			product5.CategoryId = 3005;
			product5.QuantityPerUnit = "1";
			product5.UnitPrice = 699.99m;
			product5.UnitsInStock = 4;
			product5.UnitsOnOrder = 3;
			product5.ReorderLevel = 1;
			product5.Discontinued = false;
			product5.Active = true;

			// insert data into listOfProducts
			listOfProducts.Add(product1);
			listOfProducts.Add(product2);
			listOfProducts.Add(product3);
			listOfProducts.Add(product4);
			listOfProducts.Add(product5);

			// insert data into listOfCategories
			listOfCategories.Add(category1);
			listOfCategories.Add(category2);
			listOfCategories.Add(category3);
			listOfCategories.Add(category4);
			listOfCategories.Add(category5);

			// insert data into listOfSuppliers
			listOfSuppliers.Add(supplier1);
			listOfSuppliers.Add(supplier2);
			listOfSuppliers.Add(supplier3);
			listOfSuppliers.Add(supplier4);
			listOfSuppliers.Add(supplier5);

			ViewBag.ProductList = listOfProducts;
			ViewBag.CategoryList = listOfCategories;
			ViewBag.SupplierList = listOfSuppliers;
			return View();
        }
    }
}