using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFallingObjects : MonoBehaviour
{
    private Collider2D fallingObjectCollider;
    // Start is called before the first frame update
    void Start()
    {
        fallingObjectCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //on trigger destroy colliding objects if the tag is equal to "fallingObject"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ChangeScene" || collision.gameObject.tag == "GainPoints" || collision.gameObject.tag == "EndGame")
        {
            Destroy(collision.gameObject);
        }
    }
}
