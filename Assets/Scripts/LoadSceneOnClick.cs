using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    // Methode om de "Main" sc�ne te laden
    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
