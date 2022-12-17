using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Rocks : MonoBehaviour
{
    [SerializeField]
    public float MaxHealth;
    public float Health;
    public int Hardness;
    public int Size;
    public Sprite[] Materials;
    public int distance;

    public HealthBar HealthBar;

    int rock1Chance;
    int rock2Chance;
    int rock3Chance;
    int rock4Chance;
     
    private void Start()
    {
        distance = Mathf.Abs((int)transform.position.x);
        int rnd = Random.Range(1, 100);

        rock1Chance = distance / 2;
        rock2Chance = distance / 20;
        rock3Chance = distance / 50;
        rock4Chance = distance / 100;

        if (rock4Chance >= rnd)
        {
            Hardness = 4;
            GetComponent<SpriteRenderer>().sprite = Materials[4];
        }
        else if (rock3Chance >= rnd) { 
            Hardness = 3;
            GetComponent<SpriteRenderer>().sprite = Materials[3];
        }
        else if (rock2Chance >= rnd) { 
            Hardness = 2;
            GetComponent<SpriteRenderer>().sprite = Materials[2];
        }
        else if (rock1Chance >= rnd) { 
            Hardness = 1;
            GetComponent<SpriteRenderer>().sprite = Materials[1];
        }
        else
        {
            Hardness = 0;
            GetComponent<SpriteRenderer>().sprite = Materials[0];
        }




        Health = MaxHealth;
        float Scale = 2 / (5/Size);
        transform.position = new Vector3(transform.position.x,-3 + Scale/2, transform.position.z);
        transform.localScale = new Vector3(Scale, Scale, Scale);

        HealthBar.SetHealth(Health, MaxHealth);
    }

    public void TakeHit(float damage)
    {
        Health -= damage;
        HealthBar.SetHealth(Health, MaxHealth);

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
