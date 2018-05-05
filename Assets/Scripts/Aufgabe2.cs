using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;
public class Aufgabe2 : MonoBehaviour
{
    bool isSnappedDe;
    bool isSnappedVe;
    bool isSnappedCa;
    bool isSnappedAt;
    bool isSnappedAluMi;
    public bool finishAt;
    public bool finishDe;
    public bool finishVe;
    public bool finishCa;
    public bool finishAluMi;
    public Material Stern_Material;



    public void denebsnapped()
    {
        isSnappedDe = true;
    }
    public void vegasnapped()
    {
        isSnappedVe = true;
    }
    public void capellasnapped()
    {
        isSnappedCa = true;
    }

    public void atairsnapped()
    {
        isSnappedAt = true;
    }
    public void alkormizarsnapped()
    {
        isSnappedAluMi = true;
    }

   void Start()
    {
        //Material von Stern ansprechen und einer Variable zuweisen
        Stern_Material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        //prüfen, ob Planeten an richtiger Stelle gesnappt
        if (isSnappedAt == true)
        {finishAt = true;}
        if (isSnappedDe == true)
        { finishDe = true; }
        if (isSnappedVe == true)
        { finishVe = true; }
        if (isSnappedAluMi == true)
        { finishAluMi = true; }
        if (isSnappedCa == true)
        { finishCa = true; }
    }
}



