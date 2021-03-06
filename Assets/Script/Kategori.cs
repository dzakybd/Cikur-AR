﻿using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class Kategori : MonoBehaviour {

	public GameObject katPrefab;
	public MenuManager menu;
	public Soal soal;

	void Start () {

		RectTransform rect = gameObject.GetComponent<RectTransform> ();


		string filePath = Application.streamingAssetsPath+"/";
		Debug.Log(filePath);
		// DirectoryInfo dir = new DirectoryInfo (filePath);
		//FileInfo[] files = dir.GetFiles ("*.json");
		//Debug.Log(files.Length);
		//GameObject.Find ("Alamat").GetComponent<Text> ().text = files.Length.ToString();

		TextAsset[] files = Resources.LoadAll<TextAsset> ("");
		foreach(TextAsset file in files){
			Debug.Log(files.Length);
			GameObject kat = Instantiate(katPrefab) as GameObject;
			kat.name = Path.GetFileNameWithoutExtension(file.name).ToString();
			kat.transform.SetParent(GameObject.Find("Kategori/Panel/Scroll/KategoriC").GetComponent<Transform>());
            string katName = kat.name;
            kat.GetComponentInChildren<Text>().text = kat.name + "(Tertinggi: " + PlayerPrefs.GetInt(kat.name) + ")";
			kat.GetComponent<Button>().onClick.AddListener(() => OnClick(katName));
            kat.GetComponent<Button>().onClick.AddListener(() => menu.ShowMenu(GameObject.Find("Canvas/Soal").GetComponent<Menu>()));

		}
		rect.sizeDelta = new Vector2 (rect.sizeDelta.x, (rect.sizeDelta.y/6)* files.Length);
	
	}

	public void OnClick(string kategori){
		soal.SoalBegin (kategori);
		Debug.Log(kategori);
	}

}
