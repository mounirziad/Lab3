using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Challenge2 : MonoBehaviour
{



    public float priceofbook; //define price of book to be input by user

    private float discount = (1 - 0.40f); //define discount to be used in rev and profit calculation

    public float amountofbookssold; //define amountofbookssold to be input by user

    public float amountofbooksbought; //define amount of booksbought to be input by user. 

    private float discountedpriceofbook; //define discounted priceofbook for profit calculation

    private float wholesalecost; //define wholesalecost for profit calculation

    private float revenue; //define revenue for profit calculation

    private float profit; //define profit. 

    //defining variables for profit calculation.
    


    // Start is called before the first frame update
    void Start()
    {

        float discountedpriceofbook = (priceofbook * discount); //calculates the price of one book bought by the bookstore

        float wholesalecost = (discountedpriceofbook + 0.75f) * (amountofbooksbought - 1) + (discountedpriceofbook + 3); 
        //calculates the wholesale cost or the cost to buy books. (discountedpriceofbook+3) is the price of the first book bought and (discountedpriceofbook+0.75f)*(amountofbooksbought-1) is the price of all subsequent books bought

        float revenue = priceofbook * amountofbookssold;
        //revenue is calculated by the retail cost of a book multiplied by the number of books sold 

        float profit = revenue - wholesalecost; 
        //calculated by substracting the cost of goods from the revenue made 
        Debug.Log("The wholesalecost is ");
        Debug.Log(wholesalecost);
        Debug.Log("The Profit is ");
        Debug.Log(profit);
        //print to console
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

