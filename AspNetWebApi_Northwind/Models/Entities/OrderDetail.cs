﻿using AspNetWebApi_Northwind.Models.Interface;
using System;
using System.Collections.Generic;

namespace AspNetWebApi_Northwind.Models.Entities;

public partial class OrderDetail: IEntity
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
