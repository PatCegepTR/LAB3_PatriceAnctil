using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _vitesseRotatonY = 0.2f;


    void Update()
    {
        transform.Rotate(0f, _vitesseRotatonY, 0f);
    }
}
