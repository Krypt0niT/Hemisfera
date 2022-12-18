using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapons : MonoBehaviour
{

    [SerializeField] Transform weaponPointer;
    [SerializeField] GameObject weapon1;
    [SerializeField] GameObject weapon2;
    [SerializeField] GameObject bullet;
    [SerializeField] Vector3 bulletOfset;
    float fireTick = 0;

    public int order;
    string[] split;

    manager.Weapon thisWeapon;
    Controls controls;
    manager managerVariables;
    void Start()
    {
        controls = GameObject.Find("Manager").GetComponent<Controls>();
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();
        split = this.gameObject.name.Split('-');
        order = Int32.Parse(split[1]);
        print(order);
        if (order == 0)
            thisWeapon = managerVariables.Weapon0;
        else if (order == 1)
            thisWeapon = managerVariables.Weapon1;
        else
            thisWeapon = managerVariables.Weapon2;


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
                if (controls.PlayerAttack)
                {
                    fireTick += Time.deltaTime;
                    if (fireTick >= thisWeapon.fireRate)
                    {
                        fireTick = 0;

                        Instantiate(bullet, gameObject.transform.Find("Firespot").transform.position, this.gameObject.transform.rotation * Quaternion.Euler(0,0, UnityEngine.Random.Range(-thisWeapon.rozptyl, thisWeapon.rozptyl)))
                            .GetComponent<bullet>().parent = order;
                    }
                    
                }
                
            }
            if (Input.mousePosition.x < 960)
            {
                weapon1.SetActive(false);
                weapon2.SetActive(true);
                if (controls.PlayerAttack)
                {
                    fireTick += Time.deltaTime;
                    if (fireTick >= thisWeapon.fireRate)
                    {
                        fireTick = 0;

                        Instantiate(bullet, gameObject.transform.Find("Firespot").transform.position, this.gameObject.transform.rotation * Quaternion.Euler(0, 0, UnityEngine.Random.Range(-thisWeapon.rozptyl, thisWeapon.rozptyl)))
                                                   .GetComponent<bullet>().parent = order;
                    }
                }

            }
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(new Vector3(weaponPointer.position.x, weaponPointer.position.y, weaponPointer.position.z));
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            weaponPointer.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        }
        
      

    }
}
