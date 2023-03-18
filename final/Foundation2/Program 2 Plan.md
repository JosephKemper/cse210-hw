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
        Packing List with quantity, name, and product id for each product ordered
        Shipping Label with name and address of customer with proper newline marks included
</Code>
<Code>
Product
    Class Purpose
        Calculate the total price of the products orders
    Inputs
        Product id and quantity
    Outputs
        Total Product Price
</Code>
<Code>
Customer
    Class Purpose
        Used by Order to format the customer information and determine what the shipping costs should be. 
    Inputs
        String containing customer name and address marked with separators
    Outputs
        Customer name, address and shipping costs. 
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
            Address (unformattedAddress)

        Member Variables
            _streetAddress : String
            _city : String
            _state : String
            _zip : String
            _country : String
</Code>
