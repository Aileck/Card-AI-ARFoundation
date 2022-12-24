using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Linq;

public class ARreference : MonoBehaviour
{
    // Start is called before the first frame update
    public string ReferenceImageName;
    private ARTrackedImageManager _TrackedImageManager;

    private void Awake()
    {
        _TrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        if (_TrackedImageManager != null)
        {
            _TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
        }
    }

    private void OnDisable()
    {
        if (_TrackedImageManager != null)
        {
            _TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
        }
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs e)
    {
        foreach (var trackedImage in e.added)
        {
            Debug.Log($"Tracked image detected: {trackedImage.referenceImage.name} with size: {trackedImage.size}");
        }

        UpdateTrackedImages(e.added);
        UpdateTrackedImages(e.updated);
    }

    private void UpdateTrackedImages(IEnumerable<ARTrackedImage> trackedImages)
    {
        // If the same image (ReferenceImageName)
        var trackedImage =
            trackedImages.FirstOrDefault(x => x.referenceImage.name == ReferenceImageName);
        if (trackedImage == null)
        {
            return;
        }

        if (trackedImage.trackingState != TrackingState.None)
        {
            var trackedImageTransform = trackedImage.transform;
            transform.SetPositionAndRotation(trackedImageTransform.position, trackedImageTransform.rotation);
        }
    }
}
