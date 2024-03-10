using AspNetWebApi_Northwind.Models.Interface;
using System;
using System.Collections.Generic;

namespace AspNetWebApi_Northwind.Models.Entities;

public partial class Category: IEntity
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
