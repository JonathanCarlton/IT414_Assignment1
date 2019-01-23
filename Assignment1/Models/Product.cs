// Written by Jonathan Carlton
// 1/22/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
	public class Product
	{
		// class variables (private)
		private long productId = 0;
		private string productName = "n/a";
		private long supplierId = 0;
		private long categoryId = 0;
		private string quantityPerUnit = "n/a";
		private decimal unitPrice = 1000000.00m;
		private long unitsInStock = 0;
		private int unitsOnOrder = 0;
		private int reorderLevel = -1;
		private bool discontinued = false;
		private bool active = false;

		// gets and sets

		public long ProductId
		{
			get
			{
				return this.productId;
			}
			set
			{
				if (value > 0)
				{
					this.productId = value;
				}

			}
		}

		public string ProductName
		{
			get
			{
				return this.productName;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 40)
				{
					this.productName = value;
				}
			}
		}

		public long SupplierId
		{
			get
			{
				return this.supplierId;
			}
			set
			{
				if (value > 0)
				{
					this.supplierId = value;
				}
			}
		}

		public long CategoryId
		{
			get
			{
				return this.categoryId;
			}
			set
			{
				if (value > 0)
				{
					this.categoryId = value;
				}
			}
		}

		public string QuantityPerUnit
		{
			get
			{
				return this.quantityPerUnit;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 20)
				{
					this.quantityPerUnit = value;
				}
			}
		}

		public decimal UnitPrice
		{
			get
			{
				return this.unitPrice;
			}
			set
			{
				if (value > 0)
				{
					this.unitPrice = value;
				}
			}
		}
		
		public long UnitsInStock
		{
			get
			{
				return this.unitsInStock;
			}
			set
			{
				if(value >= 0)
				{
					this.unitsInStock = value;
				}
			}
		}

		public int UnitsOnOrder
		{
			get
			{
				return this.unitsOnOrder;
			}
			set
			{
				if (value >= 0)
				{
					this.unitsOnOrder = value;
				}
			}
		}

		public int ReorderLevel
		{
			get
			{
				return this.reorderLevel;
			}
			set
			{
				if (value >= 0)
				{
					this.reorderLevel = value;
				}
			}
		}

		public bool Discontinued
		{
			get
			{
				return this.discontinued;
			}
			set
			{
				this.discontinued = value;
			}
		}

		public bool Active
		{
			get
			{
				return this.active;
			}
			set
			{
				this.active = value;
			}
		}

		//Methods
		public override string ToString()
		{
			string message = "";

			message = message + "Product ID: " + this.ProductId + "<br />";
			message = message + "Product Name: " + this.ProductName + "<br />";
			message = message + "Supplier ID: " + this.SupplierId + "<br />";
			message = message + "Category ID: " + this.CategoryId + "<br />";
			message = message + "Quantity Per Unit: " + this.QuantityPerUnit + "<br />";
			message = message + "Unit Price: $" + this.UnitPrice + "<br />";
			message = message + "Units in Stock: " + this.UnitsInStock + "<br />";
			message = message + "Units on Order: " + this.UnitsOnOrder + "<br />";
			message = message + "Reorder Level: " + this.ReorderLevel + "<br />";
			message = message + "Discontinued: " + this.Discontinued + "<br />";
			message = message + "Active: " + this.Active + "<br />";

			return message;
		}



	}
}
