using UnityEngine;
/// <summary>
/// Script <c>ColorFilterScript</c> is responsible for setting the applied filter on collision. Also does it set the color of the attached GameObject according to the filter color. 
/// </summary>
public class ColorFilterScript : MonoBehaviour
{
    /// <summary>
    /// Currently selected color
    /// </summary>
    Singleton.Color Color;
    void Start()
    {
        Color = Singleton.Instance.AvailableColorFilters[Random.Range(0, Singleton.Instance.AvailableColorFilters.Count)];
        gameObject.name = "ColorFilter";

        void SetColor(UnityEngine.Color color)
        {
            gameObject.GetComponent<Renderer>().material.color = color;
        }
        switch (Color)
        {
            case Singleton.Color.Blue:
                SetColor(UnityEngine.Color.blue);
                break;
            case Singleton.Color.White:
                SetColor(UnityEngine.Color.white);
                break;
            case Singleton.Color.Black:
                SetColor(UnityEngine.Color.black);
                break;
            case Singleton.Color.Red:
                SetColor(UnityEngine.Color.red);
                break;
            case Singleton.Color.Green:
                SetColor(UnityEngine.Color.green);
                break;
            case Singleton.Color.Orange:
                SetColor(new UnityEngine.Color(1.0f, 0.5f, 0.0f, 1.0f));
                break;
            case Singleton.Color.Pink:
                SetColor(UnityEngine.Color.magenta);
                break;
            case Singleton.Color.Grey:
                SetColor(UnityEngine.Color.gray);
                break;
            case Singleton.Color.Brown:
                SetColor(new UnityEngine.Color(0.5f, 0.25f, 0.0f, 1.0f));
                break;
        }
    }
    /// <summary>
    /// Sets color filter on collision and destroys the gameobject
    /// </summary>
    /// <param name="collision"></param> Registered Collision
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!Singleton.Instance.AppliedColorFilters.Contains(Color))
            {
                Singleton.Instance.AppliedColorFilters.Add(Color);
            }
            Destroy(gameObject);
        }
    }
}
