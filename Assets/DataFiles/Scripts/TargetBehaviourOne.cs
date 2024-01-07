using UnityEngine;

public class TargetBehaviourOne : MonoBehaviour
{
    TargetBehaviourOne otherTargetBehaviour;
    public GameObject otherTarget;
    public bool isFightDetected = false;

    // Start is called before the first frame update
    void Awake()
    {
        otherTargetBehaviour = otherTarget.GetComponent<TargetBehaviourOne>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ActivateFight()
    {
        isFightDetected = true;
        Debug.Log(otherTargetBehaviour.name);

        if (otherTargetBehaviour.isFightDetected == true)
        {
            if (gameObject.name == "WASPHIVE_ImageTarget" && otherTargetBehaviour.name == "BUTTERFLY_imageTarget")
            {
                Application.OpenURL("https://www.youtube.com/watch?v=u7DW6qJk-lg&pp=ygURYnV0dGVyZmx5IHZzIHdhc3A%3D");
            } else if (gameObject.name == "BUTTERFLY_imageTarget" && otherTargetBehaviour.name == "WASPHIVE_ImageTarget")
            {
                Application.OpenURL("https://www.youtube.com/watch?v=u7DW6qJk-lg&pp=ygURYnV0dGVyZmx5IHZzIHdhc3A%3D");
            } else if (gameObject.name == "BUTTERFLY_imageTarget" && otherTargetBehaviour.name == "SCORPION_ModelTarget")
            {
                Application.OpenURL("https://youtu.be/D5AHAGJZ7Xg");
            } else if (gameObject.name == "SCORPION_ModelTarget" && otherTargetBehaviour.name == "BUTTERFLY_imageTarget")
            {
                Application.OpenURL("https://youtu.be/D5AHAGJZ7Xg");
            }
        }
        else
        {
            Debug.Log(gameObject.name + " not enemy");
        }
    }

    public void DeactivateFight()
    {
        isFightDetected = false;
        Debug.Log(isFightDetected);
    }
}
