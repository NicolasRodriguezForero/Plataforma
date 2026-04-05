using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAndPos : MonoBehaviour
{
    // Variable Declaration
    private SpriteRenderer renderer;
    public GameObject yellowcube;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        transform.position = yellowcube.transform.position;
        ChangeColor();
        text();
    }

    public void text()
    {
        Color color = renderer.color;
        string colorName = "";

        // Use only the 5 color names defined in ChangeColorRandom
        if (color == Color.red)
            colorName = "red";
        else if (color == Color.green)
            colorName = "green";
        else if (color == Color.blue)
            colorName = "blue";
        else if (color == Color.yellow)
            colorName = "yellow";
        else if (color == Color.magenta)
            colorName = "magenta";
        else
            colorName = "unknown";

        Debug.Log(string.Format("The position of the little circle is: ({0},{1},{2}), and his color is {3}", transform.position.x, transform.position.y, transform.position.z, colorName));
    }

    // Change the color of the object to a random color
    public void ChangeColorRandom()
    {
        Color[] colors = { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta };
        renderer.color = colors[Random.Range(0, colors.Length)];
    }

    // Change the color of the object to a specific color
    public void ChangeColor()
    {
        renderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColorRandom();
            text();
        }
    }
}
