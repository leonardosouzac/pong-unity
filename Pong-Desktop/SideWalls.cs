﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    private Transform tr2D;

    void Start()
    {
        tr2D = GetComponent<Transform>();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Ball")
        {
            string wallName = tr2D.name;
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
            GetComponent<AudioSource>().Play();
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("ResetBall");
        }
    }
}
