using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Windows;

public class HoverOver : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public Shop shop;
    public string main;
    public string route;
    public int index;

    public Sprite[] Materials;
    manager managerVariables;

    private void Start()
    {
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();
    }



    public void OnPointerEnter(PointerEventData eventData)
    {
        print(main);
        print(route);
        print(index);
        if (main == "Player")
        {
            if (route == "Damage")
            {
                shop.Name.text = shop.playerShop.damageName[index];
                shop.Description.text = shop.playerShop.damageDescription[index];
                string[] inp = shop.playerShop.damageCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
            else if (route == "Speed")
            {
                shop.Name.text = shop.playerShop.speedName[index];
                shop.Description.text = shop.playerShop.speedDescription[index];
                string[] inp = shop.playerShop.speedCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
            else if (route == "Hardness")
            {
                shop.Name.text = shop.playerShop.hardnessName[index];
                shop.Description.text = shop.playerShop.hardnessDescription[index];
                string[] inp = shop.playerShop.hardnessCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
        }
        else if (main == "Base")
        {
            if (route == "Shield")
            {
                shop.Name.text = shop.playerShop.shieldName[index];
                shop.Description.text = shop.playerShop.shieldDescription[index];
                string[] inp = shop.playerShop.shieldCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
            else if (route == "Health")
            {
                shop.Name.text = shop.playerShop.healthName[index];
                shop.Description.text = shop.playerShop.healthDescription[index];
                string[] inp = shop.playerShop.healthCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
            else if (route == "Repair")
            {
                shop.Name.text = shop.playerShop.repairName[0];
                shop.Description.text = shop.playerShop.repairDescription[0];
                string[] inp = shop.playerShop.repairCost[0].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
        }
        else if (main == "MainWeapon")
        {
            if (route == "Damage")
            {
                shop.Name.text = shop.playerShop.MainDamageName[index];
                shop.Description.text = shop.playerShop.MainDamageDescription[index];
                string[] inp = shop.playerShop.MainDamageCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
            else if (route == "Speed")
            {
                shop.Name.text = shop.playerShop.MainSpeedName[index];
                shop.Description.text = shop.playerShop.MainSpeedDescription[index];
                string[] inp = shop.playerShop.MainSpeedCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
            else if (route == "Accuracy")
            {
                shop.Name.text = shop.playerShop.MainAccuracyName[0];
                shop.Description.text = shop.playerShop.MainAccuracyDescription[0];
                string[] inp = shop.playerShop.MainAccuracyCost[0].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
        }
        else if (main == "SecondaryWeapons")
        {
            if (route == "Damage")
            {
                shop.Name.text = shop.playerShop.SecondaryDamageName[index];
                shop.Description.text = shop.playerShop.SecondaryDamageDescription[index];
                string[] inp = shop.playerShop.SecondaryDamageCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
            else if (route == "Speed")
            {
                shop.Name.text = shop.playerShop.SecondarySpeedName[index];
                shop.Description.text = shop.playerShop.SecondarySpeedDescription[index];
                string[] inp = shop.playerShop.SecondarySpeedCost[index].Split(",");
                if (inp[0] == " ") shop.Cost0.SetActive(false);
                else
                {
                    shop.Cost0.SetActive(true);
                    string[] inp2 = inp[0].Split(":");
                    shop.Cost0.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost0.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[1] == " ") shop.Cost1.SetActive(false);
                else
                {
                    shop.Cost1.SetActive(true);
                    string[] inp2 = inp[1].Split(":");
                    shop.Cost1.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
                if (inp[2] == " ") shop.Cost2.SetActive(false);
                else
                {
                    shop.Cost2.SetActive(true);
                    string[] inp2 = inp[2].Split(":");
                    shop.Cost2.GetComponent<Image>().sprite = Materials[Int32.Parse(inp2[0])];
                    shop.Cost2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = inp2[1];
                }
            }
        }



    }

    int Conv(string inpt)
    {
        if(inpt == "0")
        {
            return 0;
        }
        if (inpt == "1")
        {
            return 1;
        }
        if (inpt == "2")
        {
            return 5;
        }
        if (inpt == "3")
        {
            return 2;
        }
        if (inpt == "4")
        {
            return 6;
        }
        if (inpt == "5")
        {
            return 3;
        }
        if (inpt == "6")
        {
            return 4;
        }

        return 0;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (main == "Player")
        {
            if (route == "Damage")
            {
                string[] inp = shop.playerShop.damageCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.damageBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.damageBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.damageDescription[index].Split(" ");
                                print(managerVariables.PlayerStats.damage);
                                managerVariables.PlayerStats.damage += Int32.Parse(inpAdd[3]);
                                print(managerVariables.PlayerStats.damage);

                            }


                        }
                    }                 
                }
                else
                {
                    if (shop.playerShop.damageBool[index-1] && !shop.playerShop.damageBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.damageBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.damageDescription[index].Split(" ");
                                print(managerVariables.PlayerStats.damage);
                                managerVariables.PlayerStats.damage += Int32.Parse(inpAdd[3]);
                                print(managerVariables.PlayerStats.damage);
                            }


                        }
                    }
                    // do code

                }
            }
            else if (route == "Speed")
            {
                string[] inp = shop.playerShop.speedCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.speedBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.speedBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.speedDescription[index].Split(" ");
                                print(managerVariables.PlayerStats.speed);
                                managerVariables.PlayerStats.speed += Int32.Parse(inpAdd[3]);
                                print(managerVariables.PlayerStats.speed);
                            }
                        }
                    }
                    // do code

                }
                else
                {
                    if (shop.playerShop.speedBool[index - 1] && !shop.playerShop.speedBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.speedBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.speedDescription[index].Split(" ");
                                print(managerVariables.PlayerStats.speed);
                                managerVariables.PlayerStats.speed += Int32.Parse(inpAdd[3]);
                                print(managerVariables.PlayerStats.speed);
                            }
                        }
                    }
                    // do code

                }
            }
            else if (route == "Hardness")
            {
                string[] inp = shop.playerShop.hardnessCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.hardnessBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.hardnessBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                print(managerVariables.PlayerStats.hardness);
                                managerVariables.PlayerStats.hardness++;
                                print(managerVariables.PlayerStats.hardness);
                            }
                        }
                    }
                    // do code

                }
                else
                {
                    if (shop.playerShop.hardnessBool[index - 1] && !shop.playerShop.hardnessBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.hardnessBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                print(managerVariables.PlayerStats.hardness);
                                managerVariables.PlayerStats.hardness++;
                                print(managerVariables.PlayerStats.hardness);
                            }
                        }
                    }
                }
            }
        }
        else if (main == "Base")
        {
            if (route == "Shield")
            {
                string[] inp = shop.playerShop.shieldCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.shieldBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.shieldBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                            }


                        }
                    }
                }
                else
                {
                    if (shop.playerShop.shieldBool[index - 1] && !shop.playerShop.shieldBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.shieldBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);
                            }


                        }
                    }
                    // do code

                }
            }
            else if (route == "Health")
            {
                string[] inp = shop.playerShop.healthCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.healthBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.healthBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.healthDescription[index].Split(" ");


                                managerVariables.BaseMax += Int32.Parse(inpAdd[3]);

                            }
                        }
                    }
                    // do code

                }
                else
                {
                    if (shop.playerShop.healthBool[index - 1] && !shop.playerShop.healthBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.healthBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.healthDescription[index].Split(" ");

                                managerVariables.BaseMax += Int32.Parse(inpAdd[3]);

                            }
                        }
                    }
                    // do code

                }
            }
            else if (route == "Repair")
            {
                string[] inp = shop.playerShop.repairCost[index].Split(",");
                if (index == 0)
                {

                    int costOn = 1;
                    if (inp[1] != " ") costOn++;
                    if (inp[2] != " ") costOn++;

                    for (int i = 0; i < costOn; i++)
                    {
                        if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                        {

                        }
                        else if (i == costOn - 1)
                        {
                            transform.GetChild(0).gameObject.SetActive(false);

                            for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                            managerVariables.BaseHP = managerVariables.BaseMax;
                        }
                    }
                    


                }
            }
        }
        else if (main == "MainWeapon")
        {
            if (route == "Damage")
            {
                string[] inp = shop.playerShop.MainDamageCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.MainDamageBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.MainDamageBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.MainDamageDescription[index].Split(" ");
                                managerVariables.Weapon0.BulletDamage += Int32.Parse(inpAdd[3]);
                            }
                        }
                    }
                }
                else
                {
                    if (shop.playerShop.MainDamageBool[index - 1] && !shop.playerShop.MainDamageBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.MainDamageBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.MainDamageDescription[index].Split(" ");
                                managerVariables.Weapon0.BulletDamage += Int32.Parse(inpAdd[3]);
                            }


                        }
                    }
                    // do code

                }
            }
            else if (route == "Speed")
            {
                string[] inp = shop.playerShop.MainSpeedCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.MainSpeedBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.MainSpeedBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.MainSpeedDescription[index].Split(" ");
                                managerVariables.Weapon0.fireRate = 1/Int32.Parse(inpAdd[3]);

                            }
                        }
                    }
                    // do code

                }
                else
                {
                    if (shop.playerShop.MainSpeedBool[index - 1] && !shop.playerShop.MainSpeedBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.MainSpeedBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.MainSpeedDescription[index].Split(" ");
                                managerVariables.Weapon0.fireRate = 1 / Int32.Parse(inpAdd[3]);

                            }
                        }
                    }
                    // do code

                }
            }
        }
        else if (main == "SecondaryWeapons")
        {
            if (route == "Damage")
            {
                string[] inp = shop.playerShop.SecondaryDamageCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.SecondaryDamageBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.SecondaryDamageBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.MainDamageDescription[index].Split(" ");
                                managerVariables.Weapon1.BulletDamage += Int32.Parse(inpAdd[3]);
                                managerVariables.Weapon2.BulletDamage += Int32.Parse(inpAdd[3]);
                            }
                        }
                    }
                }
                else
                {
                    if (shop.playerShop.SecondaryDamageBool[index - 1] && !shop.playerShop.SecondaryDamageBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.SecondaryDamageBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.SecondaryDamageDescription[index].Split(" ");
                                managerVariables.Weapon1.BulletDamage += Int32.Parse(inpAdd[3]);
                                managerVariables.Weapon2.BulletDamage += Int32.Parse(inpAdd[3]);
                            }


                        }
                    }
                    // do code

                }
            }
            else if (route == "Speed")
            {
                string[] inp = shop.playerShop.SecondarySpeedCost[index].Split(",");
                if (index == 0)
                {
                    if (!shop.playerShop.SecondarySpeedBool[0])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.SecondarySpeedBool[0] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.SecondarySpeedDescription[index].Split(" ");
                                managerVariables.Weapon1.fireRate = 1/Int32.Parse(inpAdd[3]);
                                managerVariables.Weapon2.fireRate = 1 / Int32.Parse(inpAdd[3]);
                            }
                        }
                    }
                    // do code

                }
                else
                {
                    if (shop.playerShop.SecondarySpeedBool[index - 1] && !shop.playerShop.SecondarySpeedBool[index])
                    {
                        int costOn = 1;
                        if (inp[1] != " ") costOn++;
                        if (inp[2] != " ") costOn++;

                        for (int i = 0; i < costOn; i++)
                        {
                            if (managerVariables.PlayerStats.Materials[Conv(inp[i].Split(":")[0]) + 1] < Int32.Parse(inp[i].Split(":")[1]))
                            {

                            }
                            else if (i == costOn - 1)
                            {
                                transform.GetChild(0).gameObject.SetActive(false);
                                transform.GetChild(1).gameObject.SetActive(true);
                                shop.playerShop.SecondarySpeedBool[index] = true;

                                for (int j = 0; j < costOn; j++) managerVariables.PlayerStats.Materials[Conv(inp[j].Split(":")[0]) + 1] -= Int32.Parse(inp[j].Split(":")[1]);

                                string[] inpAdd = shop.playerShop.SecondarySpeedDescription[index].Split(" ");
                                managerVariables.Weapon1.fireRate = 1 / Int32.Parse(inpAdd[3]);
                                managerVariables.Weapon2.fireRate = 1 / Int32.Parse(inpAdd[3]);
                            }
                        }
                    }
                    // do code

                }
            }
        }
    }

    private void Update()
    {
        if (main == "Player")
        {
            if (route == "Damage")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.damageBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
            else if (route == "Speed")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.speedBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
            else if (route == "Hardness")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.hardnessBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
        }
        else if (main == "Base")
        {
            if (route == "Shield")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.shieldBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
            else if (route == "Health")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.healthBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
            else if (route == "Repair")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
            }
        }
        else if (main == "MainWeapon")
        {
            if (route == "Damage")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.MainDamageBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
            else if (route == "Speed")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.MainSpeedBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
            else if (route == "Accuracy")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.MainAccuracyBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
        }
        else if (main == "SecondaryWeapons")
        {
            if (route == "Damage")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.MainDamageBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
            else if (route == "Speed")
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
                else
                {
                    if (shop.playerShop.MainSpeedBool[index - 1])
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
