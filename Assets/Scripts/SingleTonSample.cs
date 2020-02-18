using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTonSample
{
	private volatile static SingleTonSample singleTonObject;
	private static object lockingObject = new object();

	private SingleTonSample()
	{

	}

	// method untuk men-instance suatu class itu sendiri
	// dengan mengembalikan nilai itu sendiri
	public static SingleTonSample InstanceCreation()
	{
		if(singleTonObject == null)
		{
			lock (lockingObject)
			{
				if(singleTonObject == null)
				{
					singleTonObject = new SingleTonSample();
				}
			}
		}
		return singleTonObject;
	}

	public void DisplayMessage()
	{
		Debug.Log("Kelas Singleton!");
	}
}
