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
        if (collision.gameObject.tag == "Player")  
        {
            int indexScene = SceneManager.GetActiveScene().buildIndex; 
            if (indexScene == (SceneManager.sceneCountInBuildSettings - 2)) 
            {
                _gestionJeu.SetTempsFinal(Time.time);
                SceneManager.LoadScene(indexScene + 1);
            }
            else
            {
                SceneManager.LoadScene(indexScene + 1);
            }
        }
    }

    

}
