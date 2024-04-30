/*
* @author Original Author: Jason Weimann 		Original Source: https://unity3d.college/2016/04/11/baseball-bat-physics-unity/
* @brief: This file creates a follower capsule and sets it to follow this capsule. 
* 		  For this project, rotational commands on the batCapsuleFollower were changed.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BatCapsule : MonoBehaviour
{
    [SerializeField]
	private BatCapsuleFollower _batCapsuleFollowerPrefab;

	private void SpawnBatCapsuleFollower()
	{
		var follower = Instantiate(_batCapsuleFollowerPrefab);
		follower.transform.position = transform.position;
		follower.SetFollowTarget(this);
	}

	private void Start()
	{
		SpawnBatCapsuleFollower();
	}
}