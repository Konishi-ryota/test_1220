using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public int InitPoolSize;
    [SerializeField] private Bullet objectToPool;
    private Stack<Bullet> stack;
    private List<Bullet> activeObjects = new();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupPool();
    }

    public void SetupPool()
    {
        stack = new();
        Bullet instance = null;
        for (int i = 0; i < InitPoolSize; i++)
        {
            instance = Instantiate(objectToPool);
            instance.Pool = this;
            instance.gameObject.SetActive(false);
            stack.Push(instance);
        }
    }

    public Bullet GetPooledObject()
    {
        Bullet newInstance;
        if (stack.Count == 0)
        {
            newInstance = Instantiate(objectToPool);
            newInstance.Pool = this;
        }
        else
        {
            newInstance = stack.Pop();
        }
        newInstance.gameObject.SetActive(true);
        activeObjects.Add(newInstance);
        return newInstance;
    }
    public void ReturnToPool(Bullet pooledObject)
    {
        activeObjects.Remove(pooledObject);
        pooledObject.gameObject.SetActive(false);
        stack.Push(pooledObject);
    }
    public void Create()
    {
        GetPooledObject();
    }
    public void Destroy()
    {
        //ÅŒã‚©‚çˆêŒÂ–Ú‚ð‘qŒÉ‚É–ß‚·
        activeObjects[^1].Release();
    }
}
