using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public int waitSecondTime;
    // Start is called before the first frame update
    void Start()
    {
        LoadNextLevel();
    }

    public void LoadNextLevel(){
        StartCoroutine(LoadLevel(0));
    }

    IEnumerator LoadLevel(int levelIndex){
        yield return new WaitForSeconds(waitSecondTime);
        SceneManager.LoadScene(levelIndex);
    }
}