using System;

public class Product {
    private double _productPrice;
    private int _quantity;
    private string _productID;
    private double _subtotal;
    private double _total;
    private string _packingLabel;
    private string _productFileName = "ProductPriceList.txt";
    private List<string> _productRequestList = new List<string>();
    private List <string> _packingLabelList = new List<string>();
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
        _productRequestList.Clear();
        _total = 0;
        _productRequestList = rawOrder.Split("||").ToList();
        
        foreach (string product in _productRequestList){
            string [] parts = product.Split(",");
            CalculateSubtotal (FindPrice (parts [0]), int.Parse(parts [1]));
            _total += _subtotal;
            CollectShippingLabelParts (parts[0],int.Parse(parts [1]),_subtotal);
            }
        }
    public void CollectShippingLabelParts (string productID, int quantity, double subtotal){
        _packingLabelList.Add($"Product ID {productID} -- Quantity {quantity} @ ${FindPrice(productID)} each, Subtotal ${Math.Round(subtotal,2)}");
        }
    // Learned method to combine list to array from Bing AI
    public void AssemblePackingLabel(){
        _packingLabel = String.Join("\n", _packingLabelList.ToArray());
        }
    public string GetPackingLabel(){
        return _packingLabel;
        }

    public double FindPrice (string productID){
        _productPrice = _productDictionary [productID];
        return _productPrice;
        }
    
    public void CalculateSubtotal(double productPrice, int quantity){
        _subtotal = productPrice * quantity;
        }
    public double GetTotal(){
        return _total;
        }
    
    public Product(){
        LoadProducts();
        }

    public Product (string rawOrder){
        LoadProducts();
        ProcessRawOrder(rawOrder);
        }
    }
