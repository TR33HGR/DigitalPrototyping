using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {
    void Start() {
        for( int i = 0; i < 10; i++ ) {
            print( i );
            if( i == 3 ) {
                break;
            }
        }
    }
}
