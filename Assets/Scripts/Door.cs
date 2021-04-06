using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
	if(SceneManager.GetActiveScene().buildIndex == 0)
	{
	    SceneManager.LoadScene(1);
	}
	else
	{
	    SceneManager.LoadScene(0);
	}
    }
}