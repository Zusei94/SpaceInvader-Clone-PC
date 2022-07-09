using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGameWhenPlayerDie : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
