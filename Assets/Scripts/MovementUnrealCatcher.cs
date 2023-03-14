using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;
using System;

public class MovementUnrealCatcher : MonoBehaviour
{
    public float speed = 10f;

    public GameObject textMeshProGO;
    TextMeshProUGUI textMeshPro;

    private AudioSource audioSource;
    public AudioClip deathSound;
    public AudioClip gainPointsSound;

    private float Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = textMeshProGO.GetComponent<TextMeshProUGUI>();
        audioSource = GetComponent<AudioSource>();
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        transform.Translate(xMove * speed, 0, 0);

        //set new variable ScoreString to "Score: " + score
        string ScoreString = "Score: " + Score.ToString();

        textMeshPro.SetText(ScoreString);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the tag of the colliding object is equal to "ChangeScene" or "GainPoints" or "EndGame" then destroy the object
        if (collision.gameObject.tag == "ChangeScene" || collision.gameObject.tag == "GainPoints" || collision.gameObject.tag == "EndGame")
        {
            //if the tag is equal to "GainPoints" then add 1 to the score
            if (collision.gameObject.tag == "GainPoints")
            {
                Score++;
                audioSource.PlayOneShot(gainPointsSound, 0.8F);
            }
            //if the tag is equal to "EndGame" destroy the self
            if (collision.gameObject.tag == "EndGame") { 
            
                //Destroy(gameObject);
                speed = 0;
                Debug.Log("EndGame");
                audioSource.PlayOneShot(deathSound, 0.7F);
            }
            //if the tag is equal to "ChangeScene" type to console "ChangeScene"
            if (collision.gameObject.tag == "ChangeScene")
            {
                Debug.Log("Theme Changed");
            }
            Destroy(collision.gameObject);
        }

    }
}
