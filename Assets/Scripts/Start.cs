using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void startScene()
    {
        SceneManager.LoadScene("Game");
    }
}
