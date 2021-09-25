using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleConcluido : MonoBehaviour
{
    [SerializeField] private GameObject _slots;
    [SerializeField] private GameObject _buttonEnviar;
    [SerializeField] private GameObject _buttonNext;
    [SerializeField] private GameObject _gestoBook;


    private int _pointsToWin;
    private int _currentPoints;

    void Start()
    {
        Button btn = _buttonNext.GetComponent<Button>();
        btn.onClick.AddListener(LoadSceneOnClick);

        _pointsToWin = _slots.transform.childCount;
        Debug.Log(_pointsToWin);
    }

    void Update()
    {
        if (_currentPoints >= _pointsToWin)
        {
            //Debug.Log("WIN");
            _buttonEnviar.SetActive(true);
            _gestoBook.SetActive(true);
        }
        
    }

    public void AddPoints()
    {
        _currentPoints++;
    }

    void LoadSceneOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}