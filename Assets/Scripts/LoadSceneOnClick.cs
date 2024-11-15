using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    // Methode om de "Main" scène te laden
    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
