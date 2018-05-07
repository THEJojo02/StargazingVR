using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    // Variablen
    public float time = 0 ;
	public TextMesh textObject;// = GetComponent<TextMesh>();
    float min = 0;
    float sek = 0;
    float x;
    float y;
	public Light Licht;
	public AudioSource Sound;
	public AudioSource Lawine;
	bool zulangsam;
	public float a;

    // am Anfand der Szene gleich Aufgabe 1 additiv laden
    public void LoadScenea()
	{	SceneManager.LoadScene ("Aufgabe1", LoadSceneMode.Additive);}

	void Start ()
    { LoadScenea ();}

    void FixedUpdate()
    {
        //Sekunden in Minuten umrechnen
        min = Mathf.Floor(time / 60);
        // von gesamter Zeit nur die Sekunden der angefangen Minute herausrechen (mithilfe von Modulo)
        sek = Mathf.Round(60 - (time % 60));
        x = 14 - min;
        // Ausgabe auf 3D Textfeld
        // wenn kleiner als 10 dann 0 davor schreiben
        if (sek < 10)
        { textObject.text = x.ToString() + ":0" + sek.ToString(); }
        else
        { textObject.text = x.ToString() + ":" + sek.ToString(); }
        
      
        //Zeit hochzählen
        time = (Time.deltaTime + time);
		// wenn die zeit mehr als 15 min ist...
		if (time > 900)
		{	a= a+1;
			if (a == 1) {
			Lose ();
			}
		}
	}

    // ...lädt die Verlieren Szene
    public void Lose ()
	{ 	
			SceneManager.LoadScene ("Lose", LoadSceneMode.Additive);
			if (time > 1) 
		{
				Lawine.Play ();
				Licht.intensity = 0.5f * 0;
				Sound.Stop ();
		}
    
	}
}



