using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Script <c>MenuToggleColor</c> is responsible for setting available filters in pool in start menu of the game
/// </summary>
public class MenuToggleColor : MonoBehaviour
{
    /// <summary>
    /// Color that is connected to toggle
    /// </summary>
    public Singleton.Color color;
    /// <summary>
    /// Toggle that is displayed in menu
    /// </summary>
    Toggle m_Toggle;

    void Start()
    {
        m_Toggle = GetComponent<Toggle>();
        m_Toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(m_Toggle);
        });

    }

    void ToggleValueChanged(Toggle change)
    {
        if (change.isOn)
        {
            Singleton.Instance.AvailableColorFilters.Add(color);
            Debug.Log("Color filter added: " + color.ToString());
        }
        else
        {
            Singleton.Instance.AvailableColorFilters.Remove(color);
            Debug.Log("Color filter removed: " + color.ToString());
        }
    }
}
