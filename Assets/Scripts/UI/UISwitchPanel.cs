// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using System.Linq;
using UnityEngine;

public class UISwitchPanel : MonoBehaviour
{
    [SerializeField] private RectTransform[] panels;

    private RectTransform _currentPanel;
    
    public RectTransform[] Panel
    {
        get => this.panels;
    }

    private void Awake()
    {
        foreach (var panel in this.panels)
            panel.gameObject.SetActive(false);
        
        SwitchTo(this.panels.Length > 0 ? this.panels[0] : null);
    }

    public void SwitchTo(RectTransform panel)
    {
        if (!this.panels.Contains(panel))
        {
            Debug.LogWarning("Cannot switch to untracked panel.");
            return;
        }

        if (this._currentPanel)
            this._currentPanel.gameObject.SetActive(false);
        this._currentPanel = panel;
        this._currentPanel.gameObject.SetActive(true);
    }
}