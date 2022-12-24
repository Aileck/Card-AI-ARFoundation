using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;


public class ImageRecognition : MonoBehaviour
{
    // Start is called before the first frame update
    private ARTrackedImageManager image_manager;
    
    void Awake()
    {
        image_manager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        image_manager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        image_manager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args) {
        foreach (var trackedImage in args.added) {
            Debug.Log(trackedImage.name);
        }
    }
    
}
