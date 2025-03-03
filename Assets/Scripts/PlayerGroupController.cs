using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PLayerGroupController : MonoBehaviour
{
    public List<GameObject> movements;
    public List<GameObject> movements1;
    public float delay = 1f;
    public List<GameObject> brid;
    public List<GameObject> waters;
    public List<GameObject> waters1;
    bool[] brid_bool = { true, true, true, true };
    public int score;
    public TMP_Text scoreLable;
    public bool scoreUp;
    public bool scoreUp1;
    private Coroutine moveCoroutine;
    public float timer;
    public bool hasStartedCoroutine;
    public List<GameObject> fallSigns;
    public int fallingTimes = 0;
    public float pauseDelay = 0.5f;

    void Start()
    {
        score = 0;
        scoreUp = false;
        scoreUp1 = false;
        StartCoroutine(StartMovementsLoop());
        hasStartedCoroutine = false;

    }


    IEnumerator StartMovementsLoop()
    {
        while (true)
        {
            yield return StartCoroutine(ShowMovements());
            movements[19].SetActive(false);
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator StartMovementsLoop1()
    {
        while (true)
        {
            yield return StartCoroutine(ShowMovements1());
            movements1[19].SetActive(false);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator ShowMovements()
    {
        
        GameObject previousMovement = null;
        bool hit = false;
        

        foreach (GameObject movement in movements)
        {
            scoreUp = false;
            if (movements[3].activeInHierarchy && brid[0].activeInHierarchy && !scoreUp)
            {
                score++;
                scoreUp = true;
            }
            else if (movements[3].activeInHierarchy && !brid[0].activeInHierarchy && !scoreUp)
            {
                
                scoreUp = true;
                hit = true;
                fallingTimes ++;
                waters[0].SetActive(true);
                waters1[0].SetActive(true);
                Invoke("SetWaterOff", 0.5f);
                movements[3].SetActive(false);
            }

            if (movements[6].activeInHierarchy && brid[1].activeInHierarchy && !scoreUp)
            {
                score++;
                scoreUp = true;
            }
            else if (movements[6].activeInHierarchy && !brid[1].activeInHierarchy && !scoreUp)
            {
                
                scoreUp = true;
                hit = true;
                fallingTimes ++;
                waters[1].SetActive(true);
                waters1[1].SetActive(true);
                Invoke("SetWaterOff", 0.5f);
                movements[6].SetActive(false);
                
            }

            if (movements[13].activeInHierarchy && brid[2].activeInHierarchy && !scoreUp)
            {
                score++;
                scoreUp = true;
            }
            else if (movements[13].activeInHierarchy && !brid[2].activeInHierarchy && !scoreUp)
            {
                
                scoreUp = true;
                hit = true;
                fallingTimes ++;
                waters[2].SetActive(true);
                waters1[2].SetActive(true);
                Invoke("SetWaterOff", 0.5f);
                movements[13].SetActive(false);

            }

            if (movements[16].activeInHierarchy && brid[3].activeInHierarchy && !scoreUp)
            {
                score++;
                scoreUp = true;
            }
            else if (movements[16].activeInHierarchy && !brid[3].activeInHierarchy && !scoreUp)
            {
                
                scoreUp = true;
                hit = true;
                fallingTimes ++;
                waters[3].SetActive(true);
                waters1[3].SetActive(true);
                Invoke("SetWaterOff", 0.5f);
                movements[16].SetActive(false);

            }

            if(hit)
            {
                hit = false;
                yield break;
                
                
                
            }
            else
            {
                if (previousMovement != null)
                {
                    previousMovement.SetActive(false);
                }

                movement.SetActive(true);
                previousMovement = movement;

                yield return new WaitForSeconds(delay);
            }

        }

    }


    IEnumerator ShowMovements1()
    {
        GameObject previousMovement = null;
        bool hit1 = false;
        

        foreach (GameObject movement in movements1)
        {
            scoreUp1 = false;
            if (movements1[3].activeInHierarchy && brid[0].activeInHierarchy && !scoreUp1)
            {
                Debug.Log("Before increasing score: " + score + " scoreUp1: " + scoreUp1);
                score++;
                scoreUp1 = true;
                Debug.Log("After increasing score: " + score + " scoreUp1: " + scoreUp1);
            }
            else if (movements1[3].activeInHierarchy && !brid[0].activeInHierarchy && !scoreUp1)
            {
                
                scoreUp1 = true;
                hit1 = true;
                fallingTimes ++;
                waters[0].SetActive(true);
                waters1[0].SetActive(true);
                Invoke("SetWaterOff", 0.5f);
                movements1[3].SetActive(false);
            }

            if (movements1[6].activeInHierarchy && brid[1].activeInHierarchy && !scoreUp1)
            {
                score++;
                scoreUp1 = true;
            }
            else if (movements1[6].activeInHierarchy && !brid[1].activeInHierarchy && !scoreUp1)
            {
                
                scoreUp1 = true;
                hit1 = true;
                fallingTimes ++;
                waters[1].SetActive(true);
                waters1[1].SetActive(true);
                Invoke("SetWaterOff", 0.5f);
                movements1[6].SetActive(false);
            }

            if (movements1[13].activeInHierarchy && brid[2].activeInHierarchy && !scoreUp1)
            {
                score++;
                scoreUp1 = true;
            }
            else if (movements1[13].activeInHierarchy && !brid[2].activeInHierarchy && !scoreUp1)
            {
                
                scoreUp1 = true;
                hit1 = true;
                fallingTimes ++;
                waters[2].SetActive(true);
                waters1[2].SetActive(true);
                Invoke("SetWaterOff", 0.5f);
                movements1[13].SetActive(false);
            }

            if (movements1[16].activeInHierarchy && brid[3].activeInHierarchy && !scoreUp1)
            {
                score++;
                scoreUp1 = true;
            }
            else if (movements1[16].activeInHierarchy && !brid[3].activeInHierarchy && !scoreUp1)
            {
                
                scoreUp1 = true;
                hit1 = true;
                fallingTimes ++;
                waters[3].SetActive(true);
                waters1[3].SetActive(true);
                Invoke("SetWaterOff", 0.5f);
                movements1[16].SetActive(false);
            }

            if (hit1)
            {
                
                hit1 = false;
                
                yield break;
            }
            else
            {
                if (previousMovement != null)
                {
                    previousMovement.SetActive(false);
                }

                movement.SetActive(true);
                previousMovement = movement;
                yield return new WaitForSeconds(delay);
            }
        }
    }


    void SetIndexActive(int index)
    {
        for (int i = 0; i < brid.Count; i++)
        {
            brid[i].SetActive(i == index);
        }
    }
    void SetBoolActive(int index)
    {
        for (int i = 0; i < brid_bool.Length; i++)
        {
            brid_bool[i] = (i == index);
        }
    }
    void SetWaterOff()
    {
        for (int i = 0; i < waters.Count; i++)
        {
            waters[i].SetActive(false);
            waters1[i].SetActive(false);
        }
    }


    void Coroutine1()
    {
        movements1[19].SetActive(false);
        StartCoroutine(ShowMovements());
    }

    void Coroutine2()
    {
        movements[19].SetActive(false);
        StartCoroutine(ShowMovements1());
    }


    void CheckFallingTimes()
    {
        if (fallingTimes > 0 && fallingTimes <= fallSigns.Count)
        {
            fallSigns[fallingTimes - 1].SetActive(true); 
        }

        if (fallingTimes == 3)
        {
            StartCoroutine(PauseGame()); 
        }
    }

    IEnumerator PauseGame()
    {
        yield return new WaitForSeconds(pauseDelay);
        Time.timeScale = 0;
        Debug.Log("Game Paused!");
    }

    public void IncreaseFallingTimes()
    {
        if (fallingTimes < 3)
        {
            fallingTimes++;
            CheckFallingTimes();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        CheckFallingTimes();
        if (timer >= 30 && !hasStartedCoroutine)
        {
            StartCoroutine(StartMovementsLoop1());
            hasStartedCoroutine = true;
        }
        scoreLable.text = score.ToString();
        if (Input.GetKeyDown(KeyCode.D))
        {
            SetIndexActive(0);
            SetBoolActive(0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            SetIndexActive(1);
            SetBoolActive(1);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SetIndexActive(2);
            SetBoolActive(2);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SetIndexActive(3);
            SetBoolActive(3);
        }


    }


}