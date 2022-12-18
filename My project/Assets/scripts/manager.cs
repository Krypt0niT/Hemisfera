using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class manager : MonoBehaviour
{
    [SerializeField]
    GameObject rock;
    [SerializeField]
    GameObject coal;

    // Start is called before the first frame update
    public bool raid = false;
    int dayTime = 50;
    float dayTick = 0;
    float raidSpawner = 0;
    int raidSpawned = 0;
    bool firsttime = true;

    int RaidPower = 4;
    public float RaidStrengh = 1;
    int enemyAlive = 0;





    public float BaseHP = 100;

    [SerializeField] GameObject timer;
    [SerializeField] GameObject timerBG;
    GameObject spawner;
    public class Player
    {
        public float speed = 5f;
        public int[] Materials = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

    }
    public Player PlayerStats = new Player();

    public class Weapon
    {
        public float BulletDamage;
        public float BulletSpeed;
        public float fireRate;
        public float rozptyl;
        public Weapon(int order)
        {
            if(order == 0)
            {
                BulletDamage = 5;
                BulletSpeed = 80;
                fireRate = 1f;
                rozptyl = 2;
                
            }
            if (order == 1)
            {
                BulletDamage = 4;
                BulletSpeed = 100;
                fireRate = 0.1f;
                rozptyl = 15;
            }
            else
            {
                BulletDamage = 4;
                BulletSpeed = 100;
                fireRate = 0.2f;
                rozptyl = 15;
            }
        }
    }





    public Weapon Weapon0 = new Weapon(0);
    public Weapon Weapon1 = new Weapon(1);
    public Weapon Weapon2 = new Weapon(2);

    void Start()
    {
        for (float i = 10; i < 1000; i += 17 - Mathf.Sqrt(Random.Range(1f, 256f)))
        {
            Instantiate(rock, new Vector3(i, 0, 0), Quaternion.identity).transform.SetParent(GameObject.Find("Rocks").gameObject.transform);
        }
        for (float i = 10; i < 1000; i += 17 - Mathf.Sqrt(Random.Range(1f, 256f)))
        {
            Instantiate(rock, new Vector3(-i, 0, 0), Quaternion.identity).transform.SetParent(GameObject.Find("Rocks").gameObject.transform); ;
        }
        for (float i = 12; i < 1000; i += Random.Range(2f, 10f))
        {
            Instantiate(coal, new Vector3(i, 0, -1), Quaternion.identity).transform.SetParent(GameObject.Find("Rocks").gameObject.transform); ;
        }
        for (float i = 12; i < 1000; i += Random.Range(2f, 10f))
        {
            Instantiate(coal, new Vector3(-i, 0, -1), Quaternion.identity).transform.SetParent(GameObject.Find("Rocks").gameObject.transform); ;
        }

        spawner = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        /*print("Coal: " + PlayerStats.Materials[0].ToString() 
            + "   stone: " + PlayerStats.Materials[1].ToString() 
            + "   iron: " + PlayerStats.Materials[2].ToString()
            + "   gold: " + PlayerStats.Materials[3].ToString()
            + "   dia: " + PlayerStats.Materials[4].ToString()
            + "   haluz: " + PlayerStats.Materials[5].ToString());*/
        dayTick += Time.deltaTime;
        if (dayTick >= 1)
        {
            
            
            if (dayTime == 60)
            {
                timerBG.GetComponent<SpriteRenderer>().color = new Color32(200,20,20,255);
                GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = new Color32(63, 40, 41, 255);
                raid = true;
                dayTick = 0;
                print(RaidPower);
                if (firsttime)
                {
                    spawner.GetComponent<Spawner>().spawn(RaidPower);
                    firsttime = false;
                }
                enemyAlive = GameObject.Find("Enemies").transform.childCount;
                if (enemyAlive == 0)
                {
                    firsttime = true;
                    raid = false;
                    dayTime = 0;
                    RaidPower += 2;
                    RaidStrengh += 0.1f;
                    timer.GetComponent<TextMeshPro>().text = dayTime.ToString();
                    timerBG.GetComponent<SpriteRenderer>().color = new Color32(36, 31, 31, 255);
                    GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = new Color32(51, 51, 51, 255);

                }
            }
            else
            {
                raidSpawned = 0;
                dayTime++;
                dayTick = 0;
                timer.GetComponent<TextMeshPro>().text = dayTime.ToString();
                timerBG.GetComponent<SpriteRenderer>().color = new Color32(36, 31, 31, 255);
                GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = new Color32(51, 51, 51, 255);

            }
        }
        if (raid)
        {
            print(raidSpawned);
            if(raidSpawned < RaidPower)
            {
                raidSpawner += Time.deltaTime;
                if (raidSpawner > 1)
                {
                    raidSpawned++;
                    raidSpawner = 0;
                    spawner.GetComponent<Spawner>().spawn(RaidPower);
                }
            }
            
        }
        
        

    }
}
