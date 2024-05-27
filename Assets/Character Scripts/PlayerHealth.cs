using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float MaxValue = 100;
    public Slider Healthbar;

    //Не забудь указать ссылки на эти UI элементы в сцене
    //public GameObject PlayerUI;
    //public GameObject GameOverUI;

    float _currentValue;

    void Start()
    {
        _currentValue = MaxValue;
        UpdateHealthbar();
    }

    public void TakeDamage(float damage)
    {
        _currentValue -= damage;
        if (_currentValue <= 0)
        {
            _currentValue = 0;
            //Если здоровья не осталось, вызвать метод конца игры
            //???();
        }
        UpdateHealthbar();
    }

    void UpdateHealthbar()
    {
        Healthbar.value = _currentValue / MaxValue;
    }

    void GameOver()
    {
        //включить или отключить объекты и компоненты
        //PlayerUI.SetActive(???);
        //GameOverUI.SetActive(???);
        //GetComponent<Player>().enabled = ???;
        //GetComponent<CameraController>().enabled = ???;
    }
}
