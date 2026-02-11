using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maths : MonoBehaviour
{
    // Variable Declaration
    [Header("Numeros")]
    public int a;
    public int b;
    public int c;
    public string textname;
    private int result;

    // Start is called before the first frame update
    void Start()
    {
        Sum();
        Hypotenuse();
        BasicEquation();
    }

    // Addition of two numbers
    public void Sum()
    {
        result = a + b;
        Debug.Log(string.Format("The result of the addition is: {0}", result));
    }

    // hypotenuse of a right triangle
    public void Hypotenuse()
    {
        float hypotenuse = Mathf.Sqrt(Mathf.Pow(a, 2) + Mathf.Pow(b, 2));
        Debug.Log(string.Format("The result of the hypotenuse is: {0}", hypotenuse));
    }

    //  Basic equation
    public void BasicEquation()
    {
        float equation = ((a+b)*(b-c))/2;
        Debug.Log(string.Format("The result of the basic equation is: {0}", equation));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
