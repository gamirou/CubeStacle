using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    private float initialPosition;
    public float score = 0;

    void Start () {
        initialPosition = player.position.z;
    }

    // Update is called once per frame
    void Update () {
        score = player.position.z - initialPosition;
        scoreText.text = score.ToString("0");
	}
}
