﻿using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private Texture _texture;

    [SerializeField] private ParticleSystem ppSystem;

    [SerializeField] private GameObject x2Object;
    
    // [SerializeField] private Material pizzaMaterial;

    private void Start()
    {
     
           
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // pizzaMaterial.SetTexture("_MainTex",_texture);
        other.GetComponent<Renderer>().material.mainTexture = _texture;
        Instantiate(ppSystem, transform.position,quaternion.identity);
        Instantiate(x2Object, transform.position + (Vector3.up * 3), Quaternion.identity);
        Destroy(gameObject,0.1f);
    }
}
