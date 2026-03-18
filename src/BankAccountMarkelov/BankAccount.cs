using System;

namespace BankAccountMarkelov;

public class BankAccount
{
    private readonly string m_customerName;
    private double m_balance;

    public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
    public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";
    public const string CreditAmountLessThanZeroMessage = "Credit amount is less than zero";

    public BankAccount(string customerName, double balance)
    {
        if (string.IsNullOrWhiteSpace(customerName))
        {
            throw new ArgumentException("Customer name cannot be empty.", nameof(customerName));
        }

        m_customerName = customerName;
        m_balance = balance;
    }

    public string CustomerName => m_customerName;

    public double Balance => m_balance;

    public void Debit(double amount)
    {
        if (amount > m_balance)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                amount,
                DebitAmountExceedsBalanceMessage);
        }

        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                amount,
                DebitAmountLessThanZeroMessage);
        }

        m_balance -= amount;
    }

    public void Credit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                amount,
                CreditAmountLessThanZeroMessage);
        }

        m_balance += amount;
    }
}
