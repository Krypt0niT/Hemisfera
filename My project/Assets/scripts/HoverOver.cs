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
                                managerVariables.PlayerStats.damage += Int32.Parse(inpAdd[3]);
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
                                managerVariables.PlayerStats.damage += Int32.Parse(inpAdd[3]);
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

                            }

                            print(managerVariables.PlayerStats.hardness);
                            managerVariables.PlayerStats.hardness ++;
                            print(managerVariables.PlayerStats.hardness);
                        }
                    }
                }
            }
        }
        else if (main == "Base")
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

                            }


                        }
                    }
                    // do code

                }
                else
                {
                    if (shop.playerShop.damageBool[index - 1] && !shop.playerShop.damageBool[index])
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
        }
    }
}
