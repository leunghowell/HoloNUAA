﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        PlatformManager.UserCurrentPosition = UserPosition.Building1;

        StartImageMatch();
    }

    private void StartImageMatch()
    {
        ImageMatchManager.Instance.InitData();
        
    }

    private void Update()
    {
        if (Input.touchCount > 0 ||
                Input.GetMouseButtonDown(0))
        {
            GazeGestureManager.Instance.PerformTapEvent();
        }
    }
}