using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject managerObject;
    Controls controls;
    CharacterController chc;
    manager managerVariables;

    SpriteRenderer PlayerRend;

    int playerRotation = 0;
    string animState = "idle";


    [SerializeField] List<Sprite> Beh = new List<Sprite>();
    float behTick = 0;
    float behSpeed = 7;
    int behIndex = 0;
    float moveX = 0;
    void Start()
    {
        managerObject = GameObject.Find("Manager");
        controls = managerObject.GetComponent<Controls>();
        managerVariables = managerObject.GetComponent<manager>();
        chc = this.gameObject.GetComponent<CharacterController>();
        PlayerRend = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(controls.PlayerLeft))
        {
            moveX = -1;
            playerRotation = 180;
            animState = "running";
        }
            
        else if (Input.GetKey(controls.PlayerRight))
        {
            moveX = 1;
            playerRotation = 0;
            animState = "running";

        }

        else
        {
            moveX = 0;
            animState = "idle";

        }

        chc.Move(new Vector3(moveX,0,0) * Time.deltaTime * managerVariables.PlayerStats.speed);
        transform.rotation = Quaternion.Euler(0, playerRotation,0);



        //animacie
        if (animState == "running")
        {
            behTick += Time.deltaTime;
            if (behTick >= 1 / behSpeed)
            {
                PlayerRend.sprite = Beh[behIndex];
                behTick = 0;
                if (behIndex < Beh.Count - 1)
                {
                    behIndex++;
                }
                else
                {
                    behIndex = 0;
                }

            }
        }
        
    }
}
