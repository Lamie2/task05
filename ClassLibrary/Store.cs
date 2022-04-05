using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        Product[] _products=new Product[0];
        public Product[] Products { get => _products; }
        public int NotebookLimit { get; set; }
        public int PhoneLimit { get; set; }

        public void AddProduct(Product product)
        {
            foreach (var pr in _products)
            {
                if (pr is Notebook)
                {
                    Notebook notePr = pr as Notebook;
                    if (_products.Length < NotebookLimit)
                    {
                        Array.Resize(ref _products, _products.Length + 1);
                        _products[_products.Length - 1] = product;
                    }
                }
                if (pr is Phone)
                {
                    Phone phonePr = pr as Phone;
                    if (_products.Length < PhoneLimit)
                    {
                        Array.Resize(ref _products, _products.Length + 1);
                        _products[_products.Length - 1] = product;
                    }
                }

            }

            
           
        }


        public Product FindByNo(int no)
        {
            foreach (var pr in _products)
            {
                if (pr.No==no)
                {
                    return pr;
                }
            }
            Product product = new Product();
            return product;
        }


        public double CalcNotebookAvg()
        {
            int count = 0;
            double sum = 0;
            foreach (var pr in _products)
            {
                if (pr is Notebook)
                {
                    Notebook notePr = pr as Notebook;
                    count++;
                    sum += notePr.Price * (100 - notePr.DiscountPercent) / 100;
                }              
            }
            return sum / count;
        }

        public double CalcPhoneAvg()
        {
            int count = 0;
            double sum = 0;
            foreach (var pr in _products)
            {
                if (pr is Phone)
                {
                    Phone phonePr = pr as Phone;
                    count++;
                    sum += phonePr.Price*(100-phonePr.DiscountPercent)/100;
                }
            }
            return sum / count;
        }


    }
}
