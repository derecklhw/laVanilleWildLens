using UnityEngine;
using UnityEngine.UI;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject objectToToggle; // Reference to the GameObject to toggle
    private Button button; // Reference to the button

    void Start()
    {
        // Get the Button component attached to this GameObject
        button = GetComponent<Button>();

        // Register the onClick event
        if (button && objectToToggle)
        {
            objectToToggle.SetActive(false);
            button.onClick.AddListener(ToggleObject);
        }
        else
        {
            Debug.LogError("Missing components: Button or objectToToggle not set.");
        }
    }

    // Method to toggle the active state of the GameObject
    void ToggleObject()
    {
        if (objectToToggle)
        {
            // Toggle the active state
            objectToToggle.SetActive(!objectToToggle.activeSelf);
        }
    }
}
