using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Döndürme : MonoBehaviour
{
    
    public float speed;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, speed) * Time.fixedDeltaTime);
    }
}
