using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckParams : MonoBehaviour
{
    public GuestParams guest_params;

    public void SetDefaultState()
    {
        guest_params.warning = 0;
        guest_params.motherMem = 0;
        guest_params.tomatoNoodle = 0;
        guest_params.currentScene = 1;

        guest_params.email = false;
        guest_params.nameList = false;
        guest_params.seeShuLi = false;
        guest_params.randomSale = false;
        guest_params.motherRem = false;
        guest_params.catAlley = false;
        guest_params.insideStory = false;
        guest_params.knife = false;
    }

    public void AddWarning()
    {
        guest_params.warning += 1;
    }

    public void AddMotherMem()
    {
        guest_params.motherMem += 1;
    }

    public void AddTomatoNoodle()
    {
        guest_params.tomatoNoodle += 1;
    }

    public void CheckEmail()
    {
        guest_params.email = true;
    }

    public void CheckNameList()
    {
        guest_params.nameList = true;
    }

    public void CheckShuLi()
    {
        guest_params.seeShuLi = true;
    }

    public void CheckRadomSale()
    {
        guest_params.randomSale = true;

    }

    public void CheckMotherRem()
    {
        guest_params.motherRem = true;
    }

    public void CheckCatAlley()
    {
        guest_params.catAlley = true;
    }

    public void CheckInsideStory()
    {
        guest_params.insideStory = true;
    }

    public void CheckKnife()
    {
        guest_params.knife = true;
    }

    public void CheckCurrentScene()
    {
        guest_params.currentScene = SceneManager.GetActiveScene().buildIndex;
    }
}
