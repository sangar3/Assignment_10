
/*
		 * (Santiago Garcia II)
		 * (Enemy.cs)
		 * (Assignment10 )
		 * (creates a class to create variables)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy 
{
    public string name { get; set; }
    public float speed { get; set; }
  
    public static int count { get; set; }

    public Enemy()  //constructor 
    {
        name = "enemy";
    }

    public Enemy(string name, float speed)  //overload constructor
    {
        this.name = name;
        this.speed = speed;
        count++;
    }
    public override string ToString()
    {
        return name + " runs at " + speed + " km per hour.";
    }
}
