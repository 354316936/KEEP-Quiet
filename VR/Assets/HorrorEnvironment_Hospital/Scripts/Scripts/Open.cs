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
           
            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundY = Input.GetAxis("Vertical") * tiltAngle;
            
            Quaternion target = Quaternion.Euler(0, -tiltAroundY, tiltAroundZ);

            if(tiltAroundY < 90.0f)
            {
              // Dampen towards the target rotation
              transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            }
            if(tiltAroundY>90.0f)
            {
                coroutine = WaitAndPrint(2.5f);
                StartCoroutine(coroutine);
                GetComponent<BoxCollider>().enabled = false;
            }
            
        }
        
       
    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
    }
}
