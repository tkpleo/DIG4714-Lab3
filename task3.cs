using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillCalculator : MonoBehaviour
{
    // Amount that must be paid.
    public int amountPaid;

    void Start()
    {
        // Makes sure there are no decimals or negative numbers since its $
        if (amountPaid < 0)
        {
            Debug.LogError("Error: Money cannot have a negative value.");
            return;
        }

        // Calculate Bills
        Calculation(amountPaid);
    }

    void Calculation(int amount)
    {
        // Define bill denominations
        int[] bills = { 100, 50, 20, 10, 5, 1 };
        string output = $"Amount to be paid: ${amount}\n";

        // Implementing function that I learned. 
        foreach (int bill in bills)
        {
            int count = amount / bill; 
            if (count > 0)
            {
                output += $"{count} x ${bill} bills\n";
            }
            amount %= bill; 
        }
        // Allows results to be output onto console.
        Debug.Log(output);
    }
}
