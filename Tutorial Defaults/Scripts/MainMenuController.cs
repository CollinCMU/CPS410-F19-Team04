using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Author: Collin Van Brabant

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;     //Gets the container for the main menu
    public GameObject optionsMenu;  //Gets the container for the options menu

    //loads level select
    public void playGame(){
        SceneManager.LoadScene("Level Select");
    }

    //switches to options screen by switching active container
    public void options(){
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    //switches back to main menu screen
    public void back(){
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    //exits the game
    public void exitGame(){
        Application.Quit();
    }
}