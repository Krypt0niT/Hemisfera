using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    SpriteRenderer EnemyRend;
    string animState = "Pohyb";
    float speed = 2;
    bool finish = false;

    float moveOfset = 0;
    float moveOfsetTick = 0;

    [SerializeField] List<Sprite> Pohyb = new List<Sprite>();
    float pohybTick = 0;
    float pohybSpeed = 7;
    int pohybIndex = 0;

    [SerializeField] List<Sprite> Attack = new List<Sprite>();
    float attackTick = 0;
    float attackSpeed = 7;
    int attackIndex = 0;

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
        /*else
        {
            
            if(moveOfsetTick <= moveOfset)
            {
                moveOfsetTick += (transform.position.x + (speed * Time.deltaTime));
                if (transform.position.x < 0)
                {
                    transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);
                }
            }
            if (moveOfsetTick >= moveOfset)
            {
                moveOfsetTick -= (transform.position.x - (speed * Time.deltaTime));
                if (transform.position.x > 0)
                {
                    transform.position = new Vector3(transform.position.x - (speed * Time.deltaTime), transform.position.y, transform.position.z);
                }
            }


        }*/
        else
        {
            animState = "attacking";
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
        else if (animState == "attacking")
        {
            attackTick += Time.deltaTime;
            if (attackTick >= 1 / attackSpeed)
            {
                EnemyRend.sprite = Attack[attackIndex];
                attackTick = 0;
                if (attackIndex < Attack.Count - 1)
                {
                    attackIndex++;
                }
                else
                {
                    attackIndex = 0;
                }

            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AttackArea")
        {
            moveOfset = Random.Range(1f,2f);
            finish = true;
        }
    }
}
