using System;

public class Product {
    private double _productPrice;
    private int _quantity;
    private string _productID;

    public double FindPrice (string productID){
        return _productPrice;
        }
    
    public double CalculateSubtotal(double productPrice, int quantity){
        return productPrice * quantity;
        }
    
    public Product(){
        }

    public Product (string productID, double productPrice, int quantity){
        }
    }
