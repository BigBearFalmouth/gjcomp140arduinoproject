﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }

        if (collision.gameObject.tag == "Gate")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "Barrier")
        {
            
            Destroy(gameObject);

        }
    }

}
