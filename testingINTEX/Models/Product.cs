﻿using System;
using System.Collections.Generic;

namespace testingINTEX.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public int? Year { get; set; }

    public int? NumParts { get; set; }

    public decimal? Price { get; set; }

    public string? ImgLink { get; set; }

    public string? PrimaryColor { get; set; }

    public string? SecondaryColor { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? Category1 { get; set; }

    public string? Category2 { get; set; }

    public string? Category3 { get; set; }

    public int? Recommendation1 { get; set; }

    public int? Recommendation2 { get; set; }

    public int? Recommendation3 { get; set; }

    public int? Recommendation4 { get; set; }

    public int? Recommendation5 { get; set; }

    public virtual ICollection<LineItem> LineItems { get; set; } = new List<LineItem>();
}
