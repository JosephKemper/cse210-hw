Program Purpose
produce packing labels, shipping labels, and compute final prices for billing.

Program Inputs 
Raw list of customer orders with a variety of order sizes and number of items ordered. The list will include standard customer info like name and address. 

Program Outputs
Properly formatted packing and shipping labels with proper pricing info displayed on each. 

<Code>
Class Info
Order
    Class Purpose
        Generate packing and shipping labels with proper pricing and address info on them. 
    Inputs
        Raw list of customer and order info. 
    Outputs
        Packing List with quantity, product name, and product id for each product ordered
        Shipping Label with name and address of customer with proper newline marks included
    Outline
        Methods
            LoadOrders (filename)
            PrepOrders (_unfilteredOrders)
            DisplayOrders (_ordersList)
            Order(filename)
        Member variables
            _rawOrders : string
            _ordersList : List < string>
</Code>
<Code>
Product
    Class Purpose
        Calculate the total price of the products orders
    Inputs
        Product id and quantity
    Outputs
        Total Product Price
    Outline
        Methods
            FindPrice (productID : String) : Double
            CalculateTotal (_productPrice Double, _quantity : Int) : Double
            Product (productID : String, _productPrice : Double, _quantity : Int)
        Member variables
            _productPrice : double
            _quantity : Int
            _productID : String
</Code>
<Code>
Customer
    Class Purpose
        Used by Order to format the customer information and determine what the shipping costs should be. 
    Inputs
        String containing customer name and address marked with separators
    Outputs
        Customer name, address and shipping costs. 
    Outline
        Methods
            ProcessCustomerInfo (_unformattedCustomerInfo:String) // Splits the unformatted customer string into customer name and address parts and attaches to variables.
            FormatAddress (unformattedAddress:String) // Uses Address Class to format address
            ReturnCustomerName() String
            ReturnAddress()Address
            Customer(_unformattedCustomerInfo:String)
        Member variables
            _customerName : String
            _unformattedAddress : String
            _customerAddress : Address 
</Code>
<Code>
Address
    Class Purpose
        Used by Customer class to format the address properly, and check if the customer is in the United States for use in calculating shipping costs
    Inputs
        String containing the customer address with separator marks dividing data. 
    Outputs
        Properly formatted address info including country of origin.
    Outline
        Methods
            ProcessAddressInfo(string unformattedAddress) // Attaches parts of address to variables
            CheckCountry () : Bool _isUSA
            ReturnFormattedAddress () : String _formattedAddress 
            Address ()
            Address (string unformattedAddress)
        Member Variables
            _streetAddress : String
            _city : String
            _state : String
            _zip : String
            _country : String
</Code>

UML URL //www.plantuml.com/plantuml/dpng/XLFHZjCm47ptL_WnuSWFL0ZTaUgaIYUeA3n79jw2XMC7UorKKF-TJModSKjrJztCpCxkZjL7Zy9X63HhWqSxWEDlceO_IUd0U_R9oOHaUWNjdPMXHyPQBRpdaVZB7bwiaFE7vzLHQJ1YW9ezx1sC6Uw28GR1GL8IlrL-rEAqIEnSl2YFHCxeogtfdFYTf1lkqIdpdS1B3w7ppxj4lcVdj6UwZHQTBkYfJCZE76qLrJnGxGQ123AnDQU6zWVqFriR3BeJhseQyi5QpJlblnwUYFyC69nvlcgDoaDqxgwD9z-BSFrnVnVMy8vO04p8uZynlS9J0NWK20NoHurbIxffmSxvMVF3h_BAq1HOVCkytvhPHASvjvZ8SjZjHIjn2Z5RVHG3K7wHNzZKLjMf828tlBhGVE_AlGZYThM2pdqNBbTBOlb_CGNsh8pSEzK3hyQ8xhQBNqtLrePl6gRjXUw35WXVB0fDgIPzx8wojxpx5OJ1-BmxWuL36lk_ITHOs6tk6hBcHYhZWEPQcwNbA8hX4OmCW_u7