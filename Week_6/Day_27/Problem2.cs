using System;

// Interface
public interface IDiscountStrategy
{
    double CalculateDiscount(double amount);
}

// Implementations
public class RegularCustomerDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double amount) => amount * 0.05;
}

public class PremiumCustomerDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double amount) => amount * 0.10;
}

public class VipCustomerDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double amount) => amount * 0.20;
}

// Calculator
public class DiscountCalculator
{
    public double GetFinalAmount(double amount, IDiscountStrategy strategy)
    {
        return amount - strategy.CalculateDiscount(amount);
    }
}