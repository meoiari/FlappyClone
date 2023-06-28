using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int GameScore = 0;
    public static int BestGameScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = GameScore.ToString();
    }
}
