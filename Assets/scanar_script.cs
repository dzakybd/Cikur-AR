using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scanar_script : MonoBehaviour {
	public Text txt;
    public Button bmenu;
    public GameObject detail;
	// Use this for initialization
	void Start () {		
        bmenu.onClick.AddListener(GoToMenu);
	}
	
	void GoToMenu()
    {
        if(!detail.gameObject.activeInHierarchy)SceneManager.LoadScene("menu");
        else{
            detail.gameObject.SetActive(false);
            txt.text = "Menu";
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))GoToMenu();
    }
}
