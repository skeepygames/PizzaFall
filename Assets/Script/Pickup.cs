﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private Texture _texture;
    // [SerializeField] private Material pizzaMaterial;

    private void OnTriggerEnter(Collider other)
    {
        // pizzaMaterial.SetTexture("_MainTex",_texture);
        other.transform.GetChild(0).GetComponent<Renderer>().material.mainTexture = _texture;
        Destroy(gameObject);
    }
}