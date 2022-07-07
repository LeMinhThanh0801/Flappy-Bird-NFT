using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScene : MonoBehaviour
{
   public void RepeatLeveForBlue()
    {
        SceneManager.LoadScene(2);
    }

    public void RepeatLeveForAmarillo()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
