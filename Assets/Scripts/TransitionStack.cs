using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransitionStack {

	public static Stack<string> prevScene = new Stack<string>();

	public static void PushScene(string sceneName){
		prevScene.Push(sceneName);
	}

	public static string PopScene(){
		return prevScene.Pop();
	}

	public static string PeekScene(){
		return prevScene.Peek();
	}


}
