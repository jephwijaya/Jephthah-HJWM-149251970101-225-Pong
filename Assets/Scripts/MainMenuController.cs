using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        //Log Author Name When Click Play Game
        Debug.Log("Created by Jephthah Heran Jati Wijoyo Mukti - 149251970101-225");
        SceneManager.LoadScene("Game");
    }
}