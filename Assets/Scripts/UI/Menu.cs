using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _play;
    [SerializeField] private Button _aboutCreators;
    [SerializeField] private Button _exit;
    [SerializeField] private GameObject _aboutCreatorsMenu;

    private const int _levelIndex = 1;

    public void ClickPlayButton()
    {
        SceneManager.LoadScene(_levelIndex);
    }

    public void ClickExitButton()
    {
        Debug.Log("Выход");
        Application.Quit();
    }

    public void ClickAboutCreatorsButton()
    {
        _aboutCreatorsMenu.SetActive(true);
    }
}
