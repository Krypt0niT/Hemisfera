using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(kill), 5f);
    }

    // Update is called once per frame
    void kill()
    {
        Destroy(gameObject);
    }
}