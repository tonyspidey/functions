using System;
class ATM
{
    private int _pin;
    public int PIN
    {
        set { _pin = value; }
    }
    public bool ValidatePIN(int inputPin)
    {
        return inputPin == _pin;
    }
}
class PIN_pgm
{
    static void Main()
    {
        ATM atm = new ATM();
        atm.PIN = 1234;

        Console.WriteLine(atm.ValidatePIN(1234));
        Console.WriteLine(atm.ValidatePIN(1111));
    }
}