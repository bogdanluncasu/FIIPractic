﻿namespace FiiPractic.Data.Entities
{
  public class Product
  {
    public int ProductId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int GroupId { get; set; }

    public double Price { get; set; }

    public Group Group { get; set; }
  }
}
