using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleVB : MonoBehaviour
{
    public GameObject waspHiveGO;
    public GameObject waspGO;
    // Start is called before the first frame update
    void Start()
    {
        waspHiveGO.SetActive(false);
        waspGO.SetActive(false);
    }

    public void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        if (gameObject.name == "WaspHiveSphereCollider")
        {
            waspHiveGO.SetActive(true);
            waspGO.SetActive(false);
        } else if (gameObject.name == "WaspSphereCollider")
        {
            waspHiveGO.SetActive(false);
            waspGO.SetActive(true);
        }
    }
}
