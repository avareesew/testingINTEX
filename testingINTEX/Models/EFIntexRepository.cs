﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testingINTEX.Models;

namespace testingINTEX.Models
{
    public class EFIntexRepository : IIntexRepository
    {
        private readonly IntexpostgresContext _context;

        public EFIntexRepository(IntexpostgresContext context)
        {
            _context = context;
        }

        public List<Customer> Customers => _context.Customers.ToList();

        public List<LineItem> LineItems => _context.LineItems.ToList();
        
        public List<Order> Orders => _context.Orders.ToList();
        
        public List<Product> Products => _context.Products.ToList();
        
        
        public void AdminDeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void AdminAddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void AdminUpdateProduct(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public void AdminAddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        

        public void AdminUpdateOrder(Order order)
        {
            _context.Update(order);
            _context.SaveChanges();   
        }

        public void AdminDeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();  
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public Customer GetCustomerByAspUserId(string userId)
        {
            // Parse the string userId to a Guid
            Guid parsedUserId;
            if (!Guid.TryParse(userId, out parsedUserId))
            {
                // Handle invalid userId here, or return null, or throw an exception
                return null;
            }
            // Implement the logic to retrieve the customer by ASP.NET Core Identity user ID
            return _context.Customers.FirstOrDefault(c => c.AspUserId == parsedUserId);
        }
        public IEnumerable<Product> GetProductsByIds(IEnumerable<int> productIds)
        {
            return _context.Products.Where(p => productIds.Contains(p.ProductId)).ToList();
        }
    }
}
