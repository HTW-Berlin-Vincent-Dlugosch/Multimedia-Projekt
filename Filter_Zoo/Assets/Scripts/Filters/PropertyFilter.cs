using UnityEngine;
/// <summary>
/// Script <c>PropertyFilter</c> responsible to apply property filter 
/// </summary>
public class PropertyFilter : MonoBehaviour
{
    /// <summary>
    /// Selected Property
    /// </summary>
    public Singleton.Property Property;
    void Start()
    {
        gameObject.name = "PropertyFilter";
    }
    /// <summary>
    /// Sets property filter on collision and destroys the gameobject
    /// </summary>
    /// <param name="collision"></param> Registered Collision
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!Singleton.Instance.AppliedPropertyFilters.Contains(Property))
            {
                Singleton.Instance.AppliedPropertyFilters.Add(Property);
            }
            Destroy(gameObject);
        }
    }
}
