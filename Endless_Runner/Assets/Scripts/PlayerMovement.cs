using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed = 2;
    public float horizontalSpeed = 6f; // Update is called once per frame
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
    public float MaxSpeed= 5.5f;
    public float MinSpeed=3f;
    public float MaxHorizontalSpeed = 8f;
    public float MinHorizontalSpeed = 6f;
    public int currentScore = 0;
    public int highScore = 0;
    private float startZ;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        startZ=gameObject.transform.position.z;
    }
    private void CheckForHighScore()
    {
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore); // Save new high score
            PlayerPrefs.Save(); // Optional: explicitly save the PlayerPrefs
        }
    }

    public int GetHighScore()
    {
        return highScore;
    }

    public void ResetCurrentScore()
    {
        currentScore = 0; // Reset current score when needed
    }

    void Update()
    {
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime);
                
            }
        } 
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime );
            }
        }
        currentScore=(int)(transform.position.z-startZ);
        CheckForHighScore();   
        playerSpeed = Mathf.Clamp(playerSpeed*1.0001f, MinSpeed, MaxSpeed);
        horizontalSpeed = Mathf.Clamp(horizontalSpeed*1.0001f, MinHorizontalSpeed, MaxHorizontalSpeed);
    }
}