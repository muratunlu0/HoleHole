using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour {
    public GameObject top;		

	void Update () {      
        transform.position = new Vector3(transform.position.x, top.transform.position.y+5, transform.position.z);
    }
}
