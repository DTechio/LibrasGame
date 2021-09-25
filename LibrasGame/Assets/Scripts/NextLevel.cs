using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    public Button NextButton;
    private void Start()
    {
        Button btn = NextButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadSceneOnClick);
    }
    void LoadSceneOnClick()
    {
        SceneManager.LoadScene(1);
    }
}
