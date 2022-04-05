using System;
using ClassLibrary;
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Notebook notebook = new Notebook();
            notebook.No = 7;
            notebook.Price = 4000;
            notebook.DiscountPercent = 15;

            Notebook notebook1 = new Notebook();
            notebook1.No = 11;
            notebook1.Price = 3000;
            notebook1.DiscountPercent = 0;

            Notebook notebook2 = new Notebook();
            notebook2.No = 11;
            notebook2.Price = 4500;
            notebook2.DiscountPercent = 30;


            Phone phone = new Phone();
            phone.No = 1;
            phone.Price = 1500;
            phone.DiscountPercent = 20;


            Phone phone1 = new Phone();
            phone1.No = 2;
            phone1.Price = 2000;
            phone1.DiscountPercent = 0;

            Product product = new Product();
            Store store = new Store();
            store.NotebookLimit = 2;
            store.PhoneLimit = 2;

            store = notebook;
            
            
        }
    }
}
