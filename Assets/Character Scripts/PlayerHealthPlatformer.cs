using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthPlatformer : MonoBehaviour
{
    public GameObject PlayerUI;
    public GameObject GameOverUI;

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
        if (_currentValue <= 0)
        {
            _currentValue = 0;
            GameOver();
        }
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        health.value = _currentValue / MaxValue;
    }
        
    void GameOver()
    {
        GameOverUI.SetActive(true);
        PlayerUI.SetActive(false);
        GetComponent<ControllerPlatformer>().enabled = false;
    }

}

