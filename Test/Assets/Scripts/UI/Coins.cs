using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    [SerializeField] private Player player; //Обьект player
    [SerializeField] private Text _textSpheres; //Текст количества сфер на Canvas

    
    private void OnEnable()
    {
        player.CollectedSpheres += OnCollectedSpheres; // Подписка на событие сбор сфер
    }

    private void OnDisable()
    {
        player.CollectedSpheres -= OnCollectedSpheres; //Отписка на событие сбор сфер
    }

    //Вывод собранных сфер на Canvas
    private void OnCollectedSpheres(int sphereCount)
    {
        _textSpheres.text = sphereCount.ToString();
    }

}
