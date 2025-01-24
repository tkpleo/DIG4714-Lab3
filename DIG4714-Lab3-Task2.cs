using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookProfit : MonoBehaviour
{
    //establish price, copies sold, and cost/profit variables to store quantities in later
    public float bookPrice = 0.0f;
    public int copiesSold = 0;
    private float wholesaleCost = 0.0f;
    private float totalProfit = 0.0f;

    void Start()
    {
        profitCalc(copiesSold, bookPrice);
    }
    void profitCalc(int copies, float cost)
    {
        //convert copiesSold to float to simplify calculations
        float copiesFloat = (float)copiesSold;

        //calculate wholesaleCost and totalProfit
        wholesaleCost = ((bookPrice * 0.6f) * copiesFloat) + (3.0f + (.75f * (copiesFloat - 1.0f)));
        totalProfit = (bookPrice * copiesFloat) - wholesaleCost;
        //create debug that prints a string with the final values adjusted to two decimal points
        string costString = wholesaleCost.ToString("#.##");
        string profitString = totalProfit.ToString("#.##");
        Debug.LogFormat("Cost: " + costString + " " + "Profit: " + profitString);

    }
}