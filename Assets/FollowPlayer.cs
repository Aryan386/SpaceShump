using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform Ptarget;
    public float smoothSpeed = 0.5f;
    public Vector3 offset;

	// Update is called once per frame
	void FixedUpdate () {

        Vector3 desiredPosition = Ptarget.position + offset;
       Vector3 smoothPosition = Vector3.Slerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        // Camera.main.
        transform.position = smoothPosition;
        //transform.position = desiredPosition;
		
	}
}
