using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControl : MonoBehaviour
{
    [SerializeField] private GameObject _pauseUI;

    public void Pause()
    {
        _pauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        _pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

}
