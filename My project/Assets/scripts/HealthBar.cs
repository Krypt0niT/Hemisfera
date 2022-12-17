using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI text;
    public Color low;
    public Color high;
    public Vector3 offset;
    public int size;

    public void SetHealth(float health, float maxHealth)
    {    
        slider.maxValue = maxHealth;
        slider.value = health;
        text.text = "Health: " + (int)health;

        slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low, high, slider.normalizedValue);
    }

    private void Start()
    {
        slider.gameObject.SetActive(false);
        
    }

    void Update()
    {
        offset.y = (1.5f + (2 / (5 / GetComponentInParent<Rocks>().Size))) / 2;
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
        text.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);

    }
}
