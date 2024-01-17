using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleImg : MonoBehaviour
{
    public GameObject imageOne;
    public GameObject imageTwo;
    // Start is called before the first frame update
    void Start()
    {
        imageOne.SetActive(false);
        imageTwo.SetActive(false);
    }

    public void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        if (gameObject.name == "scorpionPinchSphereCollider")
        {
            imageOne.SetActive(true);
            imageTwo.SetActive(false);
        }
        else if (gameObject.name == "scorpionStingSphereCollider")
        {
            imageOne.SetActive(false);
            imageTwo.SetActive(true);
        }
    }
}
