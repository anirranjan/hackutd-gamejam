using UnityEngine;

public class Dracula : MonoBehaviour
{
    public float movementSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moves character without keyboard input
        transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);

        //determines if right or left arrow was pressed
        //var movement = Input.GetAxis("Horizontal");

        //moves the character along the x-axis
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
    }
}
