using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float maxAcceleration;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.forward * maxAcceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * maxAcceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * maxAcceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.back * maxAcceleration * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HIT!!!!");
        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Game");
        }
        if(collision.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("Win");
        }
    }
}
