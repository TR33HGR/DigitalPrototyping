using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {
    void Start() {
        string str = "Hello";
        foreach( char chr in str ) {
            print( chr );
        }
    }
}
