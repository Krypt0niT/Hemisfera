using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deadscreen : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(zapnutHru), 5f);
    }


    void zapnutHru()
    {
        SceneManager.LoadScene(0);
    }
}
