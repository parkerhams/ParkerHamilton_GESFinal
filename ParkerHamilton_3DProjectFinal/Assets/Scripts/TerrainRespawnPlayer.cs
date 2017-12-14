using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainRespawnPlayer : MonoBehaviour {
    float playerHeight;
    [SerializeField] float deathHeight;
    GameObject player;
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerHeight = player.transform.position.y;
	}

    //public void OnCollisionEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //    }
    //}

    public void RespawnTheThing()
    {
        if (playerHeight <= deathHeight)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
