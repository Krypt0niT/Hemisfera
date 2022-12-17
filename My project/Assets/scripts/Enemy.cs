using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    SpriteRenderer EnemyRend;
    string animState = "Pohyb";




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
}
