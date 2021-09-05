using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{

    public Transform target;

    public float defaultPosY = -50.0f;

    // Start is called before the first frame update
    void Start()
    {
        // defaultPosY = transform.position.y;
    }
  
    void Update()
    {
        // Apply position
        transform.position = new Vector3(target.position.x, defaultPosY, target.position.z);
        // Apply rotation
        transform.rotation = Quaternion.Euler(90, target.eulerAngles.y, 0);
    }
}
