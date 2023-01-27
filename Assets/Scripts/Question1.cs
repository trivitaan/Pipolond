using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question1 : MonoBehaviour
{
    public GameObject[] questionObjects;
    public Sprite[] questionItems;
    public Canvas canvas;
    public string numberText;

    void Start()
    {
        LoadQuestions();
    }

    void LoadQuestions()
    {

        LoadSprite();
        
    }

    void LoadSprite()
    {
        int arrayIndex = Random.Range(0, questionItems.Length-1);
        // Randomize the order of the questions
        Sprite questionItem = questionItems[arrayIndex];

        string qustionNum1 = questionItem.name;

        GameObject newQuestion1 = Instantiate(questionObjects[0]);
        newQuestion1.name = qustionNum1.Substring(0, 1);
        newQuestion1.transform.SetParent(canvas.transform);
        newQuestion1.GetComponent<RectTransform>().localPosition = new Vector3(-170,-270,0);
        newQuestion1.GetComponent<RectTransform>().sizeDelta = new Vector2(100,100);
        newQuestion1.GetComponent<SpriteRenderer>().sortingOrder = 1;
        newQuestion1.transform.localScale = new Vector3(45f, 45f, 0f);
        //scale prefab
        RectTransform rectTransform = newQuestion1.GetComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        //put prefab in center


        newQuestion1.GetComponent<QuestionSpawn>().numbName = newQuestion1.name;
        newQuestion1.GetComponent<SpriteRenderer>().sprite = questionItem;
        Debug.Log(newQuestion1.name);

    }
}
