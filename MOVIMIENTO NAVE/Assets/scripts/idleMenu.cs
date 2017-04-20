using UnityEngine;
using System.Collections;

public class idleMenu : MonoBehaviour{
     public float amplitud = 2.0f; 
     public float vel = 0.5f; 

    private idleMenu bounceObject; //for caching this transform

    Vector3 startPosition; //used to cache the start position of the transform


    void Start(){
        bounceObject = this;
        startPosition = bounceObject.transform.position;
    }


    void Update(){
            bounceObject.transform.position = startPosition + Vector3.up * (amplitud * Mathf.Sin(Time.timeSinceLevelLoad * vel));
    }
}
