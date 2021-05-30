using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ScoreBoard : MonoBehaviour
{
    public Text[] scoresText_5Pairs;
    public Text[] dateText_5Pairs;

    public Text[] scoresText_8Pairs;
    public Text[] dateText_8Pairs;

    public Text[] scoresText_10Pairs;
    public Text[] dateText_10Pairs;


    void Start()
    {
        UpdateScoreBoard();
    }

    public void UpdateScoreBoard()
    {
        Config.UpdateScoreList();

        DisplayPairsScoreData(Config.ScoreTimeList5Pairs, Config.PairNumberList5Pairs, scoresText_5Pairs, dateText_5Pairs);
        DisplayPairsScoreData(Config.ScoreTimeList8Pairs, Config.PairNumberList8Pairs, scoresText_8Pairs, dateText_8Pairs);
        DisplayPairsScoreData(Config.ScoreTimeList10Pairs, Config.PairNumberList10Pairs, scoresText_10Pairs, dateText_10Pairs);
    }

    private void DisplayPairsScoreData(float[] scoreTimeList, string[] pairNumberList, Text[] scoreText, Text[] dataText)
    {
        for (var index = 0; index < 3; index++)
        {
            if (scoreTimeList[index] > 0)
            {
                var dataTime = Regex.Split(pairNumberList[index], "T");

                var minutes = Mathf.Floor(scoreTimeList[index] / 60);
                float seconds = Mathf.RoundToInt(scoreTimeList[index] % 60);

                scoreText[index].text = minutes.ToString("00") + ":" + seconds.ToString("00");
                dataText[index].text = dataTime[0] + " " + dataTime[1];
            }
            else
            {
                scoreText[index].text = " ";
                dataText[index].text = " ";
            }
        }
    }
}
