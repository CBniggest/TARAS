using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLAYRCONTROLLER : MonoBehaviour {

    private Rigidbody rb;
    public Text scoreText;


    private int score;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(h, 0, v);


        rb.AddForce(dir);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("tag pickap"))
        {
            other.gameObject.SetActive(false);
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }

    



}
