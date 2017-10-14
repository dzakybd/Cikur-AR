using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial_script : MonoBehaviour {

	public Image imagetut;
	public Button next;
	public Button prev;
	int i=1,numimages=3;
	// Use this for initialization
	void Start () {
		imagetut.sprite=Resources.Load<Sprite>("tut"+i);	
		next.onClick.AddListener(nextClick);
		prev.onClick.AddListener(prevClick);
	}
	
	// Update is called once per frame
	public void prevClick() {
		if(i>1){
			i--;
			imagetut.sprite=Resources.Load<Sprite>("tut"+i);	
		}
	}
	public void nextClick() {
		if(i<numimages){
			i++;
			imagetut.sprite=Resources.Load<Sprite>("tut"+i);			
		}
	}
}


