using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*public class PlayerScript : MonoBehaviour {

	public float speed;
		private Rigidbody rb;
	void Start () {

	rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
}
*/


public class PlayerScript : MonoBehaviour
{

    public float speed;
    public int direc;
    public object cam;

    public Vector3 rotate;
    private Vector3 dir;
    // Use this for initialization 
	public Text SpeedText;
	public Text LoseText;


    void Start()
    {
        //		dir = Vector3.zero;
        dir = Vector3.forward;
        direc = 0;
		SpeedText.text = "Speed = " + speed.ToString();

		LoseText.text = "";
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("MyGame");
        }


		if (transform.position.y < 0)
		{
			LoseText.text = "you lose. Score :" + (speed - 10);
		}

        if (Input.GetKeyDown("left"))
        {
            dir = Vector3.left;
            speed = speed + 1;

		SpeedText.text = "Speed = " + speed.ToString();
        }
        if (Input.GetKeyDown("right"))
        {
            dir = Vector3.right;
            speed = speed + 1;

		SpeedText.text = "Speed = " + speed.ToString();
        }
        if (Input.GetKeyDown("up"))
        {
            dir = Vector3.forward;
            speed = speed + 1;

		SpeedText.text = "Speed = " + speed.ToString();
        }
        if (Input.GetKeyDown("down"))
        {
            dir = Vector3.back;
            speed = speed + 1;

		SpeedText.text = "Speed = " + speed.ToString();
        }
        
        float amountToMove = speed * Time.deltaTime;

        transform.Translate(dir * amountToMove);

    }
}
