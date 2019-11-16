
/*
		 * (Santiago Garcia II)
		 * (EnemyDatabase.cs)
		 * (Assignment10 )
		 * (creates a custom class for Enemydatabase)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDatabase : MonoBehaviour
{
    //this creates a dictionary 
    public Dictionary<string, int> eniemes = new Dictionary<string,int>();
    //create a dictionary of superhero objects with string keys
    public Dictionary<string, Enemy> villians = new Dictionary<string, Enemy>();



    void Start()
    {
        //add a Enemy to the dictionary with the default constructor
        eniemes.Add("Enemy1", 1);


        //add a superhero with the overloaded constructor directly
        eniemes.Add("Enemey 2 ", 2);
        eniemes.Add("Enemey 3 ", 3);
        if (eniemes.ContainsKey("enemy2son"))
        {
            Debug.LogFormat("Yes, it is {0} that our dictionary contains the key enemy2son",
               eniemes.ContainsKey(" enemy2son"));
        }
        foreach (KeyValuePair<string, Enemy> villian in villians)
        {
            Debug.LogFormat("{0} : {1}",
                villian.Key,
                villian.Value.name);
            

        }
        // Clear a dictionary
        eniemes.Clear();
    }


}
