using UnityEngine;

public class moveobject : MonoBehaviour {

	public float speed = 6f;
	public float JumpForce = 6f;
	public Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis ("Vertical") * speed * Time.deltaTime);

		if (Input.GetButtonDown("Jump")) {
			rb.velocity = new Vector3 (0f, JumpForce, 0f);
		}
	}
}
