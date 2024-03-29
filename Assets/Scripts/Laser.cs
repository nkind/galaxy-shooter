﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;

    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        // If laser is off screen destroy it
        if (transform.position.y > 8.0f)
        {
            Destroy(this.gameObject);

            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
        } 
    }
}
