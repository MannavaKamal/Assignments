using System;
using System.Collections.Generic;
using System.Text;

namespace _12_03_2026;

 class Book
{
    public string Title;
    public string Author;
    public double Price;
    public bool IsBestseller;

    public Book(string title, string author, double price, bool isBestseller)
    {
        Title = title;
        Author = author;
        Price = price;
        IsBestseller = isBestseller;
    }

    public double CalculateDiscountedPrice()
    {
        double finalPrice = Price;
        
        if (IsBestseller)
        {
            finalPrice -= finalPrice * 0.10;
        }
        
        if (Price > 500)
        {
            finalPrice -= finalPrice * 0.05;
        }

        return finalPrice;
    }
}
