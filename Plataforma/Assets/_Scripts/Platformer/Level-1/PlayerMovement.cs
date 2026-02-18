using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Se declara la variable para acceder al script OldInput.
    private OldInput _oldInput;
    // Se declara la variable para la velocidad de movimiento.
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _oldInput = GetComponent<OldInput>();        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    // Método para mover al jugador. Multiplicar el vector por el tiempo para que se mueva de manera suave.
    public void Movement()
    {
        transform.Translate(Vector3.right * _oldInput.horizontal * speed * Time.deltaTime);
    }
}
