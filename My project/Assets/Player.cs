using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject managerObject;
    Controls controls;
    CharacterController chc;
    manager managerVariables;

    float moveX = 0;
    void Start()
    {
        managerObject = GameObject.Find("Manager");
        controls = managerObject.GetComponent<Controls>();
        managerVariables = managerObject.GetComponent<manager>();
        chc = this.gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(controls.PlayerLeft))
            moveX = -1;
        else if (Input.GetKey(controls.PlayerRight))
            moveX = 1;
        else
            moveX = 0;

        chc.Move(new Vector3(moveX,0,0) * Time.deltaTime * managerVariables.PlayerStats.speed);


    }
}
