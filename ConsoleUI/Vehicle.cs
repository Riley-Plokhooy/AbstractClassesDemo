using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    /*
     * Create an abstract class called Vehicle
     * The vehicle class shall have three string properties: Year, Make, and Model
     * Set the defaults of the properties to something generic in the Vehicle class
     * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
     * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
     */

    public string Year { get; set; } = "2020";
    public string Make { get; set; } = "Generic Make";
    public string Model { get; set; } = "Generic Model";
    
    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Vehicle is driving virtual.");
    }
}