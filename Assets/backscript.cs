using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backscript : MonoBehaviour {

 	public void GoToMainMenu()
    {
        Application.LoadLevel("main_menu");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))GoToMainMenu();
    }

}
