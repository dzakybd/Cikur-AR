using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_script : MonoBehaviour {

    public void GoToHowtoPlay()
    {
        Application.LoadLevel("howtoplay");
    }

    public void GoToARCamera()
    {
        Application.LoadLevel("utama");
    }

    public void GoToQuiz()
    {
        Application.LoadLevel("test");
    }

    public void GoToAbout()
    {
        Application.LoadLevel("about");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

}
