﻿using System;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    void OnCollisionEnter2D(UnityEngine.Collision2D collisionInfo)
    {
        Debug.Log(transform.localScale.x);
        if (transform.localScale.x < 0)
        {
            transform.localScale += new Vector3(-.2f, .2f);
            Destroy(collisionInfo.gameObject);
            Debug.Log(collisionInfo.collider);
            Debug.Log(collisionInfo);

        }
        else if (transform.localScale.x > 0)
        {
            transform.localScale += new Vector3(.2f, .2f);
            Destroy(collisionInfo.gameObject);
        }
        //transform.localScale += new Vector3(Math.Abs(1.01f), 1.01f);
        //transform.localScale += new Vector3(1.01f, 1.01f);
        Debug.Log("hit something!");
    }
}
