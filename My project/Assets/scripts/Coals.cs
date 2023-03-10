using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coals : MonoBehaviour
{
    [SerializeField]
    public float MaxHealth = 50;
    public float Health = 50;
    public int Hardness = 0;
    public float Size;
    public Sprite Material;
    public int distance;

    public HealthBar HealthBar;

    public GameObject text;

    int rock1Chance = 0;
    int rock2Chance = 0;
    int rock3Chance = 0;
    int rock4Chance = 0;

    int size3Chance = 0;
    int size4Chance = 0;
    int size5Chance = 0;

    manager managerVariables;
    private void Start()
    {
        managerVariables = GameObject.Find("Manager").GetComponent<manager>();
        distance = Mathf.Abs((int)transform.position.x);

        //=== Size ===//
        int rnd = Random.Range(1, 100);

        if (distance > 50) size3Chance = distance / 2;
        if (distance > 200) size4Chance = distance / 6;
        if (distance > 500) size5Chance = distance / 20;


        if (size5Chance >= rnd) Size = 5;
        else if (size4Chance >= rnd) Size = 4;
        else if (size3Chance >= rnd) Size = 3;
        else Size = 2;

        //=== HP ===//
        MaxHealth += (distance * distance) / 200;
        MaxHealth += (Size - 2) * 100;

        Health = MaxHealth;
        float Scale = 2 / (5 / Size);
        transform.position = new Vector3(transform.position.x, -3 + Scale / 2, transform.position.z);
        transform.localScale = new Vector3(Scale, Scale, Scale);
        if(Random.Range(1, 100) > 50) transform.rotation = Quaternion.Euler(0, 180, 0);
        GetComponent<SpriteRenderer>().sprite = Material;
        HealthBar.SetHealth(Health, MaxHealth);
    }

    public void TakeHit(float damage)
    {
        Health -= damage;
        HealthBar.SetHealth(Health, MaxHealth);

        if (Health <= 0)
        {
            managerVariables.PlayerStats.Materials[0] += (int)Size - 1;
            text.gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().text = "+ " + ((int)Size - 1).ToString() + " coal";
            Instantiate(text,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
