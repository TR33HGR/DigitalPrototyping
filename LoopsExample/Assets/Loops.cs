using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {
    void Start() {
        int i = 10;
        do{
            print( "Loop: " + i );
            i++;
        } while( i < 3 );
    }
}
