using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    bool aboutT = false;
    [SerializeField] GameObject aboutText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void startgame()
    {
        SceneManager.LoadScene(1);
    }
    public void about()
    {
        if (aboutT)
        {
            aboutText.SetActive(false);
            aboutT = false;
        }
        else
        {
            aboutText.SetActive(true);
            aboutT = true;

        }

    }


}
