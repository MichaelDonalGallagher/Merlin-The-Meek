﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        /*GameObject hitobj = other.gameObject;

        if (hitobj.tag == "Player")
        {
            Debug.Log("You win. Neat!");
        }*/
    }
}