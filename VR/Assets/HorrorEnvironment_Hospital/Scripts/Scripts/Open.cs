using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{

    float smooth = 45.0f;
    float tiltAngle = 90.0f;
    private IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            float tiltAroundY = Input.GetAxis("Vertical") * tiltAngle;
            
            Quaternion target = Quaternion.Euler(0, -tiltAroundY, 0);
            // Dampen towards the target rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            coroutine = WaitAndPrint(2.0f);
            StartCoroutine(coroutine);
        }
   

    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        GetComponent<BoxCollider>().enabled = false;
    }
}
