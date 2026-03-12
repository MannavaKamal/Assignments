using System;
using System.Collections.Generic;
using System.Text;

namespace _12_03_2026_3;

 class ProductApp
{
    public int Id;
    public string Name;
    public double Price;
    public double DiscountPercentage;

    public ProductApp(int id, string name, double price, double discountPercentage)
    {
        Id = id;
        Name = name;
        Price = price;
        DiscountPercentage = discountPercentage;
    }

    double CostAfterDiscount()
    {
        return Price - (Price * (DiscountPercentage / 100));
    }

    public override string ToString()
    {
        return $"Id = {Id} , Name = {Name} , Price = {Price} , DiscountPercentage = {DiscountPercentage} , CostAfterDiscount = {CostAfterDiscount()}";
    }
}
