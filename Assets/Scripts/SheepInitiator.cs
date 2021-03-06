﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepInitiator : MonoBehaviour {

    [Header("Parameters")]
    public int sheepNumber;
    public float minSheepSpeed = 0.5f;
    public float maxSheepSpeed = 1.0f;

    [Header("Collaborators")]
    public GameObject sheepModel;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < sheepNumber; i++)
        {
            GameObject sheep = Instantiate(sheepModel);
            sheep.GetComponent<SheepAI>().target = GameObject.FindGameObjectWithTag("Cursor");
            sheep.GetComponent<SheepAI>().moveSpeed = Random.Range(minSheepSpeed, maxSheepSpeed);
            sheep.transform.position = new Vector3(Random.Range(-2, 2), Random.Range(0, 2), 1);
            sheep.GetComponentInChildren<Animator>().Play("SheepRun", 0, Random.Range(0f, 1f));
        }
	}
}
