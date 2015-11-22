using UnityEngine;
using System.Collections;

enum Button
{
    Exit,
    Next,
    Continue,
    Default
}


public class MainCanvas : MonoBehaviour
{
    private Button buttons = new Button();
    GameManager gameManager;

    public void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void GetButton(string _buttonName)
    {
        try
        {
            buttons = (Button)System.Enum.Parse(typeof(Button), _buttonName, true);
        }
        catch (System.Exception)
        {
            buttons = Button.Default;
        }

        switch (buttons)
        {
            case Button.Exit:
                if (Application.loadedLevel != 1)
                {
                    Application.LoadLevel(1);
                }
                else
                {
                    Debug.Log("Ich habe mich geschlossen");
                    Application.Quit();
                }
                break;
            case Button.Next:
                break;
            case Button.Continue:
                if (Application.loadedLevel == PlayerPrefs.GetInt("Level"))
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    Application.LoadLevel(PlayerPrefs.GetInt("Level"));
                }
                break;
            case Button.Default:
            default:
                Debug.LogWarning(_buttonName + " not implemented");
                break;
        }
    }

}


