using System;

public class Product {
    private double _productPrice;
    private int _quantity;
    private string _productID;
    private double _subtotal;
    private string _productFileName = "ProductPriceList.txt";
    private Dictionary<string, double> _productDictionary = new Dictionary<string, double>();

    public void LoadProducts (){
        foreach (string line in File.ReadLines(_productFileName)){
            string [] parts = line.Split("|");

            _productID = parts[0];
            _productPrice = double.Parse(parts[1]);

            _productDictionary.Add(_productID,_productPrice);
            }
        }

    public void ProcessRawOrder (string rawOrder){
        string [] parts = rawOrder.Split(",");
        _productID = parts [0];
        _quantity = int.Parse(parts [1]);
        }
    public double FindPrice (string productID){
        _productPrice = _productDictionary [productID];
        return _productPrice;
        }
    
    public void CalculateSubtotal(double productPrice, int quantity){
        _subtotal = productPrice * quantity;
        }
    public double GetSubtotal(){
        return _subtotal;
        }
    
    public Product(){
        LoadProducts();
        }

    public Product (string productID, int quantity){
        LoadProducts();
        _productPrice = FindPrice(productID);
        CalculateSubtotal (_productPrice, quantity);
        }
    }
