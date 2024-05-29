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

    public float _currentValue;

    public GameObject barrier;
    public float damage;

    public AudioSource damageSound;

    private void Start()
    {
        _currentValue = MaxValue;
        UpdateHealthBar();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _currentValue -= damage;
        damageSound.Play();
        if (_currentValue <= 0)
        {
            _currentValue = 0;
            GameOver();
        }
        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        health.value = _currentValue / MaxValue;
    }
        
     public void GameOver()
    {
        GameOverUI.SetActive(true);
        PlayerUI.SetActive(false);
        GetComponent<PlayerControllerPlatformer>().enabled = false;
    }

}

