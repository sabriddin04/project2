class ShoppingCart
{
     Dictionary<Product,int> CartItems =new Dictionary<Product, int>();

    public void AddToCart(Product product,int quantity){

        if(CartItems.ContainsKey(product)){
            CartItems[product]+=quantity;
        }
        else{
        CartItems.Add(product,quantity);}
    }
    public  Dictionary<Product,int>  GetCart(){
        return CartItems;
    }
}