using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{

    [SerializeField] private GameObject _menuInstructions = default;

    public void ChangerSceneSuivante()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scène en cours
        SceneManager.LoadScene(noScene + 1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }

    public void OuvrirInstructions()
    {
        _menuInstructions.SetActive(true);

    }

    public void FermerInstructions()
    {
        _menuInstructions.SetActive(false);

    }

}
