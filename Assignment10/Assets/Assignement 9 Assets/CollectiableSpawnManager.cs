/*
		 * (Santiago Garcia II)
		 * (CollectiableSpawnManager.cs)
		 * (Assignment10 )
		 * (creates a list that spawns objects )
	*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiableSpawnManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> collectiables = new List<GameObject>();
    List<GameObject> multicolorcollectiables = new List<GameObject>();
    public int arrayCounter;

    private GameObject playerObj;
    private Transform playerTransform;
    public float spawnDistance = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject itemstopaint = multicolorcollectiables[Random.Range(0, multicolorcollectiables.Count)];
           
            Instantiate(itemstopaint);
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
          
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            
            float xRand = Random.Range(-10, 10);
            float zRand = Random.Range(-10, 10);
            Vector3 spawnPos = playerTransform.position + playerTransform.forward * spawnDistance + new Vector3(xRand, 0, zRand);
            multicolorcollectiables.Remove(multicolorcollectiables[Random.Range(0, multicolorcollectiables.Count)]);
        }
    }
}
