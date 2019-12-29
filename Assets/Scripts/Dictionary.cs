using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    private string[] words;
    public string word;
    public static int next_count;
    public char current_letter;
    public GameObject[] Letters;
    public Material active_Material;
    public Material diabled_Material;

    // Start is called before the first frame update
    void Start()
    {
        words = new string[5] {"apple","cab","smartphone","train","mouse"};
        int randNum = Random.Range(0,words.Length);
        word = words[randNum];
        word = "CABADGE";
        next_count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < word.Length; i++)
        {
            if (next_count == i)
            {
                current_letter = word[i];
            }
        }
        foreach(GameObject letter in Letters)
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
        if (Input.GetKeyDown(KeyCode.Space)){
            next_count++;
        }

    }
}
