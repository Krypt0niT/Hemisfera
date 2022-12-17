using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] List<GameObject> spawnPointy = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawn(int count,float strengh)
    {
        
        int rnd = Random.Range(0,5);
        if (rnd >= 3)
        {
            Instantiate(enemy, spawnPointy[rnd].gameObject.transform.position + new Vector3(Random.Range(-2,2), Random.Range(-2, 2), Random.Range(-2, 2)), Quaternion.identity * Quaternion.Euler(0,180,0)).transform.SetParent(GameObject.Find("Enemies").gameObject.transform);
        }
        else
        {
            Instantiate(enemy, spawnPointy[rnd].gameObject.transform.position, Quaternion.identity).transform.SetParent(GameObject.Find("Enemies").gameObject.transform);

        }


    }

}
