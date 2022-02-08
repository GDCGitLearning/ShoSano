using UnityEngine;

public class SceneSingleton<T> : SystemBehaviour where T : SystemBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance is null)
                {
                    GameObject gameObject = new GameObject(typeof(T).Name);
                    _instance = gameObject.AddComponent<T>();
                }
                _instance.Initialize();
            }
            return _instance;
        }
    }

    public override void Initialize()
    {
        Debug.Log($"{name} is Initialized");
    }
}
