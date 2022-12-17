using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    SpriteRenderer EnemyRend;
    string animState = "Pohyb";
    float speed = 2;
    bool finish = false;


    [SerializeField] List<Sprite> Pohyb = new List<Sprite>();
    float pohybTick = 0;
    float pohybSpeed = 7;
    int pohybIndex = 0;

    void Start()
    {
        EnemyRend = this.gameObject.GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        if (!finish)
        {
            if (transform.position.x < 0)
            {
                transform.position = new Vector3(transform.position.x +(speed * Time.deltaTime), transform.position.y,transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x - (speed * Time.deltaTime), transform.position.y, transform.position.z);

            }
        }







        //animacie
        if (animState == "Pohyb")
        {
            pohybTick += Time.deltaTime;
            if (pohybTick >= 1 / pohybSpeed)
            {
                EnemyRend.sprite = Pohyb[pohybIndex];
                pohybTick = 0;
                if (pohybIndex < Pohyb.Count - 1)
                {
                    pohybIndex++;
                }
                else
                {
                    pohybIndex = 0;
                }

            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AttackArea")
        {
            print("bravcova rit");
            finish = true;
        }
    }
}
