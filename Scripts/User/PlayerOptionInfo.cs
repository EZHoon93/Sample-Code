﻿using System.Collections;

using UnityEngine;
using Data;
public struct JoystickInfo
{
    public Vector2 pos;
    public float size;
}
public static class PlayerOptionInfo 
{
    public static bool isBgmOn;
    public static bool isSFXOn;

    public static JoystickInfo moveJoystick;
    public static JoystickInfo attackJoystick;
    public static JoystickInfo runJoystick;


    //최초 
    public static void FirstCreateOption()
    {
        isBgmOn = true;
        isSFXOn = true;
        
    }



}
