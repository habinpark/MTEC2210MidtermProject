using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Movement : MonoBehaviour
{
    public float speed = 10f;
    public string color;

    public GameObject textMeshProGO;
    TextMeshProUGUI textMeshPro;

    private SpriteRenderer SR;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        color = "White";
        textMeshPro = textMeshProGO.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        transform.Translate(xMove * speed, 0, 0);

        if (Input.GetKeyDown("space"))
        {
            float randomNumber = Random.Range(0, 5);
            if(randomNumber == 0)
            {
                SR.color = Color.red;
                color = "Red";
            }
            if (randomNumber == 1)
            {
                SR.color = Color.blue;
                color = "Blue";
            }
            if (randomNumber == 2)
            {
                SR.color = Color.magenta;
                color = "Magenta";
            }
            if (randomNumber == 3)
            {
                SR.color = Color.green;
                color = "Green";
            }
            if (randomNumber == 4)
            {
                SR.color = Color.yellow;
                color = "Yellow";
            }

        }
        if(Input.GetKeyUp("space"))
        {
            SR.color = Color.white;
            color = "White";
        }
        print(textMeshPro.name);
        textMeshPro.SetText(color);
    }
}
