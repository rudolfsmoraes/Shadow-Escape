﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStage : MonoBehaviour
{
    [SerializeField] int stageIndex;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene(stageIndex);
    }
}
