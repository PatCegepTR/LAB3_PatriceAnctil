using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GestionJeu : MonoBehaviour
{
    //Attributs
    private int _pointage;
    private float _tempsFinal = 0;
    private float _tempsDepart = 0;

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
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }

    //private static void Instructions()
    //{
    //    Debug.Log("*** Prison ***");
    //    Debug.Log("Rejoins ta femme à la cafétéria de la prison, prend la voiture pour rejoindre ton avion puis partez vers le mexique!!!");
    //    Debug.Log("Chaque obstacle ou policier qui sera touché entraine une pénalité");
    //}


    // Méthodes publiques
    public void AugmenterPointage()
    {
        _pointage++;
        UIManager uiManager = FindObjectOfType<UIManager>();
        uiManager.ChangerPointage(_pointage);
    }

    // Accesseur qui retourne la valeur de l'attribut pointage
    public int GetPointage()
    {
        return _pointage;
    }

    public float GetTempsDepart()
    {
        return _tempsDepart;
    }


    public void SetTempsFinal(float p_tempFinal)
    {
        _tempsFinal = p_tempFinal - _tempsDepart;
    }

    public float GetTempsFinal()
    {
        return _tempsFinal;
    }


}
