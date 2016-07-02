﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public enum TimerType { money, elixir }

public class TimerText : MonoBehaviour {
    WorldManager wm;
    Text txt;
    public TimerType type;
    //Color normalColor;
    void Awake() {
        wm = GameObject.Find("WorldManager").GetComponent<WorldManager>();
        txt = GetComponent<Text>();
        //normalColor = txt.color;
    }
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (type == TimerType.money) {
            if (wm.adWatchTimeMoney > 0) {
                TimeSpan t = TimeSpan.FromSeconds(wm.adWatchTimeMoney);

                txt.text = string.Format("{0:D2}:{1:D2}",
                        t.Minutes,
                        t.Seconds);
            }
            else {
                txt.text = "Ready!";
            }
        }
        else {
            if (wm.adWatchTimeElixir > 0) {
                TimeSpan t = TimeSpan.FromSeconds(wm.adWatchTimeElixir);

                txt.text = string.Format("{0:D2}:{1:D2}",
                        t.Minutes,
                        t.Seconds);
            }
            else {
                txt.text = "Ready!";
            }
        }
        /*if (wm.adWatchTime <= 0) {
            txt.color = new Color(0, 0.9f, 0.05f);
        }
        else {
            txt.color = normalColor;
        }*/
    }
}
