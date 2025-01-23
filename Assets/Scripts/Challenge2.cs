using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Challenge2 : MonoBehaviour
{



    public float priceofbook;

    private float discount = (1 - 0.40f);

    public float amountofbookssold;

    public float amountofbooksbought;

    private float discountedpriceofbook;

    private float wholesalecost;

    private float revenue;

    private float profit;


    // Start is called before the first frame update
    void Start()
    {

        float discountedpriceofbook = (priceofbook * discount);

        float wholesalecost = (discountedpriceofbook + 0.75f) * (amountofbooksbought - 1) + (discountedpriceofbook + 3);

        float revenue = priceofbook * amountofbookssold;

        float profit = revenue - wholesalecost;
        Debug.Log("The wholesalecost is ");
        Debug.Log(wholesalecost);
        Debug.Log("The Profit is ");
        Debug.Log(profit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

