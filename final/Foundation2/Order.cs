using System;

class Order{
    // Names and addresses found in CustomerOrders.txt were made up by Bing's AI
    private string _customerOrders = "CustomerOrders.txt";
    private string _rawOrders;
    private int _shippingCost;
    private List<string> _ordersList = new List<string>();

    public void LoadOrders (){
        foreach (string line in File.ReadLines(_customerOrders)){
            _ordersList.Add(line);
            }
        }
    
    public void PrepOrders(string rawOrders){
        Customer newCustomer = new Customer ();
        Product productRequest = new Product ();
        string [] parts = rawOrders.Split("|||");
        newCustomer.ProcessCustomerInfo (parts[0],parts[1]);
        productRequest.ProcessRawOrder(parts[2]);
        CalculateShipping (newCustomer.GetIsUSA());
        }
    
    public void DisplayOrders (string customerName, string customerAddress, string requestedParts, int shippingCost, double totalCost){
        Console.WriteLine ("Shipping Label");
        Console.WriteLine ();
        Console.WriteLine ();
        Console.WriteLine ();
        Console.WriteLine ();
        }
    
    public void CalculateShipping (bool isUSA){
        if (isUSA){
            _shippingCost = 5;
            }
        else{
            _shippingCost = 35;
            }
        }

    public Order(){
        LoadOrders();
        foreach (string order in _ordersList){
            _rawOrders = order;
            PrepOrders (_rawOrders);
            }
        }
    }