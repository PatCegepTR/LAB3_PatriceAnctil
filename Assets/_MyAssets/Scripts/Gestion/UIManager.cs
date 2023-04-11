using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtHits = default;
    [SerializeField] private TMP_Text _txtTime = default;
    [SerializeField] private GameObject _menuPause = default;
    private bool _enPause;
    private GestionJeu _gestionJeu;


    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _txtHits.text = "Hits : " + _gestionJeu.GetPointage();
        Time.timeScale = 1;
        _enPause = false;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            _gestionJeu.SetTempsDepart();
        }
    }


    private void Update()
    {
        float temps = Time.time - _gestionJeu.GetTempsDepart();
        _txtTime.text = "Time : " + temps.ToString("f2");
        GestionPause();
    }

    private void GestionPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            _menuPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _enPause)
        {
            EnleverPause();
        }
    }

    public void ChangerPointage(int p_pointage)
    {
        _txtHits.text = "Hits : " + p_pointage.ToString();
    }

    public void EnleverPause()
    {
        _menuPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false;
    }
}
