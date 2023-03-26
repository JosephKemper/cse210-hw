using System;

public class Customer{
    private string _customerName;
    private string _unformattedAddress;
    private string _customerAddress;
    private bool _isUSA;
    private string _shippingLabel;

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
    
    public void AssembleShippingLabel(){
        _shippingLabel = _customerName + "\n" + _customerAddress;
        }
    public bool GetIsUSA(){
    return _isUSA;
    }
    public string GetShippingLabel(){
        return _shippingLabel;
        }
    public string ReturnCustomerName(){
        return _customerName;
        }
    public string ReturnAddress(){
        return _customerAddress;
        }
    public Customer (){
        }

    }