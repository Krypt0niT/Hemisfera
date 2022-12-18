using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
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
    }
}