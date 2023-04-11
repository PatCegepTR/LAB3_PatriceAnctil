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
        if (SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }
    }

    // Méthodes publiques
    public void AugmenterPointage()
    {
        _pointage++;
        UIManager uiManager = FindObjectOfType<UIManager>();
        uiManager.ChangerPointage(_pointage);
    }

    public int GetPointage()
    {
        return _pointage;
    }

    public void SetTempsDepart()
    {
        _tempsDepart = Time.time;
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
