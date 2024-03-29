using System;

class Order{
    // Names and addresses found in CustomerOrders.txt were made up by Bing's AI
    private string _customerOrders = "CustomerOrders.txt";
    private string _rawOrders;
    private int _shippingCost;
    private double _grandTotal;
    private List<string> _ordersList = new List<string>();

    public void LoadOrders (){
        foreach (string line in File.ReadLines(_customerOrders)){
            _ordersList.Add(line);
            }
        }
    
    public void PrepOrders(string rawOrders){
        Customer newCustomer = new Customer ();
        string [] parts = rawOrders.Split("|||");
        newCustomer.ProcessCustomerInfo (parts[0],parts[1]);
        Product productRequest = new Product (parts[2]);
        CalculateShipping (newCustomer.GetIsUSA());
        newCustomer.AssembleShippingLabel();
        productRequest.AssemblePackingLabel();
        DisplayOrders (newCustomer.GetShippingLabel(),productRequest.GetPackingLabel(),productRequest.GetTotal());
        }
    
    public void DisplayOrders (string shippingLabel, string packingLabel, double total){
        Console.WriteLine ("---Begin Customer Order---");
        Console.WriteLine ();
        Console.WriteLine ("Shipping Label");
        Console.WriteLine ();
        Console.WriteLine (shippingLabel);
        Console.WriteLine ();
        Console.WriteLine ("Packing Label");
        Console.WriteLine ();
        Console.WriteLine (packingLabel);
        Console.WriteLine ();
        Console.WriteLine ($"Shipping: {_shippingCost}");
        Console.WriteLine ();
        Console.WriteLine ($"Grand Total: ${Math.Round(_shippingCost + total,2)}");
        Console.WriteLine ();
        Console.WriteLine ("---End Customer Order ---");
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