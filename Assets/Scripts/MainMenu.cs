using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play(){
        Info.liveTimes = 2;
        Info.coins = 0;
        SceneManager.LoadScene("Level1");
    }

    public void Options(){
        SceneManager.LoadScene("Level1");
    }

    public void Quit(){
        Application.Quit();
    }
}
