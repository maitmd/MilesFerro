﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform character;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(character.position.x + offset.x, character.position.y + offset.y, offset.z);
    }
}
