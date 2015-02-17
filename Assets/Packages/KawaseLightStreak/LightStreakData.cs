﻿using UnityEngine;
using System.Collections;

namespace KawaseLightStreak {

	public class LightStreakData : ScriptableObject {
		public enum ShapeEnum { Cross = 0, Star = 1, Snow = 2, Octet = 3 }
		public static readonly string[] ShapeLabels = new string[]{ "Cross", "Star", "Snow", "Octet" };
		public static readonly int[] ShapeNums = new int[]{ 4, 5, 6, 8 };
		
		public Material kawase;
		public float atten = 0.95f;
		public int n = 3;
		public int lod = 2;
		public ShapeEnum shape = ShapeEnum.Cross;
		public float angle = 45f;
	}
}