using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreTextFollow;
    public Text scoreTextFix;
    public Text scoreTextFollowHand;

    static int score = 0;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreTextFollow.text = "Target shoot\n" + score.ToString();
        scoreTextFix.text = "Target shoot\n" + score.ToString();
        scoreTextFollowHand.text = "Target shoot\n" + score.ToString();
    }

    public void AddPoint(int addScore)
    {
        score += addScore;
        scoreTextFollow.text = "Target shoot\n" + score.ToString();
        scoreTextFix.text = "Target shoot\n" + score.ToString();
        scoreTextFollowHand.text = "Target shoot\n" + score.ToString();
    }

}
