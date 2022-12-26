using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stop : MonoBehaviour
{
    private int counterNum;
    private int randomNum;

    [SerializeField] private GameObject[] air;
    [SerializeField] private GameObject[] lightasdf;

    private Animator animator;

    [SerializeField] private Sprite spriteLight;
    public void StopBttn()
    {
        StartCoroutine(Stp());
    }

    [SerializeField] private GameObject soundP;
    [SerializeField] private GameObject soundW;
    [SerializeField] private GameObject soundv;


    private IEnumerator Stp()
    {
        for (int i = 0; i < lightasdf.Length; i++)
        {
            lightasdf[i].GetComponent<Light>().enabled = false;
        }


        counterNum = Counter.instance.count;

        randomNum = Random.Range(0, 5);

        lightasdf[randomNum].GetComponent<SpriteRenderer>().sprite = spriteLight;

        animator = air[randomNum].GetComponent<Animator>();

        Debug.Log(randomNum);

        if (randomNum == counterNum)
        {
            Counter.instance.AddCoin(100);
            Instantiate(soundW, transform.position, Quaternion.identity);
        }

        else
        {
            Counter.instance.AddCoin(-100);
            Instantiate(soundP, transform.position, Quaternion.identity);

        }

        yield return new WaitForSeconds(0.3f);


        
        animator.SetBool("fly", true);
        Instantiate(soundv, transform.position, Quaternion.identity);


        yield return new WaitForSeconds(2.5f);


        SceneManager.LoadScene("Game");
    }
}
