using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleImg : MonoBehaviour
{
    public GameObject imageOne;
    public GameObject imageTwo;
    bool imageOneBool = false;
    bool imageTwoBool = false;

    // Start is called before the first frame update
    void Start()
    {
        imageOne.SetActive(imageOneBool);
        imageTwo.SetActive(imageTwoBool);
    }

    public void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        if (gameObject.name == "scorpionStingSphereCollider")
        {
            imageOneBool = !imageOneBool;
            imageOne.SetActive(imageOneBool);
            imageTwo.SetActive(false);
        }
        else if (gameObject.name == "scorpionPinchOneSphereCollider" || gameObject.name == "scorpionPinchTwoSphereCollider")
        {
            imageTwoBool = !imageTwoBool;
            imageOne.SetActive(false);
            imageTwo.SetActive(imageTwoBool);
        }
    }
}
