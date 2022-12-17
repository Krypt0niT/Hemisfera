using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapons : MonoBehaviour
{

    Vector2 mousePos;
    [SerializeField] Transform weaponPointer;
    [SerializeField] GameObject weapon1;
    [SerializeField] GameObject weapon2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<Player>().usingWeapons)
        {
            if (Input.mousePosition.x > 960)
            {
                weapon1.SetActive(true);
                weapon2.SetActive(false);

            }
            if (Input.mousePosition.x < 960)
            {
                weapon1.SetActive(false);
                weapon2.SetActive(true);

            }
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(new Vector3(weaponPointer.position.x, weaponPointer.position.y, weaponPointer.position.z));
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            weaponPointer.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        }
        
      

    }
}
