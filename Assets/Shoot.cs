using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    GameObject heart2;
    GameObject heart3;
    int hearts;
    [SerializeField] string nameHeart2;
    [SerializeField] string nameHeart3;

    void Start()
    {
        hearts = 3;
        heart2 = GameObject.FindWithTag(nameHeart2);
        heart3 = GameObject.FindWithTag(nameHeart3);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag)
        {
            Destroy(other.gameObject);
            if (hearts == 3)
            {
                hearts--;
                heart3.SetActive(false);
            }
            else if (hearts == 2)
            {
                hearts--;
                heart2.SetActive(false);
            }
            else if (hearts == 1)
            {
                hearts--;
                if (nameHeart2 == "GH2")
                {
                    SceneManager.LoadScene("WinV");
                }
                else
                {
                    SceneManager.LoadScene("WinG");
                }
                
                //Destroy(this.gameObject);
            }
        }
    }

}
