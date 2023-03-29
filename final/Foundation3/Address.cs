using System;
/*
Purpose
Format addresses for events
Inputs
Strings containing event addresses
Outputs
Properly formatted event address
*/
public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zip;

    public void LoadAddress(string unformattedAddress){
        string [] parts = unformattedAddress.Split(",");
        _streetAddress = parts [0];
        _city = parts [1];
        _state = parts [2];
        _zip = parts [3];
        }
    
    public void DisplayAddress(){
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}, {_state} {_zip}");
        }

    
    public Address (){
    }

    public Address (string unformattedAddress){
        LoadAddress (unformattedAddress);
        }
    }