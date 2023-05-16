using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class GameMananer : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject play;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 2f);
            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);

        }
    }

    void ScoreUP()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameStart()
    {

        player.SetActive(true);
        play.SetActive(false);


        StartCoroutine("SpawnObstacles");
        InvokeRepeating("ScoreUP", 2f, 2f);

    }


}
