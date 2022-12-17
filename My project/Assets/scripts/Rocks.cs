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
    public float Size;
    public Sprite[] Materials;
    public int distance;

    public HealthBar HealthBar;

    int rock1Chance = 0;
    int rock2Chance = 0;
    int rock3Chance = 0;
    int rock4Chance = 0;

    int size3Chance = 0;
    int size4Chance = 0;
    int size5Chance = 0;

    private void Start()
    {
        distance = Mathf.Abs((int)transform.position.x);

        //=== Hardness ===//
        int rnd = Random.Range(1, 100);

        if (distance > 50) rock1Chance = distance / 2;
        if (distance > 150) rock2Chance = distance / 10;
        if (distance > 350) rock3Chance = distance / 16;
        if (distance > 600) rock4Chance = distance / 50;

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
            if(Random.Range(1, 100) > 50)GetComponent<SpriteRenderer>().sprite = Materials[0];
            else GetComponent<SpriteRenderer>().sprite = Materials[5];
        }

        //=== Size ===//
        rnd = Random.Range(1, 100);

        if (distance > 50) size3Chance = distance / 2;
        if (distance > 200) size4Chance = distance / 6;
        if (distance > 500) size5Chance = distance / 20;


        if (size5Chance >= rnd) Size = 5;
        else if (size4Chance >= rnd) Size = 4;
        else if (size3Chance >= rnd) Size = 3;
        else Size = 2;

        //=== HP ===//
        MaxHealth += (distance * distance) / 100;
        MaxHealth += (Size - 2) * 100;
        MaxHealth += Hardness * 200;

        Health = MaxHealth;
        float Scale = 2 / (5/Size) * 1.5f;
        transform.position = new Vector3(transform.position.x,-3 + Scale/2, transform.position.z);
        transform.localScale = new Vector3(Scale, Scale, Scale);
        if (Random.Range(1, 100) > 50) transform.rotation = Quaternion.Euler(0, 180, 0);
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
