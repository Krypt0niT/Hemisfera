using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject managerObject;
    Controls controls;
    CharacterController chc;
    manager managerVariables;
    GameObject WeaponsHint;
    SpriteRenderer PlayerRend;
    CameraFollow CF;

    int playerRotation = 0;
    string animState = "idle";
    public bool usingWeapons = false;

    [SerializeField] List<Sprite> Beh = new List<Sprite>();
    float behTick = 0;
    float behSpeed = 7;
    int behIndex = 0;

    [SerializeField] List<Sprite> Idle = new List<Sprite>();
    float idleTick = 0;
    float idleSpeed = 5;
    int idleIndex = 0;




    float moveX = 0;
    void Start()
    {
        managerObject = GameObject.Find("Manager");
        controls = managerObject.GetComponent<Controls>();
        managerVariables = managerObject.GetComponent<manager>();
        chc = this.gameObject.GetComponent<CharacterController>();
        PlayerRend = this.gameObject.GetComponent<SpriteRenderer>();
        WeaponsHint = GameObject.Find("WeaponsHint");
        CF = GameObject.Find("Main Camera").GetComponent<CameraFollow>();
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
        if (animState == "idle")
        {
            idleTick += Time.deltaTime;
            if (idleTick >= 1 / idleSpeed)
            {
                PlayerRend.sprite = Idle[idleIndex];
                idleTick = 0;
                if (idleIndex < Idle.Count - 1)
                {
                    idleIndex++;
                }
                else
                {
                    idleIndex = 0;
                }

            }
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "WeaponControlPanel")
        {
            WeaponsHint.GetComponent<TextMeshPro>().enabled = true;
            
            if (Input.GetKeyDown(controls.PlayerUse))
            {
                if (!usingWeapons)
                    usingWeapons = true;
                else
                    usingWeapons = false;

            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "WeaponControlPanel")
        {
            WeaponsHint.GetComponent<TextMeshPro>().enabled = false;
            usingWeapons = false;
        }
    }
}
