using System;

class Order{
    // Names and addresses found in CustomerOrders.txt were made up by Bing's AI
    private string _customerOrders = "CustomerOrders.txt";
    private string _rawOrders;
    private List<string> _ordersList = new List<string>();

    public void LoadOrders (){
        foreach (string line in File.ReadLines(_customerOrders)){
            _ordersList.Add(line);
            }
        }
    
    public void PrepOrders(string rawOrders){
        }
    
    public void DisplayOrders (List<string>ordersList){
        }
    public Order (){
    }
    public Order(string filename){
        }
    }