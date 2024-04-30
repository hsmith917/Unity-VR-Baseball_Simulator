using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float timeBetweenPitches;
    public GameObject ball;
    

    void Start () {
        StartCoroutine(Pitch());
	}
	
	private IEnumerator Pitch() {
        while (true) {
            yield return new WaitForSeconds(timeBetweenPitches);
            Vector3 launchDirection = new Vector3(0,0,1);
            Quaternion q = Quaternion.Euler(launchDirection);

            Instantiate(ball, transform.position, q);
        }
    }
    //1,180,90f
}
