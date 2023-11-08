using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";

    int carWeight = 1609;
    int yearMade = 2009;

    float maxAcceleration = 0.98f;

    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;


    void Start()
    {
        print("The racer model is " + carModel + ". It has a " + engineType + " engine.");

        CheckWeight();

        if (yearMade <= 2009)
        {
            print("It was first introduced in " + yearMade);
            int carAge = CalculateAge(yearMade);
            print("That makes it " + carAge + " years old.");

        }
        else
        {
            print("The car was introduced in the 2010's.");
            print(carModel + " has a maximum acceleration of " + maxAcceleration);
        }

        print(CheckCharacteristics());
    }

    void Update()
    {

    }

    void CheckWeight()
    {
        if(carWeight < 1500)
        {
            print(carModel + " weights less than 1500 kg.");
        }
        else
        {
            print(carModel + " weights over 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        int year = 2023 - yearMade;
        return year;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            string sedanMessage = "The car type is a sedan.";
            return sedanMessage;
        }
        else if (hasFrontEngine)
        {
            string frontEngineMessage = "The car isn't a sedan, but has a front engine.";
            return frontEngineMessage;
        }
        else
        {
            return "The car is neither a sedan nor does it have a front engine.";
        }
    }
}
