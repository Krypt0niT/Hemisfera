using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class manager : MonoBehaviour
{
    [SerializeField]
    GameObject rock;

    // Start is called before the first frame update
    public bool raid = false;
    int dayTime = 0;
    float dayTick = 0;

    int RaidTime = 20;
    int RaidLength = 0;
    

    public float BulletDamage = 5;
    public float BulletSpeed = 20;
    public float fireRate = 0.5f;


    [SerializeField] GameObject timer;
    [SerializeField] GameObject timerBG;
    public class Player
    {
        public float speed = 5f;
    }
    public Player PlayerStats = new Player();
    void Start()
    {
        for (int i = 20; i < 1000; i += Random.Range(10, 30))
        {
            Instantiate(rock, new Vector3(i, 0, 0), Quaternion.identity);
        }
        for (int i = 20; i < 1000; i += Random.Range(10, 30))
        {
            Instantiate(rock, new Vector3(-i, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        dayTick += Time.deltaTime;
        if (dayTick >= 1)
        {
            
            
            if (dayTime == 60)
            {
                timerBG.GetComponent<SpriteRenderer>().color = Color.red;
                GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = new Color32(63, 40, 41, 255);
                raid = true;
                RaidLength++;
                dayTick = 0;
                if (RaidLength >= RaidTime)
                {
                    raid = false;
                    RaidLength = 0;
                    dayTime = 0;
                    timer.GetComponent<TextMeshPro>().text = dayTime.ToString();
                    timerBG.GetComponent<SpriteRenderer>().color = Color.green;
                    GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = new Color32(68, 116, 153, 255);

                }
            }
            else
            {
                dayTime++;
                dayTick = 0;
                timer.GetComponent<TextMeshPro>().text = dayTime.ToString();
                timerBG.GetComponent<SpriteRenderer>().color = Color.green;
                GameObject.Find("Main Camera").GetComponent<Camera>().backgroundColor = new Color32(68, 116, 153, 255);

            }
        }
        

    }
}
