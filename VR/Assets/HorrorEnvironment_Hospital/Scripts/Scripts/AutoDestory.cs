using UnityEngine;
using System.Collections;

public class AutoDestory : MonoBehaviour {
     public Zombie zombie;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag  == "Player")
        {
            zombie.OnDeath();

        }
    }

}
