﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.localScale.y);
        scoreText.text = player.localScale.z.ToString("0");
        
    }
}
