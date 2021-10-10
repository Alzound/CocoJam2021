using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StatsController : MonoBehaviour
{
    public StatStorage storage;
    private int availablePoints, bravePoints, nervePoints, luckPoints;
    private List<int> nums = new List<int>();
    public List<Button> arrows = new List<Button>();
    public List<TextMeshProUGUI> values = new List<TextMeshProUGUI>();

    public void Awake()
    {
        availablePoints = 2;                                                                                
        bravePoints = 0;                                                                                    
        nervePoints = 0;
        luckPoints = 0;

        nums.Add(availablePoints);
        nums.Add(bravePoints);
        nums.Add(nervePoints);
        nums.Add(luckPoints);

        // Brave buttons
        arrows[0].onClick.AddListener(MoreBrv); // More
        arrows[1].onClick.AddListener(LessBrv); // Less
        // Nerve buttons
        arrows[2].onClick.AddListener(MoreNrv); // More
        arrows[3].onClick.AddListener(LessNrv); // Less
        // Luck buttons
        arrows[4].onClick.AddListener(MoreLck); // More
        arrows[5].onClick.AddListener(LessLck); // Less

        UpdateValues();


    }


    private void UpdateValues()
    {
        for (int i = 0; i < values.Count; i++)
        {
            values[i].text = nums[i].ToString();
        }
    }
    private void MoreBrv()
    {
        if (availablePoints > 0)
        {
            bravePoints++;
            availablePoints--;
            nums[0] = availablePoints;
            nums[1] = bravePoints;
            UpdateValues();
        }
    }
    private void LessBrv()
    {
        if (bravePoints > -3)
        {
            bravePoints--;
            availablePoints++;
            nums[0] = availablePoints;
            nums[1] = bravePoints;
            UpdateValues();
        }
    }
    private void MoreNrv()
    {
        if (availablePoints > 0)
        {
            nervePoints++;
            availablePoints--;
            nums[0] = availablePoints;
            nums[2] = nervePoints;
            UpdateValues();
        }
    }
    private void LessNrv()
    {
        if (nervePoints > -3)
        {
            nervePoints--;
            availablePoints++;
            nums[0] = availablePoints;
            nums[2] = nervePoints;
            UpdateValues();
        }
    }
    private void MoreLck()
    {
        if (availablePoints > 0)
        {
            luckPoints++;
            availablePoints--;
            nums[0] = availablePoints;
            nums[3] = luckPoints;
            UpdateValues();
        }
    }
    private void LessLck()
    {
        if (luckPoints > -3)
        {
            luckPoints--;
            availablePoints++;
            nums[0] = availablePoints;
            nums[3] = luckPoints;
            UpdateValues();
        }
    }
    public void SaveStats()
    {
        storage.brvPoints = bravePoints;
        storage.nrvPoints = nervePoints;
        storage.lckPoints = luckPoints;
    }
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
