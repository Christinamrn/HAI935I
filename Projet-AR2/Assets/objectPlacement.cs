using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class objectPlacement : MonoBehaviour
{
    private ARRaycastManager rayManager;
    private GameObject visualObject;
    // Start is called before the first frame update
    void Start()
    {
        rayManager = FindObjectOfType<ARRaycastManager>();
        visualObject = transform.GetChild(0).gameObject;
        visualObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(new Vector2(Screen.width/2, Screen.height/2), hits, TrackableType.Planes);

        if(hits.Count > 0){
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }

        if(!visualObject.activeInHierarchy){
            visualObject.SetActive(true);
        }
    }
}
