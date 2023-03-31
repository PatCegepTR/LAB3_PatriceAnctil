using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePneu : MonoBehaviour
{
    
    [SerializeField] private float _vitesse = 15;
    private Vector3 Offset = new Vector3(0f, 0f, 20f); 

    private int direction = 1;

    void Update()
    {

        if (transform.position.z >= -29)
        {
            direction = -1;
        }
        else if (transform.position.z <= -39)
        {
            direction = 1;
        }

        transform.position = transform.position + new Vector3(0f, 0f, _vitesse * direction * Time.deltaTime);




    }
}
