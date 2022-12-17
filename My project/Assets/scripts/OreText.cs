using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class OreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(kill), 4f);
        
    }

    private void Update()
    {
        gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().alpha -= Time.deltaTime / 4;
        gameObject.transform.position = new(transform.position.x, transform.position.y + Time.deltaTime * .2f, transform.position.z);
    }
    void kill()
    {
        Destroy(gameObject);
    }
}