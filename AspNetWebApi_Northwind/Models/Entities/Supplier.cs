using AspNetWebApi_Northwind.Models.Interface;
using System;
using System.Collections.Generic;

namespace AspNetWebApi_Northwind.Models.Entities;

public partial class Supplier: IEntity
{
    public int SupplierId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? ContactTitle { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? HomePage { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
