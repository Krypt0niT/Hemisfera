using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    [SerializeField] GameObject baseHealthSlider;
    [SerializeField] List<TextMeshProUGUI> hodnoty;
    manager managerVariables;
    void Start()
    {
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();
    }

    void Update()
    {
        for(int i = 0; i < hodnoty.Count; i++)
        {
            hodnoty[i].text = managerVariables.PlayerStats.Materials[i].ToString();
        }
        baseHealthSlider.GetComponent<Slider>().value = managerVariables.BaseHP;
        baseHealthSlider.GetComponent<Slider>().maxValue = managerVariables.BaseMax;
    }
}
