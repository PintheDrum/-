using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoSave : MonoBehaviour
{
    public Player player;

    public void GoToSave()
    {
        player.currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(85);

    }
}
