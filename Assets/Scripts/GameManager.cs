using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public float time = 0 ;

    public void LoadScenea()
	{
		SceneManager.LoadScene ("Aufgabe1", LoadSceneMode.Additive);
	}

	void Start () {
		LoadScenea ();
	}

   void FixedUpdate()
    {
        if (time > 900)
        {
         SceneManager.LoadScene("Lose", LoadSceneMode.Additive);
        }
        time = (Time.deltaTime + time);
    }


}
