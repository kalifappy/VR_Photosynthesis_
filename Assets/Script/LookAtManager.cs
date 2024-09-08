using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtManager : MonoBehaviour
{

    [SerializeField] List<Transform> looAtObjects = new List<Transform>();
    private Camera mainCamera;

    void Start()
    {
        // Get the main camera in the scene
        mainCamera = Camera.main;
    }

    void Update()
    {
      
        foreach (Transform item in looAtObjects)
        {
            item.LookAt(mainCamera.transform);
        }
    }
}
