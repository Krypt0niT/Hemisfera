using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furnace : MonoBehaviour
{
    GameObject managerGameObject;
    manager managerVariables;
    Controls controls;

    [SerializeField] Sprite iron;
    [SerializeField] Sprite gold;
    [SerializeField] GameObject frame;

    [SerializeField] GameObject light;

    float cookTick = 0;

    int oreCapacity = 10;
    int coalCapacity = 10;
    int oreInstantCapacity = 0;
    int coalInstantCapacity = 0;
    string oreSelected = "Gold";
    bool on = false;
    bool navybratie = false;
    void Start()
    {
        managerGameObject = GameObject.Find("Manager");
        controls = managerGameObject.GetComponent<Controls>();
        managerVariables = managerGameObject.GetComponent<manager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (!on)
            {
                if (!navybratie)
                {
                    if (oreSelected == "Gold")
                    {
                        oreSelected = "Iron";
                        frame.GetComponent<SpriteRenderer>().sprite = iron;
                    }
                    else
                    {
                        oreSelected = "Gold";
                        frame.GetComponent<SpriteRenderer>().sprite = gold;

                    }
                }
                
            }
            
        }
        if (on)
        {
            cookTick += Time.deltaTime;
            if(cookTick > oreInstantCapacity * 2)
            {
                cookTick = 0;
                on = false;
                navybratie = true;
            }

            light.SetActive(true);
        }
        else
        {
            light.SetActive(false);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (controls.PlayerUse)
        {
            if (!on)
            {
                if (!navybratie)
                {
                    if (oreSelected == "Iron")
                    {
                        if (managerVariables.PlayerStats.Materials[2] >= 10)
                        {
                            if (managerVariables.PlayerStats.Materials[0] >= 10)
                            {
                                managerVariables.PlayerStats.Materials[2] -= 10;
                                managerVariables.PlayerStats.Materials[0] -= 10;

                                oreInstantCapacity += 10;
                                on = true;
                            }
                            

                        }
                        else
                        {
                            oreInstantCapacity += managerVariables.PlayerStats.Materials[2];
                            managerVariables.PlayerStats.Materials[2] = 0;
                            on = true;

                        }

                    }
                    if (oreSelected == "Gold")
                    {
                        if (managerVariables.PlayerStats.Materials[3] >= 10)
                        {
                            if (managerVariables.PlayerStats.Materials[0] >= 10)
                            {
                                managerVariables.PlayerStats.Materials[3] -= 10;
                                managerVariables.PlayerStats.Materials[0] -= 10;

                                oreInstantCapacity += 10;
                                on = true;
                            }
                                

                        }
                        else
                        {
                            oreInstantCapacity += managerVariables.PlayerStats.Materials[3];
                            managerVariables.PlayerStats.Materials[3] = 0;
                            on = true;

                        }

                    }
                }
                
            }
            
        }
        if (Input.GetKey(KeyCode.F))
        {
            if (navybratie)
            {
                if (oreSelected == "Iron")
                {
                    managerVariables.PlayerStats.Materials[6] += oreInstantCapacity;
                    oreInstantCapacity = 0;
                    navybratie = false;
                }
                if (oreSelected == "Gold")
                {
                    managerVariables.PlayerStats.Materials[7] += oreInstantCapacity;
                    oreInstantCapacity = 0;
                    navybratie = false;

                }
            }
        }
    }
}
