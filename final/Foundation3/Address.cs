using System;

public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zip;

    public void LoadAddress(){
        }
    
    public void DisplayAddress(){
        }

    public void ProcessAddressInfo(string unformattedAddress){
        string [] parts = unformattedAddress.Split(",");
        _streetAddress = parts [0];
        _city = parts [1];
        _state = parts [2];
        _zip = parts [3];
        }
    
    
    public string ReturnFormattedAddress(){
            return _streetAddress + "\n" + _city + "," + _state + _zip;
        }
    
    public Address (){
    }

    public Address (string unformattedAddress){
        ProcessAddressInfo (unformattedAddress);
        }
    }