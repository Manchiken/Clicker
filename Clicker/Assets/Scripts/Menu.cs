using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayClick()
    {
        SceneManager.LoadScene("Game");
    }
 
}
