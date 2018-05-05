using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    // Variablen
    public float time = 0 ;
    public TextMesh textObject = GameObject.Find("").GetComponent<TextMesh>();
    float min = 0;
    float sek = 0;
    float x;
    float y;

    // am Anfand der Szene gleich Aufgabe 1 additiv laden
    public void LoadScenea()
	{	SceneManager.LoadScene ("Aufgabe1", LoadSceneMode.Additive);}

	void Start ()
    { LoadScenea ();}

    void FixedUpdate()
    {
        //aus Sekunden Minuten machen
        min = Mathf.Floor(time / 60);
        // von gesamter Zeit nur die Sekunden der angefangen Minute herausrechen (mit hilfe von Modulo)
        sek = Mathf.Round(60 - (time % 60));
        x = 14 - min;
        // Ausgabe auf 3D Textfeld
        // wenn kleiner als 10 dann = davor schreiben
        if (sek < 10)
        { textObject.text = x.ToString() + ":0" + sek.ToString(); }
        else
        { textObject.text = x.ToString() + ":" + sek.ToString(); }
        if (time > 900)
        {
            SceneManager.LoadScene("Lose", LoadSceneMode.Additive);
        }
        //Zeit hochzählen
        time = (Time.deltaTime + time);

        // wenn die zeit mehr als 15 min ist...
        if (time > 900)
        {
            SceneManager.UnloadSceneAsync("Aufgabe1");
            Lose();
        }
    }

    // ...läd die Verlieren Szene
    public void Lose()
    {
        SceneManager.LoadScene("Lose", LoadSceneMode.Additive);
    }
}



