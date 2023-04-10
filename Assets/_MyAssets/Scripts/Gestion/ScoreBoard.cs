using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTime = default;
    [SerializeField] private TMP_Text _txtTotalHit = default;
    [SerializeField] private TMP_Text _txtTotal = default;
    private GestionJeu _gestionJeu;

    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _txtTime.text = "Time : " + _gestionJeu.GetTempsFinal().ToString("f2") + " sec.";
        _txtTotalHit.text = "Hit(s) : " + _gestionJeu.GetPointage().ToString();
        float pointageTotal = _gestionJeu.GetTempsFinal() + _gestionJeu.GetPointage();
        _txtTotal.text = "Score : " + pointageTotal.ToString("f2") + " sec.";
    }
}
