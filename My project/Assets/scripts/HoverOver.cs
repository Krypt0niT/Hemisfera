using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverOver : MonoBehaviour, IPointerEnterHandler
{
    public Shop shop;
    public string main;
    public string route;
    public int index;

    public Sprite[] Materials;


    private void Start()
    {
        
    }



    public void OnPointerEnter(PointerEventData eventData)
    {
       /* if(main == "Player")
        {
            if(route == "Damage")
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
            else if(route == "Speed")
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
        }*/



    }
}
