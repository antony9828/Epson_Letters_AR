using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public string word;
    public static int next_count;
    public char current_letter;
    public char next_letter;
    public GameObject[] Letters;
    public Material active_Material;
    public Material diabled_Material;
    public Material completed_Material;
    public bool finish;
    private float letterDistaceX;
    private float letterDistaceY;
    private bool checkDistance;
    private bool startedCourotine;
    //public static float letterRange = 

    void Start()
    {
        word = "*CAB";
        foreach (GameObject letter in Letters)
            letter.gameObject.GetComponent<Renderer>().material = diabled_Material;
        next_count = 0;
        finish = false;
        checkDistance = false;
        startedCourotine = false;
    }

    void Update()
    {
        if (finish)
            return;

        current_letter = word[next_count];
        next_letter = word[next_count + 1];
        Debug.Log("Next letter: " + next_count);
        Debug.Log("Length letter: " + word.Length);



        //Debug.Log(GameObject.Find(current_letter.ToString()).transform.position -
        //GameObject.Find(next_letter.ToString()).transform.position);

        //if two markers are tracked then start a courotine else stop
        if (States.CheckIfLetterIsActive(current_letter) &&
            (States.CheckIfLetterIsActive(next_letter)) )
        {
            //start courotine only once
            if (!startedCourotine)
            {
                StartCoroutine(GetDistance());
                startedCourotine = true;
            }
            
            //if courotine started we can check distance
            if(checkDistance && 
                letterDistaceX > -1.2f && letterDistaceX < 0.8f &&
                letterDistaceY > -0.2f && letterDistaceY < 0.2f)
            {
                next_count++;
                startedCourotine = false;
                checkDistance = false;
                StopCoroutine(GetDistance());
                if (next_count == word.Length - 1)
                {
                    Debug.Log("you win");
                    finish = true;
                }
            }

        }
        else
        {
            startedCourotine = false;
            checkDistance = false;
            StopCoroutine(GetDistance());
        }

        foreach (GameObject letter in Letters)
        {
            if (letter.CompareTag(next_letter.ToString()))
            {
                letter.GetComponent<Renderer>().material = active_Material;
            }
            else
            {
                letter.gameObject.GetComponent<Renderer>().material = diabled_Material;
            }
        }
        
        if (finish)
        {
            foreach (GameObject letter in Letters)
            {
                 letter.GetComponent<Renderer>().material = completed_Material;
            }
        }

    }

    private IEnumerator GetDistance()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            letterDistaceX = GameObject.Find(current_letter.ToString()).transform.position.x -
                    GameObject.Find(next_letter.ToString()).transform.position.x;
            letterDistaceY = GameObject.Find(current_letter.ToString()).transform.position.y -
                    GameObject.Find(next_letter.ToString()).transform.position.y;
            checkDistance = true;

            //Debug.Log("Distance between letters X: " + letterDistaceX);
            //Debug.Log("Distance between letters Y: " + letterDistaceY);
        }
        
    }
}
