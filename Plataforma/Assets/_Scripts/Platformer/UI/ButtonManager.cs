using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("Inicia un nuevo juego");
    }

    public void LoadGame()
    {
        Debug.Log("Carga un juego guardado");
    }

    public void Password()
    {
        Debug.Log("Ingerese la contraseña secreta");
    }

    public void Options()
    {
        Debug.Log("Opciones del juego");
    }
    
}
