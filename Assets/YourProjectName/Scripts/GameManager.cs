﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Text scoreText;
    float score;
    [SerializeField]
    Image[] ShotLights;
    
    // Update is called once per frame
    void Update()
    {
        score = Time.timeSinceLevelLoad * 5;
        scoreText.text = string.Format("Score: {0:0.00}",(score));        
    }
    public float GetScore()
    {
        return score;
    }

    public void OnPlayerDeath()
    {
        PlayerPrefs.SetFloat("score", GetScore());
        PlayerPrefs.Save();
        SceneManager.LoadScene("GameOver");
    }

    public void ToggleLight(int lightIndex)
    {
        if(lightIndex < ShotLights.Length)
        {
            for (int i = 0; i < lightIndex; i++)
            {
                Color lightColor = ShotLights[i].color;
                if (lightColor.a == 0.0f)
                {
                    lightColor.a = 1.0f;
                }
                else
                {
                    lightColor.a = 0.0f;
                }
                ShotLights[i].color = lightColor;
            }
        }
    }
}
