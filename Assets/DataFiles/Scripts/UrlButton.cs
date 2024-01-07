using UnityEngine;
using UnityEngine.UI;

public class UrlButton : MonoBehaviour
{
    private Button button;
    void Start()
    {
        // Get the Button component attached to this GameObject
        button = GetComponent<Button>();

        // Register the onClick event
        if (button)
        {
            button.onClick.AddListener(OpenUrl);
        }
        else
        {
            Debug.LogError("Missing components: Button or objectToToggle not set.");
        }
    }

    public void OpenUrl()
    {
        if (button.name == "WaspHiveReadMoreButton")
        {
            Application.OpenURL("https://en.wikipedia.org/wiki/Wasp");
        } else if (button.name == "ButterflyReadMoreButton")
        {
            Application.OpenURL("https://en.wikipedia.org/wiki/Butterfly");
        } else if (button.name == "CrocodileReadMoreButton")
        {
            Application.OpenURL("https://en.wikipedia.org/wiki/Crocodile");
        } else if (button.name == "ScorpionReadMoreButton")
        {
            Application.OpenURL("https://en.wikipedia.org/wiki/Scorpion");
        }
        
        Debug.Log("Url Opened " + button.name);
    }
}
