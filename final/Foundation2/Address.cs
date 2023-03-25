using System;

public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zip;
    private string _country;

    public void ProcessAddressInfo(string unformattedAddress){
        string [] parts = unformattedAddress.Split(",");
        _streetAddress = parts [0];
        _city = parts [1];
        _state = parts [2];
        _zip = parts [3];
        _country = parts [4];
        }
    
    public string GetCountry (){
        return _country;
        }
    
    public string ReturnFormattedAddress(){
            if (_country == "USA"){
                return _streetAddress + "\n" + _city + "," + _state + _zip;
                }
            else {
                return _streetAddress + "\n" + _city + "," + _state + _zip + "\n" + _country;
                }
        }
    
    public Address (){
    }

    public Address (string unformattedAddress){
        ProcessAddressInfo (unformattedAddress);
        }
    }