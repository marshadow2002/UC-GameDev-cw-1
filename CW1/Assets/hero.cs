using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    string heroname = "tanks";
    float herohight = 6.3f;
    int heroAge = 28;
    string heroSuperPower = "big cannons";

    string villainName = "knats";
    float vililanHeight = 6.3f;
    int villainAge = 33;
    string villainSuperPower = " high speed";

    // Start is called before the first frame update
    void Start()
    {
        int age_diffrence = villainAge - heroAge;

       
        print("we are the heroes our name is " + heroname + " our age is " + heroAge + " our hight is " + herohight + " our secret weapon is " + heroSuperPower);
        print("we are the heroes our name is " + villainName + " our age is " + villainAge + " we are older than you by " + age_diffrence  + " our hight is " + vililanHeight + "our secret weapon is " + villainSuperPower);
        villainSuperPower = "none";
        herohight = herohight + 5;
        print("we are the heroes our name is " + heroname + " our age is " + heroAge + " our hight is " + herohight + " our secret weapon is " + heroSuperPower);
        print("we are the heroes our name is " + villainName + " our age is " + villainAge + " we are older than you by " + age_diffrence + " our hight is " + vililanHeight + "our secret weapon is " + villainSuperPower);
    }

    // Update is called once per frame
    void Update()
    {
        
            


    }
}
