using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthPlatformer : MonoBehaviour
{
    public Slider health;
    public float MaxValue = 100f;

    float _currentValue;

    public GameObject barrier;
    public float damage;

    private void Start()
    {
        _currentValue = MaxValue;
        UpdateHealthBar();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _currentValue -= damage;
        UpdateHealthBar() ;
    }

    void UpdateHealthBar()
    {
        health.value = _currentValue / MaxValue;
    }
        

}

