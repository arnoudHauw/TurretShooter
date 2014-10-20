using UnityEngine;
using System.Collections;

public enum Level
{
	Fast,
	Slow
}

public class Enemy 
{
	public string name;
	private int level;

	public Enemy(string _name, int _level)
	{
		name = _name;
		level = _level;
	}
}
