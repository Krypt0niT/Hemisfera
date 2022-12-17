using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapons : MonoBehaviour
{

    Vector2 mousePos;
    [SerializeField] Transform weaponPointer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        print(mousePos);
        weaponPointer.LookAt(mousePos);

    }
}
