using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPanel : MonoBehaviour
{
    public GameObject HPanel, FastPanel, SlowPanel, FruitsPanel, SwithcerPanel, GatePanel, ButterflyPanel, SpikeTrapPanel, DecorPanel, WallPanel, FinishPanel;
    public void LoadHelpMenu()
    {
        HPanel.SetActive(true);
        FastPanel.SetActive(false);
        SlowPanel.SetActive(false);
        FruitsPanel.SetActive(false);
        SwithcerPanel.SetActive(false);
        GatePanel.SetActive(false);
        ButterflyPanel.SetActive(false);
        SpikeTrapPanel.SetActive(false);
        DecorPanel.SetActive(false);
        WallPanel.SetActive(false);
        FinishPanel.SetActive(false);
    }

    public void LoadFastPanel()
    {
        HPanel.SetActive(false);
        FastPanel.SetActive(true);
    }

    public void LoadSlowPanel()
    {
        HPanel.SetActive(false);
        SlowPanel.SetActive(true);
    }
    public void LoadFruitsPanel()
    {
        HPanel.SetActive(false);
        FruitsPanel.SetActive(true);
    }
    public void LoadSwithcerPanel()
    {
        HPanel.SetActive(false);
        SwithcerPanel.SetActive(true);
    }
    public void LoadGatePanel()
    {
        HPanel.SetActive(false);
        GatePanel.SetActive(true);
    }
    public void LoadButterflyPanel()
    {
        HPanel.SetActive(false);
        ButterflyPanel.SetActive(true);
    }
    public void LoadSpikeTrapPanel()
    {
        HPanel.SetActive(false);
        SpikeTrapPanel.SetActive(true);
    }
    public void LoadDecorPanel()
    {
        HPanel.SetActive(false);
        DecorPanel.SetActive(true);
    }
    public void LoadWallPanel()
    {
        HPanel.SetActive(false);
        WallPanel.SetActive(true);
    }
    public void LoadFinishPanel()
    {
        HPanel.SetActive(false);
        FinishPanel.SetActive(true);
    }
}
