using UnityEngine;
using System.Collections;

public class fbs_shooting : MonoBehaviour {

    public GameObject bullet_prefab;
    float bulletimpulse = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButton("Fire1"))
        {
           
            
            Camera cam = Camera.main;
            GameObject thebullet = (GameObject)Instantiate(bullet_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
        
        }
	}
}
