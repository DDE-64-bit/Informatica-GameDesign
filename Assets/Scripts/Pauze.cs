using UnityEngine;
using UnityEngine.SceneManagement;

public class Pauze : MonoBehaviour
{
    public GameObject pauseMenuUI; // Sleep hier het pauzemenu paneel heen in de Inspector
    private bool isPaused = false;

    void Update()
    {
        // Check of de Escape-toets is ingedrukt
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Pauzemenu verbergen
        Time.timeScale = 1f; // Spel hervatten
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true); // Pauzemenu tonen
        Time.timeScale = 0f; // Spel pauzeren
        isPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit(); // Werkt alleen in een gebuild spel, niet in de editor
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Tijdschaling resetten zodat de nieuwe scène niet in pauzestand start
        SceneManager.LoadScene(0); // Laad de eerste scène (meestal de startscene)
    }
}
