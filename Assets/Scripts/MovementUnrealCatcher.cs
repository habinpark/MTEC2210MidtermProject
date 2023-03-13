using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;

public class MovementUnrealCatcher : MonoBehaviour
{
    public float speed = 10f;

    public GameObject textMeshProGO;
    TextMeshProUGUI textMeshPro;

    private float Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = textMeshProGO.GetComponent<TextMeshProUGUI>();
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        transform.Translate(xMove * speed, 0, 0);

        //set teg textmeshpro to score
        textMeshPro.SetText(Score.ToString());
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
            }
            //if the tag is equal to "EndGame" destroy the self
            if (collision.gameObject.tag == "EndGame")
            {
                Destroy(gameObject);
            }
            //if the tag is equal to "ChangeScene" type to console "ChangeScene"
            if (collision.gameObject.tag == "ChangeScene")
            {
                Debug.Log("ChangeScene");
            }
            Destroy(collision.gameObject);
        }

    }
}
