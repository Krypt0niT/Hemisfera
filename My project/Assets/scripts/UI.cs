using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] List<GameObject> hodnoty = new List<GameObject>();
    manager managerVariables;
    void Start()
    {
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();
    }

    void Update()
    {
        for (int i = 0; i < hodnoty.Count; i++)
        {
            hodnoty[i].GetComponent<TextMeshPro>().text = managerVariables.PlayerStats.Materials[i].ToString(); 
        }
    }
}
