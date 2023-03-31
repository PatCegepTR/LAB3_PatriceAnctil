using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private bool _toucher = false;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (!_toucher)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                Debug.Log("Touche!!!");
                _toucher = true;
                _gestionJeu.AugmenterPointage();
            }
        }
    }
}
