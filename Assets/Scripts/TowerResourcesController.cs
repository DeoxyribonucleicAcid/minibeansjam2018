﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerResourcesController : MonoBehaviour {

    public Tower tower;
    public Image progressbar;
    int requiredResources;
    public int currentResources = 0;

	// Use this for initialization
	void Start () {
        requiredResources = tower.requriredResources;
	}
	
	// Update is called once per frame
	void Update () {
        progressbar.fillAmount = (float)(currentResources) / (float)(requiredResources);
	}

    public void SubractBuildCosts() {
        currentResources -= requiredResources;
    }

    public bool CanBuild() {
        return currentResources >= requiredResources;
    }
}