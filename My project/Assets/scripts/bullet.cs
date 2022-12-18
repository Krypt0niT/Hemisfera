using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float bulletTime = 0;
    float speed;
    float damage;
    public int parent;
    manager managerVariables;
    manager.Weapon thisWeapon;
    // Start is called before the first frame update
    void Start()
    {
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();
        if (parent == 0)
            thisWeapon = managerVariables.Weapon0;
        else if (parent == 1)
            thisWeapon = managerVariables.Weapon1;
        else
            thisWeapon = managerVariables.Weapon2;

        damage = thisWeapon.BulletDamage;
        speed = thisWeapon.BulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        bulletTime += Time.deltaTime;
        if (bulletTime > 2) { Destroy(this.gameObject); }
        else { transform.position -= transform.right * Time.deltaTime * speed; }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().health -= damage;
            print("kolizia");
        }
    }

}
