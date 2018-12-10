using UnityEngine;

public interface IUnityService
{
    bool GetKeyDown(string keyName);
}

public class UnityService : IUnityService
{
    public bool GetKeyDown(string keyName)
    {
        return Input.GetKeyDown(keyName);
    }
}