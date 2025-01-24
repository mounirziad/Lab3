using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge3 : MonoBehaviour
{
    public int useramount; //User input amount in which they will be paid 

    private int amtofhundreds; //amount of hundreds user will be paid 

    private int amtoffiftys; //amount of fiftys user will be paid 

    private int amtoftwents; //amount of twentys user will be paid

    private int amtoftens; //amount of tens user will be paid 

    private int amtoffifves; //amount of fives user will be paid

    private int amtofones; //amount of ones user will be paid

    //defining variables. useramount will be the amount the user has to pay. amtofhundreds, etc. is the amount of bills


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
            //if the useramount has a remainder after being divided by that remainder. set the remainder equal to the useramount and calculate the number of hundred dollar bills and save this into amtofhundreds
            //if there isn't a remainder. set the useramount = 0 to avoid wrong calculations. calculate the number of hundred dollar bills and save this into amtofhundreds
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
          //if the useramount has a remainder after being divided by that remainder. set the remainder equal to the useramount and calculate the number of fifty dollar bills and save this into amtoffiftys
          //if there isn't a remainder. set the useramount = 0 to avoid wrong calculations. calculate the number of hundred dollar bills and save this into amtoffiftys
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
          //if the useramount has a remainder after being divided by that remainder. set the remainder equal to the useramount and calculate the number of twenty dollar bills and save this into amtoftwentys
          //if there isn't a remainder. set the useramount = 0 to avoid wrong calculations. calculate the number of hundred dollar bills and save this into amtoftwentys
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
           //if the useramount has a remainder after being divided by that remainder. set the remainder equal to the useramount and calculate the number of tens dollar bills and save this into amtoftens
           //if there isn't a remainder. set the useramount = 0 to avoid wrong calculations. calculate the number of hundred dollar bills and save this into amtoftens
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
            //if the useramount has a remainder after being divided by that remainder. set the remainder equal to the useramount and calculate the number of five dollar bills and save this into amtoffives
            //if there isn't a remainder. set the useramount = 0 to avoid wrong calculations. calculate the number of hundred dollar bills and save this into amtoffives
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
           //if the useramount has a remainder after being divided by that remainder. set the remainder equal to the useramount and calculate the number of one dollar bills and save this into amtofones
           //if there isn't a remainder. set the useramount = 0 to avoid wrong calculations. calculate the number of hundred dollar bills and save this into amtofones

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

        //display to console 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
