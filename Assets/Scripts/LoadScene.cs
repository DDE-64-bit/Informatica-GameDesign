using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{


    public void TakeDamage(float amount)
    {
        SceneManager.LoadScene("Main");
    }

}
