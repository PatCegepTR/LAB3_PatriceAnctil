using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _vitesse = 500;
    [SerializeField] private float positionX = -46;
    [SerializeField] private float positionZ = -46;
    private bool _estActif = true;
    private Rigidbody _rb;

    // Méthodes privées
    private void Start()
    {
        // Position de départ du joueur
        transform.position = new Vector3(positionX, 0.01f, positionZ);
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_estActif)
        {
            MouvementsJoueur();
        }
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxisRaw("Horizontal");
        float positionZ = Input.GetAxisRaw("Vertical");

        //Mouvements personnage
        Vector3 direction = new Vector3(positionX, 0f, positionZ).normalized;
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;

        //Orientation personnage
        float anglePerso = Mathf.Atan2(positionX, positionZ) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, anglePerso, 0);
        
        
    }


    // Méthode publique
    public void FinPartie()
    {
        _estActif= false;
    }

}
