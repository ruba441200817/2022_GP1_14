using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Switch : MonoBehaviour
{
    public Button parent;
    public Button child;
    // Start is called before the first frame update
    public void Clickedparent()
    {
        child.gameObject.SetActive(false);
        parent.gameObject.SetActive(true);
        SceneManager.LoadScene("progress page");
    }
    public void Clickedchild()
    {
        child.gameObject.SetActive(true);
        parent.gameObject.SetActive(false);
        SceneManager.LoadScene("progress page");
        SceneManager.LoadScene("Homepage");
    }
}
