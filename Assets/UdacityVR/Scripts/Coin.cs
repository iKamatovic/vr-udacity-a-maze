﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Coin : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    // Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity

    public GameObject coinPoofPrefab;

    void Update () {
        // OPTIONAL-CHALLENGE: Animate the coin rotating
        // TIP: You could use a method from the Transform class
        gameObject.transform.Rotate(0f, Time.deltaTime * 100, 0f);
	}


	public void OnCoinClicked () {
        /// Called when the 'Coin' game object is clicked
        /// - Displays a poof effect (handled by the 'CoinPoof' prefab)
        /// - Plays an audio clip (handled by the 'CoinPoof' prefab)
        /// - Removes the coin from the scene

        // Prints to the console when the method is called
        Debug.Log ("'Coin.OnCoinClicked()' was called");

        // TODO: Display the poof effect and remove the coin from the scene
        // Use Instantiate() to create a clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
        // Use Destroy() to delete the coin after for example 0.5 seconds

        Object.Instantiate(coinPoofPrefab, transform.position, coinPoofPrefab.transform.rotation);
        Object.Destroy(gameObject, 0.5f);

        EventTrigger coinEventTrigger = GetComponent<EventTrigger>();
        coinEventTrigger.enabled = false;
    }
}
