using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavingController : MonoBehaviour
{
    public GuestParams guest;
    public Player player;

    [SerializeField] private GameObject panelA;
    [SerializeField] private GameObject panel_savedA;
    //[SerializeField] private GameObject warning_panelA;
    [SerializeField] private GameObject panelB;
    [SerializeField] private GameObject panel_savedB;
    //[SerializeField] private GameObject warning_panelB;
    //[SerializeField] private GameObject panelC;
    //[SerializeField] private GameObject panel_savedC;
    ////[SerializeField] private GameObject warning_panelC;
    //[SerializeField] private GameObject panelD;
    //[SerializeField] private GameObject panel_savedD;
    ////[SerializeField] private GameObject warning_panelD;

    private void Start()
    {
        if (player.isSavedA)
        {
            panelA.SetActive(false);
            panel_savedA.SetActive(true);
        }
        else
        {
            panelA.SetActive(true);
            panel_savedA.SetActive(false);
        }

        if (player.isSavedB)
        {
            panelB.SetActive(false);
            panel_savedB.SetActive(true);
        }
        else
        {
            panelB.SetActive(true);
            panel_savedB.SetActive(false);
        }

        //if (player.isSavedC)
        //{
        //    panelC.SetActive(false);
        //    panel_savedC.SetActive(true);
        //}
        //else
        //{
        //    panelC.SetActive(true);
        //    panel_savedC.SetActive(false);
        //}

        //if (player.isSavedD)
        //{
        //    panelD.SetActive(false);
        //    panel_savedD.SetActive(true);
        //}
        //else
        //{
        //    panelD.SetActive(true);
        //    panel_savedD.SetActive(false);
        //}

    }

    public void SaveCurrentSceneInA()
    {
        player.aScene = player.currentScene;

        player.aWarning = guest.warning;
        player.aMotherMem = guest.motherMem;
        player.aTomatoNoodle = guest.tomatoNoodle;

        player.aEmail = guest.email;
        player.aNameList = guest.nameList;
        player.aSeeShuLi = guest.seeShuLi;
        player.aRandomSale = guest.randomSale;
        player.aMotherRem = guest.motherRem;
        player.aCatAlley = guest.catAlley;
        player.aInsideStory = guest.insideStory;
        player.aKnife = guest.knife;

        player.isSavedA = true;
        panelA.SetActive(false);
        panel_savedA.SetActive(true);

    }

    public void LoadSavedSceneInA()
    {
        SceneManager.LoadSceneAsync(player.aScene);
        guest.warning = player.aWarning;
        guest.motherMem = player.aMotherMem;
        guest.tomatoNoodle = player.aTomatoNoodle;

        guest.email = player.aEmail;
        guest.nameList = player.aNameList;
        guest.seeShuLi = player.aSeeShuLi;
        guest.randomSale = player.aRandomSale;
        guest.motherRem = player.aMotherRem;
        guest.catAlley = player.aCatAlley;
        guest.insideStory = player.aInsideStory;
        guest.knife = player.aKnife;
    }

    public void DeleteSavingInA()
    {

        player.aWarning = 0;
        player.aMotherMem = 0;
        player.aTomatoNoodle = 0;

        player.aEmail = false;
        player.aNameList = false;
        player.aSeeShuLi = false;
        player.aRandomSale = false;
        player.aMotherRem = false;
        player.aCatAlley = false;
        player.aInsideStory = false;
        player.aKnife = false;

        player.isSavedA = false;

        panelA.SetActive(true);
        panel_savedA.SetActive(false);

        //warning_panelA.SetActive(false);

    }

    //Saving in 存档B
    public void SaveCurrentSceneInB()
    {
        player.bScene = player.currentScene;

        player.bWarning = guest.warning;
        player.bMotherMem = guest.motherMem;
        player.bTomatoNoodle = guest.tomatoNoodle;

        player.bEmail = guest.email;
        player.bNameList = guest.nameList;
        player.bSeeShuLi = guest.seeShuLi;
        player.bRandomSale = guest.randomSale;
        player.bMotherRem = guest.motherRem;
        player.bCatAlley = guest.catAlley;
        player.bInsideStory = guest.insideStory;
        player.bKnife = guest.knife;

        panelB.SetActive(false);
        panel_savedB.SetActive(true);

    }

    public void LoadSavedSceneInB()
    {
        SceneManager.LoadSceneAsync(player.bScene);
        guest.warning = player.bWarning;
        guest.motherMem = player.bMotherMem;
        guest.tomatoNoodle = player.bTomatoNoodle;

        guest.email = player.bEmail;
        guest.nameList = player.bNameList;
        guest.seeShuLi = player.bSeeShuLi;
        guest.randomSale = player.bRandomSale;
        guest.motherRem = player.bMotherRem;
        guest.catAlley = player.bCatAlley;
        guest.insideStory = player.bInsideStory;
        guest.knife = player.bKnife;
    }

    public void DeleteSavingInB()
    {


        player.bWarning = 0;
        player.bMotherMem = 0;
        player.bTomatoNoodle = 0;

        player.bEmail = false;
        player.bNameList = false;
        player.bSeeShuLi = false;
        player.bRandomSale = false;
        player.bMotherRem = false;
        player.bCatAlley = false;
        player.bInsideStory = false;
        player.bKnife = false;

        panel_savedB.SetActive(false);
        panelB.SetActive(true);
        //warning_panelB.SetActive(false);

    }

    ////Saving in 存档C
    //public void SaveCurrentSceneInC()
    //{
    //    player.cScene = SceneManager.GetActiveScene().buildIndex;

    //    player.cWarning = guest.warning;
    //    player.cMotherMem = guest.motherMem;
    //    player.cTomatoNoodle = guest.tomatoNoodle;

    //    player.cEmail = guest.email;
    //    player.cNameList = guest.nameList;
    //    player.cSeeShuLi = guest.seeShuLi;
    //    player.cRandomSale = guest.randomSale;
    //    player.cMotherRem = guest.motherRem;
    //    player.cCatAlley = guest.catAlley;
    //    player.cInsideStory = guest.insideStory;
    //    player.cKnife = guest.knife;

    //    panelC.SetActive(false);
    //    panel_savedC.SetActive(true);

    //}

    //public void LoadSavedSceneInC()
    //{
    //    SceneManager.LoadSceneAsync(player.cScene);
    //    guest.warning = player.cWarning;
    //    guest.motherMem = player.cMotherMem;
    //    guest.tomatoNoodle = player.cTomatoNoodle;

    //    guest.email = player.cEmail;
    //    guest.nameList = player.cNameList;
    //    guest.seeShuLi = player.cSeeShuLi;
    //    guest.randomSale = player.cRandomSale;
    //    guest.motherRem = player.cMotherRem;
    //    guest.catAlley = player.cCatAlley;
    //    guest.insideStory = player.cInsideStory;
    //    guest.knife = player.cKnife;
    //}

    //public void DeleteSavingInC()
    //{


    //    player.cWarning = 0;
    //    player.cMotherMem = 0;
    //    player.cTomatoNoodle = 0;

    //    player.cEmail = false;
    //    player.cNameList = false;
    //    player.cSeeShuLi = false;
    //    player.cRandomSale = false;
    //    player.cMotherRem = false;
    //    player.cCatAlley = false;
    //    player.cInsideStory = false;
    //    player.cKnife = false;

    //    panel_savedC.SetActive(false);
    //    panelC.SetActive(true);
    //    //warning_panelC.SetActive(false);

    //}

    ////Saving in 存档D
    //public void SaveCurrentSceneInD()
    //{
    //    player.dScene = SceneManager.GetActiveScene().buildIndex;

    //    player.dWarning = guest.warning;
    //    player.dMotherMem = guest.motherMem;
    //    player.dTomatoNoodle = guest.tomatoNoodle;

    //    player.dEmail = guest.email;
    //    player.dNameList = guest.nameList;
    //    player.dSeeShuLi = guest.seeShuLi;
    //    player.dRandomSale = guest.randomSale;
    //    player.dMotherRem = guest.motherRem;
    //    player.dCatAlley = guest.catAlley;
    //    player.dInsideStory = guest.insideStory;
    //    player.dKnife = guest.knife;

    //    panelD.SetActive(false);
    //    panel_savedD.SetActive(true);

    //}

    //public void LoadSavedSceneInD()
    //{
    //    SceneManager.LoadSceneAsync(player.dScene);
    //    guest.warning = player.dWarning;
    //    guest.motherMem = player.dMotherMem;
    //    guest.tomatoNoodle = player.dTomatoNoodle;

    //    guest.email = player.dEmail;
    //    guest.nameList = player.dNameList;
    //    guest.seeShuLi = player.dSeeShuLi;
    //    guest.randomSale = player.dRandomSale;
    //    guest.motherRem = player.dMotherRem;
    //    guest.catAlley = player.dCatAlley;
    //    guest.insideStory = player.dInsideStory;
    //    guest.knife = player.dKnife;
    //}

    //public void DeleteSavingInD()
    //{


    //    player.dWarning = 0;
    //    player.dMotherMem = 0;
    //    player.dTomatoNoodle = 0;

    //    player.dEmail = false;
    //    player.dNameList = false;
    //    player.dSeeShuLi = false;
    //    player.dRandomSale = false;
    //    player.dMotherRem = false;
    //    player.dCatAlley = false;
    //    player.dInsideStory = false;
    //    player.dKnife = false;

    //    panel_savedD.SetActive(false);
    //    panelD.SetActive(true);
    //    //warning_panelD.SetActive(false);
    //}

    //public void ShowWarningPanelA()
    //{
    //    warning_panelA.SetActive(true);
    //}

    //public void CancelA()
    //{
    //    warning_panelA.SetActive(false);
    //}

    //public void ShowWarningPanelB()
    //{
    //    warning_panelB.SetActive(true);
    //}

    //public void CancelB()
    //{
    //    warning_panelB.SetActive(false);
    //}

    //public void ShowWarningPanelC()
    //{
    //    warning_panelC.SetActive(true);
    //}

    //public void CancelC()
    //{
    //    warning_panelC.SetActive(false);
    //}

    //public void ShowWarningPanelD()
    //{
    //    warning_panelD.SetActive(true);
    //}

    //public void CancelD()
    //{
    //    warning_panelD.SetActive(false);
    //}
}
