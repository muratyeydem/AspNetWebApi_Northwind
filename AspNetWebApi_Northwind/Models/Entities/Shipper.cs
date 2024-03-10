using AspNetWebApi_Northwind.Models.Interface;
using System;
using System.Collections.Generic;

namespace AspNetWebApi_Northwind.Models.Entities;

public partial class Shipper: IEntity
{
    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
