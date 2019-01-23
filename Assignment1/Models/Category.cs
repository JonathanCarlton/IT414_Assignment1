// Written by Jonathan Carlton
// 1/22/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
	public class Category
	{
		// class variables (private)
		private long categoryId = 0;
		private string categoryName = "n/a";
		private string description = "n/a";
		private bool active = false;

		// gets and sets

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

		public string CategoryName
		{
			get
			{
				return this.categoryName;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 15)
				{
					this.categoryName = value;
				}
			}
		}

		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
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

			message = message + "Category ID: " + this.CategoryId + "<br />";
			message = message + "Category Name: " + this.CategoryName + "<br />";
			message = message + "Description: " + this.Description + "<br />";
			message = message + "Active: " + this.Active + "<br />";

			return message;
		}



	}
}