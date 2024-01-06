using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomizeButterflyColor : MonoBehaviour
{
    public List<GameObject> gameObjectsToToggle; // List of GameObjects to toggle
    private Button button; // Reference to the button
    private int lastActiveIndex = -1; // Index of the last active GameObject

    void Start()
    {
        RandomizeActivation();
        // Get the Button component attached to this GameObject
        button = GetComponent<Button>();

        // Register the onClick event
        if (button && gameObjectsToToggle.Count == 3)
        {
            button.onClick.AddListener(RandomizeActivation);
        }
        else
        {
            Debug.LogError("Button or GameObjects not properly set.");
        }
    }

    // Method to randomize the active GameObject
    void RandomizeActivation()
    {
        // Deactivate all GameObjects
        foreach (var gameObject in gameObjectsToToggle)
        {
            gameObject.SetActive(false);
        }

        // Randomly activate one of them, ensuring it's different from the last
        int randomIndex;
        do
        {
            randomIndex = Random.Range(0, gameObjectsToToggle.Count);
        }
        while (randomIndex == lastActiveIndex);

        gameObjectsToToggle[randomIndex].SetActive(true);
        lastActiveIndex = randomIndex; // Update the last active index
    }
}
