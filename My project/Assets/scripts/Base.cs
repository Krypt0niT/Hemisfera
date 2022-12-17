using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] GameObject front;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            front.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        front.SetActive(true);
    }
}
