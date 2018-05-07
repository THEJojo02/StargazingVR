using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {

    //Variablen für Aufgabe1
    bool finishedsonne;
    bool finishedneptun;
    bool finishedmerkur;
    bool finishedvenus;
    bool finishederde;
    bool finishedmars;
    bool finishedjupiter;
    bool finishedsaturn;
    bool finisheduranus;
    public GameObject Kugel;
    public GameObject Pfeil;
    public GameObject sonne;
    public GameObject neptun;
    public GameObject merkur;
    public GameObject venus;
    public GameObject erde;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public bool Aufgabe1;

    //Variablen für Aufgabe2
    bool finishedDeneb;
    bool finishedVega;
    bool finishedCapella;
    bool finishedAtair;
    bool finishedAluMi;
    public GameObject Deneb;
    public GameObject Vega;
    public GameObject Capella;
    public GameObject Atair;
    public GameObject AluMi;
    public bool Aufgabe2;

    //Variablen für Aufgabe3
    bool finishedSp1;
    bool finishedSp2;
    bool finishedLi;
    public GameObject Spiegel1;
    public GameObject Spiegel2;
    public GameObject Linse;
    public bool Aufgabe3;

    // Update wird einmal pro Bild geladen
    void Update() {

        //Aufgabe 1
		//überprüft Planeten, wenn sie ungleich nichts sind, wird mit dem anderen Skript geprüft ob sie gesnappt sind 
        if (sonne != null) {
            finishedsonne = sonne.GetComponent<Rotation>().finishsun;
        }
        if (neptun != null) {
            finishedneptun = neptun.GetComponent<Rotation>().finishn; }

        if (merkur != null) {
            finishedmerkur = merkur.GetComponent<Rotation>().finishmer; }

        if (venus != null) {
            finishedvenus = venus.GetComponent<Rotation>().finishve; }

        if (erde != null) {
            finishederde = erde.GetComponent<Rotation>().finisher; }

        if (mars != null) {
            finishedmars = mars.GetComponent<Rotation>().finishmar; }

        if (jupiter != null) {
            finishedjupiter = jupiter.GetComponent<Rotation>().finishju; }

        if (saturn != null) {
            finishedsaturn = saturn.GetComponent<Rotation>().finishsa; }

        if (uranus != null) {
            finisheduranus = uranus.GetComponent<Rotation>().finishur; }


        // wenn alle richtig gesnappt -> Aufgabe 1 gelöst
        if ((finishedsonne == true) && (finishedneptun == true) && (finishedsaturn == true) && (finishedjupiter == true)
            && (finishedvenus == true) && (finishederde == true)
            && (finishedmars == true) && (finishedmerkur == true) && (finisheduranus == true))
        {
            // lädt Button zum Szenenwechsel
            Pfeil.SetActive(true);
            Kugel.SetActive(true);
            Aufgabe1 = true;
        }

        // Aufgabe 2
        //überprüft Sterne, wenn sie ungleich nichts sind, wird geprüft ob sie gesnappt sind mit dem andren Skript
        if (Deneb != null)
        { finishedDeneb = Deneb.GetComponent<Aufgabe2>().finishDe; }
        if (Vega != null)
        { finishedVega = Vega.GetComponent<Aufgabe2>().finishVe; }
        if (Capella != null)
        { finishedCapella = Capella.GetComponent<Aufgabe2>().finishCa; }
        if (Atair != null)
        { finishedAtair = Atair.GetComponent<Aufgabe2>().finishAt; }
        if (AluMi != null)
        { finishedAluMi = AluMi.GetComponent<Aufgabe2>().finishAluMi; }


        if ((finishedAtair == true) && (finishedCapella == true) && (finishedAluMi == true)
            && (finishedDeneb == true) && (finishedVega == true))
        {
            // lädt Button zum Szenenwechsel
            Pfeil.SetActive(true);
            Kugel.SetActive(true);
			//Sterne werden grün, wenn sie an richtiger Stelle sind
            Deneb.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
            Vega.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
            Capella.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
            Atair.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
            AluMi.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
            Aufgabe2 = true;
        }


    // Aufgabe3
        if (Spiegel1 != null)
        { finishedSp1 = Spiegel1.GetComponent<Aufgabe3>().finishSp1; }
        if (Spiegel1 != null)
        { finishedSp2 = Spiegel2.GetComponent<Aufgabe3>().finishSp2; }
        if (Spiegel1 != null)
        { finishedLi = Linse.GetComponent<Aufgabe3>().finishLi; }

		/*if ((finishedSp1 == true) && (finishedLi == true))
		{
			Debug.Log ("Sp1ihj");
			Spiegel1.GetComponent<Aufgabe3>().mMaterial.color = Color.green;
			Linse.GetComponent<Aufgabe3>().mMaterial.color = Color.green;
		}*/

        if ((finishedSp1 == true) && (finishedSp2 == true ) && (finishedLi == true))
        {
            Spiegel1.GetComponent<Aufgabe3>().mMaterial.color = Color.green;
            Spiegel2.GetComponent<Aufgabe3>().mMaterial.color = Color.green;
            Linse.GetComponent<Aufgabe3>().mMaterial.color = Color.green;
            Aufgabe3 = true;
            NextTask();
        }
    }


    // für Szenenwechsel

    // Entlädt die 1.Aufgabe,2.Aufgabe oder 3.Aufgabe und ruft die andere Funktion auf
    public void NextTask()
    {
        if  (Aufgabe1 == true)
        {
            SceneManager.UnloadSceneAsync("Aufgabe1");
            LoadNextScene();
           
        } else if (Aufgabe2 == true)
        {
            SceneManager.UnloadSceneAsync("Aufgabe2");
            LoadNextScene();
        }
        else if (Aufgabe3 == true)
        {
            SceneManager.UnloadSceneAsync("Aufgabe3");
            LoadNextScene();
        }
    }
	public void Menu(){
		SceneManager.LoadScene ("Outro",LoadSceneMode.Single);
	}
    // lädt die 2.Aufgabe,3.Aufgabe oder den Schluss wieder additiv
    public void LoadNextScene()
    {
        if (Aufgabe1 == true)
        {
            SceneManager.LoadScene("Aufgabe2", LoadSceneMode.Additive);
        }
        else if (Aufgabe2 == true)
        {
            SceneManager.LoadScene("Aufgabe3", LoadSceneMode.Additive);
        }
        else if (Aufgabe3 == true)
        {
            SceneManager.LoadScene("Win", LoadSceneMode.Additive);
        }

    }
}
     



