using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }   

    public void ShowButton(Button button)
    {
        button.gameObject.SetActive(true);
    }

    public void HideButton(Button button)
    {
        button.gameObject.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
