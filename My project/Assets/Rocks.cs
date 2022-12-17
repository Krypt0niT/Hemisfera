using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rocks : MonoBehaviour
{
    [SerializeField]
    public int MaxHealth;
    public int Health;
    public int Hardness;
    public float Size;
    public int MaterialIndex;

    private void Start()
    {
        Health = MaxHealth;
        float Scale = 2 / (5/Size);
        transform.localScale = new Vector3(Scale, Scale, Scale);
    }
}
