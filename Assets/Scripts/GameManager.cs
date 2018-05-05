using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public float time = 0 ;
    public TextMesh textObject = GameObject.Find("").GetComponent<TextMesh>();
    float min = 0;
    float sek = 0;
    float x;
    float y;

    public void LoadScenea()
	{
		SceneManager.LoadScene ("Aufgabe1", LoadSceneMode.Additive);
	}

	void Start () {
		LoadScenea ();
	}

    void FixedUpdate()
    {
        min = Mathf.Floor(time / 60);
        sek = Mathf.Round(60 - (time % 60));
        x = 14 - min;
        if (sek < 10)
        { textObject.text = x.ToString() + ":0" + sek.ToString(); }
        else
        { textObject.text = x.ToString() + ":" + sek.ToString(); }
        if (time > 900)
        {
            SceneManager.LoadScene("Lose", LoadSceneMode.Additive);
        }
        time = (Time.deltaTime + time);
    }


}
