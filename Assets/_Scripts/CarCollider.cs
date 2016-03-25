/*
    Source File Name: CarCollider
    Author's Name: Vinay Bhardwaj
    Last Modified By: Vinay Bhardwaj
    Date Last Modified: 25th March 2016
    Program Descreption:12
*/

using UnityEngine;
using System.Collections;

public class CarCollider : MonoBehaviour {

    //PUBLIC INSTANCE VARIABLES
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public GameController gameController;

    //PRIVATE INSTANCE VARIABLES
    private Transform _transform;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("DeathPlane"))
        {
            this.gameController.LivesValues--;
            this._transform.position = this.spawnPoint1.position;
        }
        if (other.gameObject.CompareTag("DeathPlane1"))
        {
            this.gameController.LivesValues--;
            this._transform.position = this.spawnPoint2.position;
        }
        if (other.gameObject.CompareTag("DeathPlane2"))
        {
            this.gameController.LivesValues--;
            this._transform.position = this.spawnPoint3.position;
        }
        if (other.gameObject.CompareTag("DeathPlane3"))
        {
            this.gameController.LivesValues--;
            this._transform.position = this.spawnPoint4.position;
        }
    }
}
