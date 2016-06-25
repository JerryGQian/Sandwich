﻿using UnityEngine;
using System.Collections;

public class BreadTop : MonoBehaviour {
    SpriteRenderer sr;

    private float dropTime = 0.08f;
    private float dropTimer = 0;
    private float waitTime = 0.05f;
    private float waitTimer = 0;
    private float removeTime = 0.07f;
    private float removeTimer = 0;

    private Vector3 startPos;

    public GameObject bread;
	// Use this for initialization
	void Awake () {
	    sr = GetComponent<SpriteRenderer>();
        Invoke("suicide", 2.8f);
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (dropTimer < dropTime) {
            dropTimer += Time.deltaTime;
            sr.color = new Color(1f, 1f, 1f, dropTimer / dropTime);
            transform.Translate(new Vector3(0, -4f / dropTime * Time.deltaTime));
        }
        else if (waitTimer < waitTime) {
            waitTimer += Time.deltaTime;
            transform.position = startPos + new Vector3(0, -4f);
        }
        else if (removeTimer < removeTime) {
            transform.Translate(new Vector3(6f / dropTime * Time.deltaTime, 0));
            bread.transform.Translate(new Vector3(6f / dropTime * Time.deltaTime, 0));
        }
	}

    void suicide() {
        Destroy(gameObject);
    }
}