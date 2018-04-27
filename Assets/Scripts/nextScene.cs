using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {

	public bool finishedtask1;
	public GameObject Kugel;
	public GameObject Pfeil;
	// Update is called once per frame
	void Update () {

		GameObject sonne = GameObject.Find ("Sonne");
		finishedtask1 = sonne.GetComponent<Rotation> ().task1finished; 
		
		if (finishedtask1==true){
			Debug.Log ("snapped");
			Pfeil.SetActive(true);
			Kugel.SetActive(true);

		}
		
	}
	public void LoadNextScene()
	{
		SceneManager.LoadScene ("Aufgabe2", LoadSceneMode.Additive);
	}

	public void NextTask()
	{	
		SceneManager.UnloadScene ("Aufgabe1");
		LoadNextScene();
	}
}
