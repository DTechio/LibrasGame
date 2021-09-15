using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleConcluido : MonoBehaviour
{
    [SerializeField] private GameObject _slots;
    private int pointsToWin;
    private int currentPoints;
    void Start()
    {
        pointsToWin = _slots.transform.childCount;
        Debug.Log(pointsToWin);
    }

    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            Debug.Log("WIN");
            SceneManager.LoadScene(1);
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
