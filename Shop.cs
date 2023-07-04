using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Shop : IDisposable
    {
        private string shopName;
        private string address;
        private string shopType;
        private bool disposed = false;
        public Shop(string shopName, string address, string shopType)
        {
            this.shopName = shopName;
            this.address = address;
            this.shopType = shopType;
        }
        public string ShopName
        {
            get { return shopName; }
            set { shopName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string ShopType
        {
            get { return shopType; }
            set { shopType = value; }
        }
        public void DisplayInformation()
        {
            Console.WriteLine("Shop Name: " + shopName);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Shop Type: " + shopType);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Очищення керованих ресурсiв.");
                }
                Console.WriteLine("Очищення некерованих ресурсiв.");
                disposed = true;
            }
        }
        ~Shop()
        {
            Dispose(false);
            Console.WriteLine("Очищено!.");
        }
    }
}
