using UnityEngine;

public class PilotPlayer : MonoBehaviour {

    public float Pspeed = 900f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //camera follow up

       // Vector3 moveCamTo = transform.position - transform.forward * 20f + Vector3.up * 5f * Time.deltaTime;
        //Camera.main.transform.position = moveCamTo;
        //Camera.main.transform.LookAt(transform.position + transform.position*30);

        transform.position += transform.forward * Time.deltaTime * Pspeed;
        Pspeed -= transform.forward.y * 50f * Time.deltaTime;

        if (Pspeed < 35f)
        {
            Pspeed = 35f;
        }

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
		
	}
}
