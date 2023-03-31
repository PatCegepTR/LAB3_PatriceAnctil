using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionArrivee : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private Player _player;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _player = FindObjectOfType<Player>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;

        if(indexScene == 2)
        {
            if (collision.gameObject.tag == "Player")
            {
                int penalite = _gestionJeu.GetPointage();
                Debug.Log("Vous avez fini en : " + Time.time + " secondes");
                Debug.Log("Vous avez percuté " + penalite + " obstacles");

                float total = Time.time + penalite;
                Debug.Log("Le temps total est donc de " + total + " secondes");

                _player.FinPartie();
            }
        }
        else
        {
            //Charger la scène suivante
            SceneManager.LoadScene(indexScene + 1);
        }
        
    }

    

}
