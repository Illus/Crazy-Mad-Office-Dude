﻿using UnityEngine;
using UnityEditor;
using System.Collections;

//Sets FBX Mesh Scale Factor to 1.0
public class FBX_Import : AssetPostprocessor
{
	public const float importScale = 1.0f;

	void OnPreprocessModel()
	{
		ModelImporter importer = assetImporter as ModelImporter;
		importer.globalScale = importScale;
	}
}
