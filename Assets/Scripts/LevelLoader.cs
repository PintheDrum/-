using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;


    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            LoadNextLevel(1);
        }
    }

    public void LoadNextLevel(int choiceEffect)
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + choiceEffect));
    }

    IEnumerator LoadLevel(int levelIndexx)
    {
        //Play crossfade animation
        transition.SetTrigger("Fading");

        //Wait animation end
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(levelIndexx);
    }
}
