using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject kurang;
    public GameObject bagi;
    public GameObject tambah;
    public GameObject kali;
    public Canvas canvas;

    void Start()
    {
        if (SceneMan.prevScene == "kurang")
        {
            GameObject obj = Instantiate(kurang);
            obj.transform.SetParent(canvas.transform);
            obj.GetComponent<RectTransform>().localPosition = new Vector3(-170,0,0);
            obj.transform.localScale = new Vector3(1f, 1f, 0f);

        }
        else if (SceneMan.prevScene == "bagi")
        {
            GameObject obj = Instantiate(bagi);
            obj.transform.SetParent(canvas.transform);
            obj.GetComponent<RectTransform>().localPosition = new Vector3(-170,0,0);
            obj.transform.localScale = new Vector3(1f, 1f, 0f);
        }
        else if (SceneMan.prevScene == "tambah")
        {
            GameObject obj = Instantiate(tambah);
            obj.transform.SetParent(canvas.transform);
            obj.GetComponent<RectTransform>().localPosition = new Vector3(-170,0,0);
            obj.transform.localScale = new Vector3(1f, 1f, 0f);
        }
        else if (SceneMan.prevScene == "kali")
        {
            GameObject obj = Instantiate(kali);
            obj.transform.SetParent(canvas.transform);
            obj.GetComponent<RectTransform>().localPosition = new Vector3(-170,0,0);
            obj.transform.localScale = new Vector3(1f, 1f, 0f);
        }
    }
}