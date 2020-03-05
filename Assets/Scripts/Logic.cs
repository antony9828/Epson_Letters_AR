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
    public bool finish;

    void Start()
    {
        word = "CABCAB";
        foreach (GameObject letter in Letters)
            letter.gameObject.GetComponent<Renderer>().material = diabled_Material;
        next_count = 0;
        finish = false;
    }

    void Update()
    {
        if (finish)
            return;

        current_letter = word[next_count];
        next_letter = word[next_count + 1];


        if (States.CheckIfLetterIsActive(current_letter) && (States.CheckIfLetterIsActive(next_letter)))
        {
            if (next_count == word.Length)
            {
                Debug.Log("You Win");
                finish = true;
            }
            else
                next_count++;
        }

        foreach (GameObject letter in Letters)
        {
            if (letter.CompareTag(current_letter.ToString()))
            {
                letter.GetComponent<Renderer>().material = active_Material;
            }
            else
            {
                letter.gameObject.GetComponent<Renderer>().material = diabled_Material;
            }
        }
        

    }
}
