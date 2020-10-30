using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemocMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    bool change = true;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (change)
        {
            movementRight();
        }
        else
        {
            movementLeft();
        }
        if (transform.position.x >= 262f)
        {
            change = false;
            spriteRenderer.flipX = true;
        }
        if (transform.position.x <= 219f)
        {
            change = true;
            spriteRenderer.flipX = false;
        }


    }

    void movementRight()
    {
        transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
    }

    void movementLeft()
    {
        transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
    }
}
