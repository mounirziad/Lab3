using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge3 : MonoBehaviour
{
    public int useramount;

    private int amtofhundreds;

    private int amtoffiftys;

    private int amtoftwents;

    private int amtoftens;

    private int amtoffifves;

    private int amtofones;




    // Start is called before the first frame update
    void Start()
    {
       

            if (useramount % 100 != 0)
            {
                amtofhundreds = useramount / 100;
                useramount %= 100;
            }
            else if (useramount % 100 == 0){
                amtofhundreds = useramount / 100;
                useramount = 0;
                
            }

            if (useramount % 50 != 0)
            {
                amtoffiftys = useramount / 50;
                useramount %= 50;
                
            }
            else if (useramount % 50 == 0)
            {
                amtoffiftys = useramount / 50;
                useramount = 0;
            }

            if (useramount % 20 != 0)
            {
                amtoftwents = useramount / 20;
                useramount %= 20;
                
            }
            else if (useramount % 20 == 0)
            {
                amtoftwents = useramount / 20;
                useramount = 0;
            }

            if (useramount % 10 != 0)
            {
                amtoftens = useramount / 10;
                useramount %= 10;
                
            }
            else if (useramount % 10 == 0)
            {
                amtoftens = useramount / 10;
                useramount = 0;
            }

            if (useramount % 5 != 0)
            {
                amtoffifves = useramount / 5;
                useramount %= 5;
                
            }
            else if (useramount % 5 == 0)
            {
                amtoffifves = useramount / 5;
                useramount = 0;
            }
            if (useramount % 1 != 0)
            {
                amtofones = useramount / 1;
                useramount %= 1;
                
            }
            else if (useramount % 1 == 0)
            {
                amtofones = useramount / 1;
                useramount = 0;
            }

        Debug.Log("The amount of hundreds is: ");
        Debug.Log(amtofhundreds);
        Debug.Log("The amount of fiftys is: ");
        Debug.Log(amtoffiftys);
        Debug.Log("The amonut of twenties is: ");
        Debug.Log(amtoftwents);
        Debug.Log("The amount of tens is: ");
        Debug.Log(amtoftens);
        Debug.Log("The amount of fives is: ");
        Debug.Log(amtoffifves);
        Debug.Log("The amount of ones is: ");
        Debug.Log(amtofones);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
