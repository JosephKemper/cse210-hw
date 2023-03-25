using System;

public class Product {
    private double _productPrice;
    private int _quantity;
    private string _productID;
    private double _subtotal;
    private double _total;
    private string _productFileName = "ProductPriceList.txt";
    private List<string> _productRequestList = new List<string>();
    private Dictionary<string, double> _productDictionary = new Dictionary<string, double>();

    public void LoadProducts (){
        foreach (string line in File.ReadLines(_productFileName)){
            string [] parts = line.Split("|");

            _productID = parts[0];
            _productPrice = double.Parse(parts[1]);

            _productDictionary.Add(_productID,_productPrice);
            }
        }
    // TODO #23 Bug Product not splitting correctly
    public void ProcessRawOrder (string rawOrder){
        _productRequestList.Clear();
        _productRequestList = rawOrder.Split("||").ToList();
        _total = 0;
        
        foreach (string product in _productRequestList){
            string [] parts = product.Split(",");
            CalculateSubtotal (FindPrice (parts [0]), int.Parse(parts [1]));
            _total += _subtotal;
            }
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
