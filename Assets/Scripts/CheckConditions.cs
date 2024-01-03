using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckConditions : MonoBehaviour
{
    public GuestParams guest_p;

    public void CheckNameListCondition()
    {
        if (guest_p.nameList)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(4);
        }
    }

    public void CheckEmailCondition()
    {
        if (guest_p.email)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(4);
        }
    }

    public void CheckSeeShuLiCondition()
    {
        if (guest_p.seeShuLi)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(5);
        }
    }

   

    public void CheckEndSeven()
    {
        if (guest_p.warning == 4)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(3);
            guest_p.warning += 1;
        }
    }

    public void CheckRandomSaleCondition()
    {
        if (guest_p.randomSale)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
            guest_p.warning += 1;
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(2);
        }
    }

    public void CheckOldLadyCondition()
    {
        if (guest_p.warning >= 6)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(3);
        }
    }

    public void CheckEndFour()
    {
        if (guest_p.warning >= 4 && guest_p.knife && guest_p.motherRem)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(5);
        }
    }

    public void CheckCatAlleyCondition()
    {
        if (guest_p.catAlley)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
            
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(3);
        }
    }

    public void CheckEndThree()
    {
        if (guest_p.warning < 4 && guest_p.motherMem == 2)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(2);
        }
    }

    public void CheckFinalEnd()
    {
        if (guest_p.warning >= 6)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(1);
        }
        else if (guest_p.warning == 1 && guest_p.tomatoNoodle == 4 && guest_p.knife)
        {
            FindObjectOfType<Navigation>().MoveToNextScene(4);
        }
        else
        {
            FindObjectOfType<Navigation>().MoveToNextScene(10);
        }

        
    }
}
