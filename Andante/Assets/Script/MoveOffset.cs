﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour {

    private Material currentMaterial;
    public float speed;
    private float Offset;

	// Use this for initialization
	void Start () {
        currentMaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {

        Offset += speed * Time.deltaTime;

        currentMaterial.SetTextureOffset("_MainTex", new Vector2(Offset,0));
		
	}
}
