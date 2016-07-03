﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MultiplierGlow : MonoBehaviour {
    float fadeSpeed = 1f;
    float timer;
    Image img;
    void Awake() {
        img = GetComponent<Image>();
    }
	// Use this for initialization
	void Start () {
        GetComponent<RectTransform>().offsetMax = new Vector2(1920f / Screen.height * Screen.width / 2f, 1920f / 2f);
        GetComponent<RectTransform>().offsetMin = new Vector2(1920f / Screen.height * Screen.width / -2f, 1920f / -2f);

        img.color = new Color(1f, 1f, 0, 0);

        transform.SetAsLastSibling();
    }

    public void show() {
        timer = fadeSpeed;
        switch (Util.em.multiplier) {
            case 2:  img.color = new Color(1f, 1f, 0, 1f); break;
            case 3: img.color = new Color(1f, 0.5f, 0, 1f); break;
            default: img.color = new Color(1f, 1f, 0, 1f); break;
        }
        CancelInvoke("fade");
        Invoke("fade", 0.7f);
    }

    public void fade() {
        timer -= 0.1f;
        if (timer >= 0) {
            img.color = new Color(1f, 1f, 0, timer / fadeSpeed);
            /*switch (Util.em.multiplier) {
                case 2: img.color = new Color(1f, 1f, 0, timer / fadeSpeed); break;
                case 3: img.color = new Color(1f, 0.5f, 0, timer / fadeSpeed); break;
            }*/
            Invoke("fade", 0.1f);
        }
        else {
            img.color = new Color(1f, 1f, 0, 0);
        }
    }
}
