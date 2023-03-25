using System;

public class Customer{
    private string _customerName;
    private string _unformattedAddress;
    private Address _customerAddress;

    public void ProcessCustomerInfo (string customerName, string unformattedAddress){
        _customerName = customerName;
        _unformattedAddress = unformattedAddress;
        }
    
    public void FormatAddress (string unformattedAddress){
        }
    
    public string ReturnCustomerName(){
        return _customerName;
        }
    public Address ReturnAddress(){
        return _customerAddress;
        }
    
    public Customer (){
        }

    }