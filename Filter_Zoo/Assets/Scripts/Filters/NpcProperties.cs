using UnityEngine;
/// <summary>
/// Script <c>NpcProperties</c> Holds properties of NPC to decide if npc should be removed if one of the properties are in the filter lists.
/// Also removes NPC if conditions are met.
/// </summary>
public class NpcProperties : MonoBehaviour
{
    /// <summary>
    /// Primary color of NPC
    /// </summary>
    public Singleton.Color Color = Singleton.Color.Blue;
    /// <summary>
    /// Size of npc. Is not used.
    /// </summary>
    public Singleton.Size Size = Singleton.Size.Medium;
    /// <summary>
    /// First Property like hat or weapon
    /// </summary>
    public Singleton.Property Property_1 = Singleton.Property.Nothing;
    /// <summary>
    /// Second Property like hat or weapon
    /// </summary>
    public Singleton.Property Property_2 = Singleton.Property.Nothing;
    void Update()
    {
        if (Singleton.Instance.AppliedColorFilters.Contains(Color) ||
            Singleton.Instance.AppliedSizeFilters.Contains(Size) ||
            Singleton.Instance.AppliedPropertyFilters.Contains(Property_1) ||
            Singleton.Instance.AppliedPropertyFilters.Contains(Property_2))
        {
            if (gameObject.tag != "NPCTOFIND")
            {
                Destroy(gameObject);
            }
        }
    }
}
