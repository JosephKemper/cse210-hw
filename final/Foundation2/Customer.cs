using System;

public class Customer{
    private string _customerName;
    private string _unformattedAddress;
    private string _customerAddress;
    private bool _isUSA;

    public void ProcessCustomerInfo (string customerName, string unformattedAddress){
        _customerName = customerName;
        _unformattedAddress = unformattedAddress;
        FormatAddress (_unformattedAddress);
        }
    
    public void FormatAddress (string unformattedAddress){
        Address newAddress = new Address(unformattedAddress);
        _customerAddress = newAddress.ReturnFormattedAddress();
        CheckCountry (newAddress.GetCountry());
        }

        public void CheckCountry (string country){
        if (country == "USA"){
            _isUSA = true;
            }
        else{
            _isUSA = false;
            }
        }
    public bool GetIsUSA(){
    return _isUSA;
    }
    public string ReturnCustomerName(){
        return _customerName;
        }
    public void ReturnAddress(){
        Console.WriteLine (_customerAddress);
        }
    public Customer (){
        }

    }