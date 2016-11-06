using UnityEngine;
using System.Collections;

public class bulleteffect : MonoBehaviour {

    float lifespan = 2.0f;
    public GameObject fireeffect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        lifespan += Time.deltaTime;

        if(lifespan <= 0)
        {
            Explode();
        }
	}

    void onCollisonEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            collision.gameObject.tag="Untagged";
            Instantiate(fireeffect, collision.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void Explode()
    {
        Destroy(gameObject);
    }
}
