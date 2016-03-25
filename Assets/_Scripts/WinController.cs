using UnityEngine;
using System.Collections;

public class WinController : MonoBehaviour {


    public GameController gameController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameController.finishRace();
            
        }
    }
}
