using UnityEngine;
using UnityEngine.SceneManagement;

public class MyViewModel : MonoBehaviour
{

    void Awake()
    {

    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}