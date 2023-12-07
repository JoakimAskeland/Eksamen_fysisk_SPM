using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// Abstract class, since it is intended as a base class of other classes, not instantiated on its own.
// No MonoBehaviour
public abstract class State
{
    protected float time { get; set; }
    protected float fixedTime { get; set; }
    protected float lateTime { get; set; }

    public StateMachine machine;

    // Used to initialize variables
    public virtual void OnEnter(StateMachine _stateMachine)
    {
        machine = _stateMachine;
    }

    // Used to update variables with blocks of logic
    public virtual void OnUpdate()
    {
        time = Time.deltaTime;
    }
    public virtual void OnFIxedUpdate()
    {
        fixedTime = Time.deltaTime;
    }
    public virtual void OnLateUpdate()
    {
        lateTime = Time.deltaTime;
    }

    // Used to clean up hanging references and variables
    public virtual void OnExit()
    {

    }


    #region Passthrough Metods

    /// <summary>
    /// Removes a gameobject, component or asset.
    /// </summary>
    /// <param name="obj">The type of Component to retrieve.</param>
    /// 
    protected static void Destroy(UnityEngine.Object obj)
    {
        UnityEngine.Object.Destroy(obj);
    }

    /// <summary>
    /// Returns the component of type T if the gameobject has one attached, null if it does not.
    /// </summary>
    /// <typeparam name="T""></typeparam>
    /// <returns></returns>
    /// 
    protected T GetComponent<T>() where T : Component { return machine.GetComponent<T>(); }

    /// <summary>
    /// Returns the component of Type <paramref name="type"/> if the gameobject has one attached, null if it does not.
    /// </summary>
    /// <param name="type">The type of Component to retrieve.</param>
    /// <returns></returns>
    /// 
    protected Component GetComponent(System.Type type) {  return machine.GetComponent(type); }

    /// <summary>
    /// Returns the component with name <paramref name="type"/> if the gameobject has one attached, null if it does not.
    /// </summary>
    /// <param name="type">The type of Component to retrieve.</param>
    /// <returns></returns>
    /// 
    protected Component GetComponent(string type) { return machine.GetComponent(type); }

    #endregion
}
