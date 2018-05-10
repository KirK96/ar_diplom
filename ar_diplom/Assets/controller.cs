using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;

namespace ConsoleApplication

public class controller : MonoBehaviour {

	void Start() {
		
	}
	
	void Update() {
		
	}

	void getInstructions() {
		static void Main(string[] args)	{
			string url = "http://localhost:8080";

			using (var webClient = new WebClient())	{
				var response = webClient.DownloadString(url);
			}
		}
	}
}
