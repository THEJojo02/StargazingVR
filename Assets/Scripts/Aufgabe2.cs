using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;
public class Aufgabe2 : MonoBehaviour
{

    public GameObject Platz;
    bool isSnappedDe;
    bool isSnappedVe;
    bool isSnappedCa;
    bool isSnappedAt;
    bool isSnappedAluMi;
	bool task2finished;

    Material m_Material;

    void Start()
    {
        //Fetch the Material from the Renderer of the GameObject
        m_Material = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
    }


    void Update()
    {

        /*GameObject snapDe = GameObject.Find("DenebS");
        isSnappedDe = snapDe.GetComponent<VRTK_SnapDropZone>().isSnapped;

        GameObject snapVe = GameObject.Find("VegaS");
        isSnappedVe = snapVe.GetComponent<VRTK_SnapDropZone>().isSnapped;

        GameObject snapCa = GameObject.Find("CapellaS");
        isSnappedCa = snapCa.GetComponent<VRTK_SnapDropZone>().isSnapped;

        GameObject snapAt = GameObject.Find("AtairS");
        isSnappedAt = snapAt.GetComponent<VRTK_SnapDropZone>().isSnapped;

        GameObject snapAluMi = GameObject.Find("AluMiS");
        isSnappedAluMi = snapAluMi.GetComponent<VRTK_SnapDropZone>().isSnapped;*/


        //isSnapped(bool) aus dem Script der SnapDropZone

        //prüfen, ob Planeten an richtiger Stelle


        if (isSnappedDe == true && isSnappedVe == true && isSnappedCa == true && isSnappedAt == true && isSnappedAluMi == true)
        {

            m_Material.color = Color.green;
            //werden grün, wenn Sterne an richtiger Stelle
			task2finished = true;

        }

		if (task2finished == true) {
			ModeSelect ();
		}

    }

	public void denebsnapped(){
		isSnappedDe = true;
	}
	public void vegasnapped(){
		isSnappedVe = true;
	}
	public void capellasnapped(){
		isSnappedCa = true;
	}

	public void atairsnapped(){
		isSnappedAt = true;
	}
	public void alkormizarsnapped(){
		isSnappedAluMi = true;
	}
	public float delay = 2f;
	public void ModeSelect(){
		StartCoroutine ("Wait");
	}
	IEnumerator Wait(){
		yield return new WaitForSeconds (10);
		NextTask ();
	}

	public void LoadNextScene()
	{
		SceneManager.LoadScene ("Menu", LoadSceneMode.Additive);
	}

	public void NextTask()
	{	
		SceneManager.UnloadScene ("Aufgabe2");
		LoadNextScene();
	}
}
//}


