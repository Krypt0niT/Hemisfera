using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    SpriteRenderer EnemyRend;
    string animState = "Pohyb";
    public float health = 10;
    float speed = 2;
    bool finish = false;
    float damage;

    manager managerVariables;

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
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();

        float r = Random.Range(140,255);
        float g = Random.Range(140,255);
        float b = Random.Range(140,255);

        GetComponent<SpriteRenderer>().color = new Color32((byte)r,(byte)g,(byte)b,255);
        float rnd = Random.Range(0.5f, managerVariables.RaidStrengh);
        transform.localScale = new Vector3(rnd, rnd,transform.localScale.z);
        health = Random.Range(1, managerVariables.RaidStrengh) *10;
        damage = managerVariables.RaidStrengh;
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
        
        else
        {
            animState = "attacking";
        }


        if (health <= 0)
        {
            Destroy(gameObject);
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
                if (attackIndex == 3)
                {
                    managerVariables.BaseHP-= damage;
                }

            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AttackArea")
        {
            finish = true;

        }
    }
}
