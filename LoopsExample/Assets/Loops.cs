﻿using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {
    void Start() {
        int i = 0;
        while(i < 3) {
            print( "Loop: " + i );
            i++;
        }
    }
}
