﻿using UnityEngine;
using System.Collections;

public class HE_H_distortedLight : MonoBehaviour {

    private Color distortColor = Color.black;
	private Color baseColor = Color.black;

    private float blinkFrequency = 1.5f;
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
				blinkIterator = Random.Range( 0f, blinkFrequency ) * 0.5f;

				if( myLight.color != distortColor ) myLight.color = distortColor;
			else myLight.color = baseColor;
			}
	}
}
