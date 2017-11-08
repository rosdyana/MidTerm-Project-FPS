// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion;	// Reference to the shattered version of the object
    public PlayerShoot ps;
	// If the player clicks on the object
	void Update()
	{
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1");
            if (ps.hitme)
            {
                // Spawn a shattered object
                GameObject destroyedGO = Instantiate(destroyedVersion, transform.position, transform.rotation);
                // Remove the current object
                Debug.Log("destroy bottle");
                Destroy(gameObject);
                Destroy(destroyedGO, 5);
                ps.addScore = true;
                ps.hitme = false;
            }

        }

	}

}
