using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class RestartPanel : MonoBehaviour
{
    [SerializeField] private Button _restartButton; //Кнопка Перезапуска
    [SerializeField] private Player _player;

    private CanvasGroup _canvasGroup;

    //Подписка на событие 
    private void OnEnable()
    {
        _player.Wins += OnWins;
        _restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    //Отписка
    private void OnDisable()
    {
        _player.Wins -= OnWins;
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
    }

    
    void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0; //При старте панель не видно
    }

    private void OnWins()
    {
        _canvasGroup.alpha = 1; //Появление панели
        Time.timeScale = 0;
    }



    //Процедура перезапуска
    private void OnRestartButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
