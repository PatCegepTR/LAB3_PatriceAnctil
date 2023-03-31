using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAigle : MonoBehaviour
{
    [SerializeField] private float _vitesse = 40;
    private Vector3 Offset = new Vector3(0f, 0f, 20f);
    private float positionZ;
    private float positionY;
    private float max, min;
    private int direction = 1;

    void Start()
    {
        positionY = transform.position.y;
        positionZ = transform.position.z;
        max = positionZ + 60;
        min = positionZ - 30;
    }

    void Update()
    {

        if (transform.position.x >= max)
        {
            direction = -1;
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        else if (transform.position.x <= min)
        {
            direction = 1;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        transform.position = transform.position + new Vector3(_vitesse * direction * Time.deltaTime, 0f, 0f);





    }
}
