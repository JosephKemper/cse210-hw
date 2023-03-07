using System;

class Program
{
    static void Main(string[] args)
    {
        int _userChoice = 0;

        while (_userChoice != 6)
        {
        Menu runMenu = new Menu ();
        _userChoice = runMenu.GetUserChoice();
        }
    }
}