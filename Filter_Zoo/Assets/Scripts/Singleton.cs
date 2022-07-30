using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script <c>Singleton</c> Hold all global data like AppliedColorFilters or NPC and NPC to find. Can also be called to reset game state.
/// </summary>
public class Singleton : MonoBehaviour
{
    /// <summary>
    /// Self instance to access sigleton data
    /// </summary>
    public static Singleton Instance { get; private set; }
    /// <summary>
    /// All available colors
    /// </summary>
    public enum Color
    {
        Blue, White, Black, Red, Green, Orange, Pink, Grey, Brown
    }
    /// <summary>
    /// All available sizes
    /// </summary>
    public enum Size
    {
        Small, Medium, Large
    }
    /// <summary>
    /// All possible properties
    /// </summary>
    public enum Property
    {
        Hat, Weapon, Nothing
    }
    /// <summary>
    /// All available npcs
    /// </summary>
    public List<GameObject> npcs;
    /// <summary>
    /// Applied Color Filters the were collected by player
    /// </summary>
    public List<Color> AppliedColorFilters = new();
    /// <summary>
    /// Applied Size Filters the were collected by player
    /// </summary>
    public List<Size> AppliedSizeFilters = new();
    /// <summary>
    /// Applied Property Filters the were collected by player
    /// </summary>
    public List<Property> AppliedPropertyFilters = new();
    /// <summary>
    /// Available Color Filters selectd in start menu
    /// </summary>
    public List<Color> AvailableColorFilters = new();
    /// <summary>
    /// Available Size Filters selectd in start menu
    /// </summary>
    public List<Size> AvailableSizeFilters = new();
    /// <summary>
    /// Available Property Filters selectd in start menu
    /// </summary>
    public List<Property> AvailablePropertyFilters = new();
    /// <summary>
    /// Npc that is to find by player
    /// </summary>
    public GameObject npcToFind;

    private void Awake()
    {
        if (Instance == null)
        {
            ResetSingleton();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ResetSingleton()
    {
        AvailableColorFilters = new List<Color>() { Color.Blue, Color.White, Color.Black, Color.Red, Color.Green, Color.Orange, Color.Pink, Color.Grey, Color.Brown };
        if (npcToFind)
        {
            npcs.Add(npcToFind);
        }
        npcToFind = npcs[Random.Range(0, npcs.Count)];
        npcs.Remove(npcToFind);
        AppliedColorFilters = new List<Color>();
        AppliedSizeFilters = new List<Size>();
        AppliedPropertyFilters = new List<Property>();
        Instance = this;
    }
}
