using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private Button playAgainButton;
    
    void Update()
    {
        if (Time.timeScale == 0)
            playAgainButton.gameObject.SetActive(true);
    }

    public void playAgain()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        playAgainButton.gameObject.SetActive(false);
    }
}
