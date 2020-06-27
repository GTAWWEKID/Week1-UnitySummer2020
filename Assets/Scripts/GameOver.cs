using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public Text winningText;
    public float CountdownTime = 10f;
    private bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if(gameOver)
        {
            CountdownTime--; 
            if (CountdownTime <= 0f)
            {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        GameObject x = collider.gameObject;
        if (x.tag.Equals("Player"))
        {
            gameOver = true;
            if(x.GetComponent<PlayerController>().GetPlayerIndex() == 1)
            {
                winningText.text = "PLAYER 1 WINS";
            }
            else
            {
                winningText.text = "PLAYER 2 WINS";
            }
        
        }
    }
}
