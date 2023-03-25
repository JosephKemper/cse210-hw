using System;

public class Product {
    private double _productPrice;
    private int _quantity;
    private string _productID;
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
    public double FindPrice (string productID){
        _productPrice = _productDictionary [productID];
        return _productPrice;
        }
    
    public double CalculateSubtotal(double productPrice, int quantity){
        return productPrice * quantity;
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
