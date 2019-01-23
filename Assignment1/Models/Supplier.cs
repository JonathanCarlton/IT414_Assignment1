// Written by Jonathan Carlton
// 1/22/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
	public class Supplier
	{
		// class variables (private)
		private long supplierId = 0;
		private string companyName = "n/a";
		private string contactName = "n/a";
		private string contactTitle = "n/a";
		private string address = "n/a";
		private string city = "n/a";
		private string region = "n/a";
		private string postalCode = "n/a";
		private string country = "n/a";
		private string phone = "n/a";
		private string fax = "n/a";
		private string homePage = "n/a";
		private bool discontinued = false;

		// gets and sets

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

		public string CompanyName
		{
			get
			{
				return this.companyName;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 40)
				{
					this.companyName = value;
				}
			}
		}
		public string ContactName
		{
			get
			{
				return this.contactName;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 30)
				{
					this.contactName = value;
				}
			}
		}
		public string ContactTitle
		{
			get
			{
				return this.contactTitle;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 30)
				{
					this.contactTitle = value;
				}
			}
		}
		public string Address
		{
			get
			{
				return this.address;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 60)
				{
					this.address = value;
				}
			}
		}
		public string City
		{
			get
			{
				return this.city;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 15)
				{
					this.city= value;
				}
			}
		}
		public string Region
		{
			get
			{
				return this.region;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 15)
				{
					this.region = value;
				}
			}
		}
		public string PostalCode
		{
			get
			{
				return this.postalCode;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 10)
				{
					this.postalCode = value;
				}
			}
		}
		public string Country
		{
			get
			{
				return this.country;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 15)
				{
					this.country = value;
				}
			}
		}
		public string Phone
		{
			get
			{
				return this.phone;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 24)
				{
					this.phone = value;
				}
			}
		}
		public string Fax
		{
			get
			{
				return this.fax;
			}
			set
			{
				if (value.Length >= 1 && value.Length <= 24)
				{
					this.fax = value;
				}
			}
		}

		public string HomePage
		{
			get
			{
				return this.homePage;
			}
			set
			{
				this.homePage = value;
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

		//Methods
		public override string ToString()
		{
			string message = "";

			message = message + "Supplier ID: " + this.SupplierId + "<br />";
			message = message + "Company Name: " + this.CompanyName + "<br />";
			message = message + "Contact Name: " + this.ContactName + "<br />";
			message = message + "Contact Title: " + this.ContactTitle + "<br />";
			message = message + "Address: " + this.Address + "<br />";
			message = message + "City: " + this.City + "<br />";
			message = message + "Region: " + this.Region + "<br />";
			message = message + "Postal Code: " + this.PostalCode + "<br />";
			message = message + "Country: " + this.Country + "<br />";
			message = message + "Phone: " + this.Phone + "<br />";
			message = message + "Fax: " + this.Fax + "<br />";
			message = message + "Home Page: " + this.HomePage + "<br />";
			message = message + "Discontinued: " + this.Discontinued + "<br />";

			return message;
		}

		public string FullAddress()
		{
			string address = "";
			address = address + this.ContactTitle + ": " + this.ContactName + "<br /r>" + this.CompanyName + "<br /r>";
			address = address + this.Address + " " + this.City + ", " + this.Region + "<br /r> " + this.PostalCode + "<br /r> " + this.Country;

			return address;
		}


	}
}
