using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Health : MonoBehaviour
{
    public float CurrentHealth = 100f;
    public float fadeDuration = 1.5f; // Hoe lang het duurt om te vervagen
    public bool loadScene = false;
    public string scene = "";

    private Renderer[] renderers;
    private bool isDying = false;

    void Start()
    {
        // Alle renderers van het object opslaan, zodat we de transparantie kunnen aanpassen
        renderers = GetComponentsInChildren<Renderer>();
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
        if (loadScene)
        {
            SceneManager.LoadScene(scene);

            Cursor.visible = true; // Zorg dat de cursor zichtbaar is
            Cursor.lockState = CursorLockMode.None; // Zorg dat de cursor niet vaststaat
        }
        else if (CurrentHealth <= 0 && !isDying)
        {
            isDying = true;
            Destroy(gameObject);
        }
    }

}
