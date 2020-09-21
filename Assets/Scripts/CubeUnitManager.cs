﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUnitManager : MonoBehaviour
{

    
    // Declare Public Variables
    public GameObject item;
    public GameObject Block_Parent;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;

    // Keep track of the colliders
    private GameObject spawnedItem1;
    private GameObject spawnedItem2;
    private GameObject spawnedItem3;




    void Start()
    {
        //Spawn the blocks in their proper places when the scene starts
        Spawn_Blocks();
        
    }

    private int interval = 100;


    private void Update()
    {
        if (Time.frameCount % interval == 0)
        {
            Check_Blocks();
        }

    }


    void Check_Blocks()
    {
        if (spawnedItem1.transform.position != spawnPoint1.position)
        {
            spawnedItem1.transform.position = spawnPoint1.position;

            //Destroy(spawnedItem1);

            //Debug.Log("Item 1 Destroyed!!!");

      
        }
        if (spawnedItem2.transform.position != spawnPoint2.position)
        {
            spawnedItem2.transform.position = spawnPoint2.position;

            //Destroy(spawnedItem2);

            //Debug.Log("Item 2 Destroyed!!!");

        }
        if (spawnedItem3.transform.position != spawnPoint3.position)
        {
            spawnedItem3.transform.position = spawnPoint3.position;

            //Destroy(spawnedItem3);

            //Debug.Log("Item 3 Destroyed!!!");

        }
    }







    public void Spawn_Blocks()
    {
        spawnedItem1 = Instantiate(item, spawnPoint1.position, spawnPoint1.rotation);
        //spawnedItem1.transform.parent = this.transform;
        spawnedItem1.GetComponent<HingeJoint>().connectedBody = Block_Parent.GetComponent<Rigidbody>();

        spawnedItem2 = Instantiate(item, spawnPoint2.position, spawnPoint2.rotation);
        //spawnedItem2.transform.parent = this.transform;
        spawnedItem2.GetComponent<HingeJoint>().connectedBody = Block_Parent.GetComponent<Rigidbody>();


        spawnedItem3 = Instantiate(item, spawnPoint3.position, spawnPoint3.rotation);
        //spawnedItem3.transform.parent = this.transform;
        spawnedItem3.GetComponent<HingeJoint>().connectedBody = Block_Parent.GetComponent<Rigidbody>();

        
    }








    //private void OnTriggerEnter(Collider other)
    //{
    //    if (!colliders.Contains(other)) { colliders.Add(other); }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    colliders.Remove(other);
    //    if (other.gameObject.tag == "block")
    //    {
    //        Regenerate_blocks();
    //    }
    //}






}
