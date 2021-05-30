using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameScene : MonoBehaviour
{
   public void QuitTheGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
