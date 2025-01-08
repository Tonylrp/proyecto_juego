using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void NuevaPartida()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void CargarPartida()
    {
        Debug.Log("Cargar partida a�n no implementado.");
    }

    public void Opciones()
    {
        Debug.Log("Opciones a�n no implementado.");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir del juego.");
    }
}

