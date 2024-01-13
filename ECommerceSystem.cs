class ECommerceSystem
{
   List<Product> products = new List<Product>();
   List<Customer> customers = new List<Customer>();
   List<Order> orders = new List<Order>();



   public void AddProduct(Product product)
   {
      products.Add(product);
   }
   public void AddCustomer(Customer customer)
   {
      customers.Add(customer);
   }

   public void UpdateOrderStatus(string orderId, OrderStatus status)
   {

      var elem = orders.FirstOrDefault(x => x.OrderId == orderId);
      if (elem != null)
      {
         elem.UpdateStatus(status);
      }
   }

   public void PlaceOrder(Customer customer, ShoppingCart cart)
   {
      var order = new Order
      {
         OrderId = Guid.NewGuid().ToString(),
         Customer = customer,
         OrderedItems = cart.GetCart(),
         TotalAmount = cart.GetCart().Sum(item => item.Key.Price * item.Value),
         OrderStatus = OrderStatus.Placed,
         OrderDate = DateTime.Now
      };

      orders.Add(order);

   }


   public void DisplayAllOrders()
   {
      foreach (var item in orders)
      {
         System.Console.WriteLine("OrderID:"+item.OrderId); 
         System.Console.WriteLine("OrderedItems:");
         foreach (var item1 in item.OrderedItems)
         {
            System.Console.WriteLine($"{item1.Key.Name}-quantity:{item1.Value}");

         }
         System.Console.WriteLine("TotalAmount:"+item.TotalAmount);
         System.Console.WriteLine("OrderStatus:"+item.OrderStatus);
         System.Console.WriteLine("OrderDate:"+item.OrderDate);
      }



   }
}

