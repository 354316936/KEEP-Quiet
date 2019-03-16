using UnityEngine;
using System.Collections;

public class HE_H_distortedLight : MonoBehaviour {

    private Color distortColor = Color.yellow;
	private Color baseColor = Color.gray;

    private float blinkFrequency = 5.5f;
	private float blinkIterator = 0f;

	private Light myLight;

	void Start()
	{
		myLight = gameObject.GetComponent< Light >();
		baseColor = myLight.color;
	}

	void Update()
	{

			blinkIterator += 1f * Time.deltaTime;
            
			if( blinkIterator >= blinkFrequency )
			{
				blinkIterator = Random.Range( 0f, blinkFrequency ) * 5.5f;
            
				if( myLight.color != distortColor ) myLight.color = distortColor;
			else myLight.color = baseColor;
			}
	}
}
