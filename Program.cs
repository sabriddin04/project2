var product1 = new Product();
product1.ProductId = "1";
product1.Name = "daftar";
product1.Price = 6;

var product2 = new Product();
product1.ProductId = "2";
product1.Name = "ruchka";
product1.Price = 5;

var customer1 = new Customer();
customer1.CustomerId = "1";
customer1.Name = "Sabriddin";
var customer2 = new Customer();
customer2.CustomerId = "2";
customer2.Name = "Sabr";

var ShoppingCart1=new ShoppingCart();
ShoppingCart1.AddToCart(product1,2);
ShoppingCart1.AddToCart(product2,4);


var system=new ECommerceSystem();
system.AddProduct(product1);
system.AddProduct(product2);
system.AddCustomer(customer1);
system.AddCustomer(customer2);

system.PlaceOrder(customer1,ShoppingCart1);

system.DisplayAllOrders();




