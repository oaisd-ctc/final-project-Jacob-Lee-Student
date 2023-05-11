using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI FatalitiesScore;

    void Awake() {
        int numGameSession = FindObjectsOfType<GameSession>().Length;
        if (numGameSession > 1) {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start() {
        FatalitiesScore.text = score.ToString();
    }

    public void AddToScore(int pointsToAdd) {
        score += pointsToAdd;
        FatalitiesScore.text = score.ToString();       
    } 
}
