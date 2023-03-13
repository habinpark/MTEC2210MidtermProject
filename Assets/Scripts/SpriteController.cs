using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite leftSprite;
    public Sprite rightSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput < 0)
        {
            spriteRenderer.sprite = leftSprite;
        }
        else if (horizontalInput > 0)
        {
            spriteRenderer.sprite = rightSprite;
        }
    }
}
