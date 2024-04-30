/*
* @author Original Author: Jason Weimann 			Original Source: https://unity3d.college/2016/04/11/baseball-bat-physics-unity/
* @brief: This file controls the physics for the follower capsule, which has the colliders.
* It calculates the velocity of the rigidbody by getting the difference of the position of the capsule 
* it is following and it's own. For this project, the rotational commands were changed to prevent the 
* capsules from rotating and causing unwanted collisions.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatCapsuleFollower : MonoBehaviour
{
    private BatCapsule _batFollower;
	private Rigidbody _rigidbody;
	private Vector3 _velocity;

	[SerializeField]
	private float _sensitivity = 100f;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		Vector3 destination = _batFollower.transform.position;
		_rigidbody.transform.rotation = transform.rotation;

		_velocity = (destination - _rigidbody.transform.position) * _sensitivity;

		_rigidbody.velocity = _velocity;
	}

	public void SetFollowTarget(BatCapsule batFollower)
	{
		_batFollower = batFollower;
	}
}