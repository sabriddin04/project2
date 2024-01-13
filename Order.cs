class Order
{
    public string OrderId { get; set; }
    public Customer? Customer { get; set; }

    public Dictionary<Product, int> OrderedItems { get; set; }
    public double TotalAmount { get; set; }
    public OrderStatus OrderStatus { get; set; }

    public DateTime OrderDate { get; set; }


    public void UpdateStatus(OrderStatus status){
     OrderStatus=status;
    }
    






}