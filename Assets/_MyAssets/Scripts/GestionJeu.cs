using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    //Attributs
    private int _pointage;

    public int GetPointage()
    {
        return _pointage;
    }

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        _pointage = 0;
        Instructions();
    }

    private static void Instructions()
    {
        Debug.Log("*** Prison ***");
        Debug.Log("Rejoins ta femme à la cafétéria de la prison, prend la voiture pour rejoindre ton avion puis partez vers le mexique!!!");
        Debug.Log("Chaque obstacle ou policier qui sera touché entraine une pénalité");
    }

    // Méthodes publiques
    public void AugmenterPointage()
    {
        _pointage++;
    }


}
