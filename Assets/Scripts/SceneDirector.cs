﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneDirector : MonoBehaviour
{


    //public Text RemainingBars;
    //public Text totalBarsDebug;

    private int sceneBars;

    private void Start()
    {
        GameObject[] bars = GameObject.FindGameObjectsWithTag("Builder");

        sceneBars = bars.Length;

        //totalBarsDebug.text = sceneBars.ToString();

    }


    private void Update()
    {

        GameObject[] bars = GameObject.FindGameObjectsWithTag("Builder");

        //RemainingBars.text = "Bars Remaining: " + bars.Length;

        
        


        if (bars.Length < sceneBars)
        {
            ClearPreviews();
            sceneBars -= 1;
            //totalBarsDebug.text = sceneBars.ToString();
        }


    }

    public void ClearPreviews()
    {
        GameObject[] previews = GameObject.FindGameObjectsWithTag("Preview");
        foreach (GameObject preview in previews)
        {
            Destroy(preview);
        }

    }

    public void OpenMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);

    }



    public void OpenTestArea()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }



    // SHAPE A
    public void OpenShapeAAnimated()
    {
        SceneManager.LoadScene(sceneBuildIndex: 5);

    }

    public void OpenShapeAStepbyStep()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);

    }

    public void OpenShapeAFullyGuided()
    {
        SceneManager.LoadScene(sceneBuildIndex: 4);

    }

    public void OpenShapeAFinalProduct()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);

    }

    public void OpenShapeABuild()
    {
        SceneManager.LoadScene(sceneBuildIndex: 34);
    }


    // SHAPE B
    public void OpenShapeBAnimated()
    {
        SceneManager.LoadScene(sceneBuildIndex: 6);

    }

    public void OpenShapeBStepbyStep()
    {
        SceneManager.LoadScene(sceneBuildIndex: 7);

    }

    public void OpenShapeBFullyGuided()
    {
        SceneManager.LoadScene(sceneBuildIndex: 8);

    }

    public void OpenShapeBFinalProduct()
    {
        SceneManager.LoadScene(sceneBuildIndex: 9);

    }



    // SHAPE C
    public void OpenShapeCAnimated()
    {
        SceneManager.LoadScene(sceneBuildIndex: 10);

    }

    public void OpenShapeCStepbyStep()
    {
        SceneManager.LoadScene(sceneBuildIndex: 11);

    }

    public void OpenShapeCFullyGuided()
    {
        SceneManager.LoadScene(sceneBuildIndex: 12);

    }

    public void OpenShapeCFinalProduct()
    {
        SceneManager.LoadScene(sceneBuildIndex: 13);

    }


    // SHAPE D
    public void OpenShapeDAnimated()
    {
        SceneManager.LoadScene(sceneBuildIndex: 14);

    }

    public void OpenShapeDStepbyStep()
    {
        SceneManager.LoadScene(sceneBuildIndex: 15);

    }

    public void OpenShapeDFullyGuided()
    {
        SceneManager.LoadScene(sceneBuildIndex: 16);

    }

    public void OpenShapeDFinalProduct()
    {
        SceneManager.LoadScene(sceneBuildIndex: 17);

    }


    // SHAPE E
    public void OpenShapeEAnimated()
    {
        SceneManager.LoadScene(sceneBuildIndex: 18);

    }

    public void OpenShapeEStepbyStep()
    {
        SceneManager.LoadScene(sceneBuildIndex: 19);

    }

    public void OpenShapeEFullyGuided()
    {
        SceneManager.LoadScene(sceneBuildIndex: 20);

    }

    public void OpenShapeEFinalProduct()
    {
        SceneManager.LoadScene(sceneBuildIndex: 21);

    }


    // SHAPE F
    public void OpenShapeFAnimated()
    {
        SceneManager.LoadScene(sceneBuildIndex: 22);

    }

    public void OpenShapeFStepbyStep()
    {
        SceneManager.LoadScene(sceneBuildIndex: 23);

    }

    public void OpenShapeFFullyGuided()
    {
        SceneManager.LoadScene(sceneBuildIndex: 24);

    }

    public void OpenShapeFFinalProduct()
    {
        SceneManager.LoadScene(sceneBuildIndex: 25);

    }



    // SHAPE G
    public void OpenShapeGAnimated()
    {
        SceneManager.LoadScene(sceneBuildIndex: 26);

    }

    public void OpenShapeGStepbyStep()
    {
        SceneManager.LoadScene(sceneBuildIndex: 27);

    }

    public void OpenShapeGFullyGuided()
    {
        SceneManager.LoadScene(sceneBuildIndex: 28);

    }

    public void OpenShapeGFinalProduct()
    {
        SceneManager.LoadScene(sceneBuildIndex: 29);

    }

    // SHAPE H
    public void OpenShapeHAnimated()
    {
        SceneManager.LoadScene(sceneBuildIndex: 30);

    }

    public void OpenShapeHStepbyStep()
    {
        SceneManager.LoadScene(sceneBuildIndex: 31);

    }

    public void OpenShapeHFullyGuided()
    {
        SceneManager.LoadScene(sceneBuildIndex: 32);

    }

    public void OpenShapeHFinalProduct()
    {
        SceneManager.LoadScene(sceneBuildIndex: 33);

    }





}
