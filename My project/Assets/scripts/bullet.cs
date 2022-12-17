using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float bulletTime = 0;
    float speed;
    float damage;
    manager managerVariables;
    // Start is called before the first frame update
    void Start()
    {
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();
        damage = managerVariables.BulletDamage;
        speed = managerVariables.BulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        bulletTime += Time.deltaTime;
        if (bulletTime > 5) { Destroy(this.gameObject); }
        else { transform.position -= transform.right * Time.deltaTime * speed; }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }

}
