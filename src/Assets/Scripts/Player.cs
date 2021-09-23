using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float movementSpeed = 450f;
    private float movement = 0f;

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * CameraRotator.RotationRate);
    }

    //Study this bit
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -movementSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManager.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
