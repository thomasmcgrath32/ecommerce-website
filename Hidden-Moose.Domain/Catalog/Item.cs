using System;
using System.Collections.Generic;
namespace Hidden.Moose.Domain.Catalog
{
    public class Item
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Description {get;set;}
        public string Brand {get;set;}
        public string ImageUrl {get;set;}
        public decimal Price{get;set;}
        public List<Rating> Ratings {get;set;}

        public Item(string name, string description, string brand,string imageUrl, decimal price)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Item cannot be null.");
            }
            if(string.IsNullOrEmpty(imageUrl))
            {
                throw new ArgumentException("Image path cannot be null.");
            }
             if(string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Item description cannot be null.");
            }
             if(string.IsNullOrEmpty(brand))
            {
                throw new ArgumentException("Item brand cannot be null.");
            }
            if (price < 0.00m || price > 1000.00m)
            {
                throw new ArgumentException( "Item price must be a positive amount less than $1000.00");
            }
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.Brand = brand;
            this.Price = price;
        }
        public void AddRating(Rating rating)
        {
            this.Ratings.Add(rating);
        }
    }
}